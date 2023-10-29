/*
 * Created by Ranorex
 * User: user
 * Date: 10/29/2023
 * Time: 3:06 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using Excel = Microsoft.Office.Interop.Excel;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace ExcelTests
{
    /// <summary>
    /// Description of ManipulateExcelFile.
    /// </summary>
    [TestModule("BF537A2D-DF13-461B-8DF4-C1C4D021A89E", ModuleType.UserCode, 1)]
    public class CreateExcelWithValueAndFormula : ITestModule
    {
    	 [DllImport("user32.dll")]
    	static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateExcelWithValueAndFormula()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Report.Info("START CODE");
 			
            //get test suite parameter values
            string filename = TestSuite.CurrentTestContainer.Parameters["ExcelFilename"].ToString();
            
            int expectedValue =  Convert.ToInt32(TestSuite.CurrentTestContainer.Parameters["ComputedValue"]);
            
            string startColumn = "A";
			
           	Report.Info("Excel Filename: "+filename);
           	
           	Report.Info("Computed Value: "+expectedValue.ToString());
           	
         	int[] values = new int[] {10,2,10,3,9};
           	
            string formulaCell = CreateWorkbookWithValues(filename, values, startColumn);
   			
            Ranorex.Form apps = Host.Current.FindSingle<Ranorex.Form>("/form[@processname='EXCEL']");
            
            if (apps != null)
            {
            
            	//get table of the opened excel file.
            	
            	Ranorex.Table tableList = apps.FindDescendant<Ranorex.Table>();
            	
            	//Table tableList = apps.FindSingle<Ranorex.Table>("//tabpagelist[@automationid='"+filename+".xlsx']/tabpage[@automationid='Sheet1']/table[@automationid='Grid']");
            	
            	if (tableList != null)
            	{
            		
            		//navigate to cell with formula
            		Report.Info("Formula Cell to Check: "+ formulaCell);
            		
            		IList<Ranorex.Cell> AllCells = tableList.FindDescendants<Ranorex.Cell>();
					
					Ranorex.Cell navigatedCell =  NavigateCell(AllCells, formulaCell);
					
					//validate cell value vs expected output 
					if (navigatedCell != null)
						ValidateCellValue(expectedValue, navigatedCell);
					else
						Report.Error("CellNotFound","Cell was not found in the created workbook: "+formulaCell);
            	}
            	
            	
            }
            
            Report.Info("END CODE");
                                                                        
                                                                        

        }
        
        private string CreateWorkbookWithValues(string filename, int[] values, string startColumn)
        {
 
        	Report.Info("Creating Workbook...");
        	
        	string runningDirectory = TestSuite.WorkingDirectory;
        	
        	string fullFilename = string.Format(@"{0}\{1}.xlsx", runningDirectory, filename);
        	
        	if (File.Exists(fullFilename))
				File.Delete(fullFilename);
        	
			Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
			
			Excel.Workbook workbook = null;

			Excel.Worksheet worksheet = null;
	
			int maxRows = 5;
			int lastRow = 1;
			int lastColumn = 1;
			
			try {
				
				workbook = xlApp.Workbooks.Add(Type.Missing);
				
				worksheet = (Excel.Worksheet)workbook.ActiveSheet;
				
				//Random rnd = new Random();
				int convertColumnToNumber = ExcelColumnNameToNumber(startColumn);
				
				for (int rows = 1; rows <= maxRows; rows++) {
					
					Excel.Range excelCell = (Excel.Range)worksheet.Rows.Cells[rows, convertColumnToNumber];
					
					excelCell.Value = values[rows-1];
					
					//excelCell.Value = rnd.Next(1,50);
					
					lastRow = rows;
				}
				
				//add formula to next row
				
				Excel.Range formulaCell = (Excel.Range)worksheet.Rows.Cells[lastRow+1, lastColumn];
				
				formulaCell.Formula = string.Format("=({0}1+{0}2)*{0}3+{0}4-{0}5",startColumn);
				
//				formulaCell.Formula = "=(A1+A2)*A3+A4-A5";
				
				Report.Info("Formula: " + formulaCell.Formula);

				workbook.SaveAs(fullFilename, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
	            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
	            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				
				xlApp.WindowState = Excel.XlWindowState.xlMaximized;
				xlApp.Visible = true;
		
				TestSuite.CurrentTestContainer.ParentContainer.Parameters["AppProcessID"] = GetExcelProcess(xlApp).Id.ToString();

				
					
			} catch (Exception ex) {
				
				Report.Info(ex.ToString());
				
				throw ex;
			}


			Report.Info("Workbook Created.");
			
			Report.Info("Workbook Path: "+fullFilename);
			
			return GetExcelColumnName(lastColumn)+(lastRow+1);

        }
        
        private Process GetExcelProcess(Excel.Application xlApp)
        {
	        int id;
	        GetWindowThreadProcessId(xlApp.Hwnd, out id);
	        return Process.GetProcessById(id);
        }
        
        private int ExcelColumnNameToNumber(string columnName)
		{
		    if (string.IsNullOrEmpty(columnName)) throw new ArgumentNullException("columnName");
		
		    columnName = columnName.ToUpperInvariant();
		
		    int sum = 0;
		
		    for (int i = 0; i < columnName.Length; i++)
		    {
		        sum *= 26;
		        sum += (columnName[i] - 'A' + 1);
		    }
		
		    return sum;
		}
        
        public string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }
        
        private Ranorex.Cell NavigateCell(IList<Ranorex.Cell> cellList, string cellToFind)
        {
        	
        	Report.Info(string.Format("Navigating Cell Name: {0}",cellToFind));
        	
        	Ranorex.Cell cellFound = null;
        	
        	foreach (Ranorex.Cell ThisCell in cellList)
            {
        		Ranorex.ExcelRange range = new ExcelRange(ThisCell.Element);
				
				string currentCellName = range.Address;	    		
        		
            	//string currentCellName = ThisCell.Element.GetAttributeValue("NAME").ToString();
				
            	if (currentCellName.ToUpper() == cellToFind)
            	{
            		Report.Info("CELL FOUND.");
            		cellFound = new Ranorex.Cell(ThisCell.Element);
            		break;
            	}
            }
        	
        	
        	if (cellFound != null)
        	{
        		
        	  Report.Info("SELECTING FOUND CELL...");
        	  
        	  cellFound.Click();
        	  
        	  Delay.Milliseconds(100);
        	  
        	  Report.Screenshot(cellFound.Element);
        	  
        	  Report.Info("CELL WAS SUCCESSFULLY NAVIGATED.");

        	}
        	
            return cellFound;
        	
        }
        
        private void ValidateCellValue (int expectedValue, Ranorex.Cell navigatedCell)
        {
        	Report.Info("Expected cell value: "+ expectedValue);
        	
        	int currentCellValue = Convert.ToInt32(navigatedCell.Text);
        	
        	Report.Info("Navigated Cell Value: "+currentCellValue);
        	
        	try {
        			Ranorex.Validate.AreEqual(expectedValue, currentCellValue,"");
        		    Report.Info("Expected Cell Value Matches");
        		    
        	} catch (Ranorex.ValidationException) {
        			Report.Info("Expected value does not match with navigated cell");
        	}

        }
        
    }
}
