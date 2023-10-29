/*
 * Created by Ranorex
 * User: user
 * Date: 10/29/2023
 * Time: 12:27 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace ExcelTests
{
    /// <summary>
    /// Description of ManipulateCell.
    /// </summary>
    [TestModule("13B17DB9-BAA0-423F-A536-15BA594AFAF6", ModuleType.UserCode, 1)]
    public class SelectCells : ITestModule
    {
    	
    	string _cellToFind;

    	public string cellToFind {
    		get { return _cellToFind; }
    		set { _cellToFind = value; }
    	}
    	
    	string _cellToNavigate;
    	
    	public string cellToNavigate {
    		get { return _cellToNavigate; }
    		set { _cellToNavigate = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectCells()
        {
            // Do not delete - a parameterless constructor is required!
            
            this._cellToFind = TestSuite.CurrentTestContainer.Parameters["CellToFind"].ToString();
            this._cellToNavigate = TestSuite.CurrentTestContainer.Parameters["CellToNavigate"].ToString();
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
            Delay.SpeedFactor = 5.0;
 
            Report.Info("START CODE");
            
            Report.Info("Cell to Find: "+_cellToFind);
            
            Report.Info("Cell to Navigate: " +_cellToNavigate);
            
         	var repo = ExcelTestsRepository.Instance;
            
	         Table cellList = repo.Book1Excel.Sheet1;
	         IList<Ranorex.Cell> AllCells = cellList.FindDescendants<Ranorex.Cell>();
             CellNavigate(AllCells, _cellToFind, _cellToNavigate);
	
            Report.Info("END CODE");
            
           
        }
        
        private void CellNavigate (IList<Ranorex.Cell> cellList, string cellToFind, string cellToNavigateNext)
        {
        	
        	Ranorex.Cell cellFound = null;
        	
        	Ranorex.Cell cellToNavigate = null;
        	
        	foreach (Ranorex.Cell ThisCell in cellList)
            {
            	string currentCellName = ThisCell.Element.GetAttributeValue("NAME").ToString();

            	if (currentCellName.ToUpper() == cellToFind)
            	{
            		cellFound = new Ranorex.Cell(ThisCell.Element);
            	}
            	
            	if (currentCellName.ToUpper() == cellToNavigateNext)
            	{
            		cellToNavigate = new Ranorex.Cell(ThisCell.Element);
            	}
            }
        	
        	
        	if (cellFound != null)
        	{
        	  Report.Info("SELECTING FOUND CELL...");
        	  cellFound.Click();
        	  Report.Screenshot();
        	  
        	}
        	
        	if (cellToNavigate != null)
        	{
        		Report.Info("SELECTING NEXT CELL...");     	  	
        	  	cellToNavigate.Click();
        	  	Report.Screenshot();
        	}
        }
    }
}
