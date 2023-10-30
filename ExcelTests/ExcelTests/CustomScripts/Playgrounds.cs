/*
 * Created by Ranorex
 * User: User
 * Date: 10/30/2023
 * Time: 11:49 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Data;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ExcelTests.CustomScripts
{
    /// <summary>
    /// Description of Playgrounds.
    /// </summary>
    [TestModule("22CFF24E-D18F-47AC-AEDE-998A3705493F", ModuleType.UserCode, 1)]
    public class Playgrounds : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Playgrounds()
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
            var book1Excel = repo.Book1Excel;

			// Create PopupWatcher
			PopupWatcher myPopupWatcher = new PopupWatcher();
			myPopupWatcher.Watch(book1Excel, SaveDialogCallBackMethod);
			myPopupWatcher.Start();
			

			myPopupWatcher.Stop();
                                                                            
        }
        
        private void SaveDialogCallBackMethod(RepoItemInfo info, Element target)
		{
        	Report.Info("POPUP FOUND");
        	
        	Report.Info(info.AbsolutePath.ToString());
        	
        	
		}
    }
}
