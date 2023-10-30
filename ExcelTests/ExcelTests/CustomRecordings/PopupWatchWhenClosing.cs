﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace ExcelTests.CustomRecordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PopupWatchWhenClosing recording.
    /// </summary>
    [TestModule("0535afec-245a-4e49-8f06-2875308934f9", ModuleType.Recording, 1)]
    public partial class PopupWatchWhenClosing : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ExcelTests.ExcelTestsRepository repository.
        /// </summary>
        public static global::ExcelTests.ExcelTestsRepository repo = global::ExcelTests.ExcelTestsRepository.Instance;

        static PopupWatchWhenClosing instance = new PopupWatchWhenClosing();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PopupWatchWhenClosing()
        {
            ExcelProcessId = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PopupWatchWhenClosing Instance
        {
            get { return instance; }
        }

#region Variables

        string _ExcelProcessId;

        /// <summary>
        /// Gets or sets the value of variable ExcelProcessId.
        /// </summary>
        [TestVariable("bbd0f339-2b7b-4d59-a6d0-a31c431cb3c6")]
        public string ExcelProcessId
        {
            get { return _ExcelProcessId; }
            set { _ExcelProcessId = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Closing application with Process ID bound to variable $ExcelProcessId.", new RecordItemIndex(0));
            Host.Current.CloseApplication(int.Parse(ExcelProcessId), 500);
            Delay.Milliseconds(0);
            
            Ranorex.AutomationHelpers.UserCodeCollections.PopupWatcherLibrary.StartPopupWatcher(repo.Book1Excel.SelfInfo, repo.Book1Excel.Save3Info);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "Prompt Popup was found when closing File", repo.Book1Excel.SaveDialog, false, new RecordItemIndex(2));
            
            Ranorex.AutomationHelpers.UserCodeCollections.PopupWatcherLibrary.StopAllPopupWatchers();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
