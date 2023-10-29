/*
 * Created by Ranorex
 * User: user
 * Date: 10/29/2023
 * Time: 12:52 PM
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
    /// Description of CaptureFormulaCell.
    /// </summary>
    [TestModule("542A8B7E-A762-4ADF-AD92-28F798E62BD0", ModuleType.UserCode, 1)]
    public class CaptureFormulaCell : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CaptureFormulaCell()
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
            
            var repo = ExcelTestsRepository.Instance;
            	
            Ranorex.Cell cellA6 = repo.Book1Excel.CellA6;
            
            Report.Info("Current Formula Cell Value: "+cellA6.Text);
            
            TestSuite.CurrentTestContainer.Parameters["CurrentFormulaCellValue"] = cellA6.Text;
            

        }
    }
}
