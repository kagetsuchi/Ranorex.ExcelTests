/*
 * Created by Ranorex
 * User: User
 * Date: 10/30/2023
 * Time: 5:30 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Linq;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace ExcelTests.CustomScripts
{
    /// <summary>
    /// Description of ManipulateExcel.
    /// </summary>
    [TestModule("48C6EF4D-7D42-4CF2-B107-878B81850E41", ModuleType.UserCode, 1)]
    public class ManipulateExcel : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ManipulateExcel()
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
            
            //get table instance
            var repo = ExcelTestsRepository.Instance;
 
            Ranorex.Table gridSheet1 = (Ranorex.Table)repo.Book1Excel.Grid1;
            
            #region INSERT ROWS
            //insert rows
           	Report.Screenshot("Original View", gridSheet1);    
			  	
           	string AddStartRow =  TestSuite.CurrentTestContainer.Parameters["AddStartRow"].ToString();
            int numberOfRowsToAdd = Convert.ToInt32(TestSuite.CurrentTestContainer.Parameters["RowsToAdd"]);
            
            ManipulateRowsAndColumns(gridSheet1, AddStartRow, numberOfRowsToAdd);
            
            Report.Screenshot("Updated View",gridSheet1);
   			#endregion
            
            #region DELETE ROWS
            //delete rows
            Report.Screenshot("Original View", gridSheet1);
		
            string deleteStartRow =  TestSuite.CurrentTestContainer.Parameters["DeleteStartRow"].ToString();
            int numberOfRowsToDelete = Convert.ToInt32(TestSuite.CurrentTestContainer.Parameters["RowsToDelete"]);
   
			ManipulateRowsAndColumns(gridSheet1, deleteStartRow, numberOfRowsToDelete,false, true);
			
			Report.Screenshot("Updated View",gridSheet1);
			#endregion
			
			#region INSERT COLUMNS
			//insert columns	
			Report.Screenshot("Original View", gridSheet1);
			
			string columnAddStart =  TestSuite.CurrentTestContainer.Parameters["AddStartColumn"].ToString();
            int numberOfColumnsToAdd = Convert.ToInt32(TestSuite.CurrentTestContainer.Parameters["ColumnsToAdd"]);
            
			ManipulateRowsAndColumns(gridSheet1, columnAddStart, numberOfColumnsToAdd, true);
			
			Report.Screenshot("Updated View",gridSheet1);
			
			#endregion

			#region DELETE COLUMNS
			//delete columns	
			
			string columnDeleteStart =  TestSuite.CurrentTestContainer.Parameters["DeleteStartColumn"].ToString();
            int numberOfColumnsToDelete = Convert.ToInt32(TestSuite.CurrentTestContainer.Parameters["ColumnsToDelete"]);
			
			Report.Screenshot("Original View", gridSheet1);

			ManipulateRowsAndColumns(gridSheet1, columnDeleteStart, numberOfColumnsToDelete, true,true);
			
			Report.Screenshot("Updated View",gridSheet1);
			
			#endregion
			
			#region Copy Cells
			//copy cells
            Ranorex.Table tableSheet1 = (Ranorex.Table)repo.Book1Excel.Sheet1;
            
            string[] targetCellsToCopy = TestSuite.CurrentTestContainer.Parameters["TargetCellsToCopy"].ToString().Split(',');
            string[] targetCellsToPaste = TestSuite.CurrentTestContainer.Parameters["TargetCellsToPaste"].ToString().Split(',');

            ManipulateCells(tableSheet1, targetCellsToCopy, targetCellsToPaste);
            #endregion
		
        }
        
        //INSERT ROWS BY SELECTING THE GRID CELL AND SHORTCUT KEYS
        private void ManipulateRowsAndColumns (Ranorex.Table excelTable, string startCell, int numberOfItems, bool columns = false, bool delete = false)
        {
        	string process = delete ? "Delete" : "Insert";
        	string target = columns ? "Columns" : "Rows";
        	
        	Ranorex.Report.Info(string.Format("Start {0} {1} | Count: {2}", process, target, numberOfItems));
        	
        	Ranorex.Cell extractedCell = (Ranorex.Cell) excelTable.Element.FindSingle(string.Format("./cell[@name='{0}']", startCell));
  
        	if (extractedCell == null)
        		throw new RanorexException(string.Format("{0} was not found or visible on excel file: {1}", target, startCell));
        	
        	extractedCell.Click();
        	
        	if (extractedCell.Selected)
        	{

        		if (delete)
        		{
        			  extractedCell.PressKeys("{LControlKey down}");
        			  
        				for (int i = 1; i <= numberOfItems; i++) {     			
							extractedCell.PressKeys("{OemMinus}");
        				}
        			  
        			   extractedCell.PressKeys("{LControlKey up}");
        		}
        		
        		else
        		{
        			  extractedCell.PressKeys("{LControlKey down}{LShiftKey down}");
        			  
        				for (int i = 1; i <= numberOfItems; i++) {     			
							extractedCell.PressKeys("{Oemplus}");
        				}
        			
        			   extractedCell.PressKeys("{LShiftKey up}{LControlKey up}");
        		}
        		
        	}
        	
        	Ranorex.Report.Info(string.Format("End {0} {1} | Count: {2}", process, target, numberOfItems));
        }
        
        private void ManipulateCells(Ranorex.Table excelTable, string[] targetCellsToCopy, string[] targetCellsToPaste)
        {
        	Ranorex.Report.Info(string.Format("Start Copying Cells"));
        	
        	Ranorex.Report.Info(string.Format("Cells to Copy: " + string.Join(",", targetCellsToCopy)));

        	List<Ranorex.ExcelRange> allCells = excelTable.FindDescendants<Ranorex.ExcelRange>().ToList();
        	
        	//highlight added cells
        	int copyCounter = 1;
			foreach (string cellName in targetCellsToCopy) 
			{

				Ranorex.ExcelRange cellRangeElement = allCells.Where(e=> e.Address == cellName.ToUpper()).FirstOrDefault();
        		
        		if (cellRangeElement == null)
				throw new Ranorex.RanorexException("Cell was not found in the Excel Instance: "+ cellName);
        		
        		cellRangeElement.Click();
        		
        		if (copyCounter == 1)
     				excelTable.PressKeys("{LControlKey down}");
        		
        		copyCounter++;
			}

			excelTable.PressKeys("{LControlKey up}");
			
			//triger copy	
			excelTable.PressKeys("{LControlKey down}{Ckey}{LControlKey up}");
			
			Report.Screenshot("Target Cells Copied",excelTable);
			
			Ranorex.Report.Info(string.Format("Target Cells to Paste: " +string.Join(",", targetCellsToPaste)));
			
			//select target cells to paste
			
			foreach (string cellsToPaste in targetCellsToPaste) {
				
				Ranorex.ExcelRange cellRangeElement = allCells.Where(e=> e.Address == cellsToPaste.ToUpper()).FirstOrDefault();
			
				if (cellRangeElement == null)
					throw new Ranorex.RanorexException("Cell was not found in the Excel Instance: "+ cellsToPaste);
				
				 cellRangeElement.Click();
				 excelTable.PressKeys("{LControlKey down}{Vkey}{LControlKey up}");
				 
			}
			//triger paste	
			excelTable.PressKeys("{LControlKey down}{Vkey}{LControlKey up}");
			
			Report.Screenshot("Cells Copied to Target Cells",excelTable);
        }
        
        
        
    }
}
