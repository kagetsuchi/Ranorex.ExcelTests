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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ExcelTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ExcelTestsRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("e2534433-f71e-44ec-a31d-ab40ab716087")]
    public partial class ExcelTestsRepository : RepoGenBaseFolder
    {
        static ExcelTestsRepository instance = new ExcelTestsRepository();
        ExcelTestsRepositoryFolders.Book1ExcelAppFolder _book1excel;
        RepoItemInfo _maximizeInfo;
        RepoItemInfo _buttonsaveInfo;

        /// <summary>
        /// Gets the singleton class instance representing the ExcelTestsRepository element repository.
        /// </summary>
        [RepositoryFolder("e2534433-f71e-44ec-a31d-ab40ab716087")]
        public static ExcelTestsRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ExcelTestsRepository() 
            : base("ExcelTestsRepository", "/", null, 0, false, "e2534433-f71e-44ec-a31d-ab40ab716087", ".\\RepositoryImages\\ExcelTestsRepositorye2534433.rximgres")
        {
            _book1excel = new ExcelTestsRepositoryFolders.Book1ExcelAppFolder(this);
            _maximizeInfo = new RepoItemInfo(this, "Maximize", "/form[@processname='EXCEL']/element[@class='FullpageUIHost']/container[@class='NetUIHWND']/button[2]", 30000, null, "d389ae35-e150-43c1-8ebe-ba884b6be9e0");
            _buttonsaveInfo = new RepoItemInfo(this, "ButtonSave", "/form[@processname='EXCEL']/button[@text='&Save']", 30000, null, "47412e81-8d1c-4935-9809-34d4d29fbe35");
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e2534433-f71e-44ec-a31d-ab40ab716087")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Maximize item.
        /// </summary>
        [RepositoryItem("d389ae35-e150-43c1-8ebe-ba884b6be9e0")]
        public virtual Ranorex.Button Maximize
        {
            get
            {
                 return _maximizeInfo.CreateAdapter<Ranorex.Button>(true);
            }
        }

        /// <summary>
        /// The Maximize item info.
        /// </summary>
        [RepositoryItemInfo("d389ae35-e150-43c1-8ebe-ba884b6be9e0")]
        public virtual RepoItemInfo MaximizeInfo
        {
            get
            {
                return _maximizeInfo;
            }
        }

        /// <summary>
        /// The ButtonSave item.
        /// </summary>
        [RepositoryItem("47412e81-8d1c-4935-9809-34d4d29fbe35")]
        public virtual Ranorex.Button ButtonSave
        {
            get
            {
                 return _buttonsaveInfo.CreateAdapter<Ranorex.Button>(true);
            }
        }

        /// <summary>
        /// The ButtonSave item info.
        /// </summary>
        [RepositoryItemInfo("47412e81-8d1c-4935-9809-34d4d29fbe35")]
        public virtual RepoItemInfo ButtonSaveInfo
        {
            get
            {
                return _buttonsaveInfo;
            }
        }

        /// <summary>
        /// The Book1Excel folder.
        /// </summary>
        [RepositoryFolder("e22d9a7c-9790-46a6-aa66-eae57fc6476e")]
        public virtual ExcelTestsRepositoryFolders.Book1ExcelAppFolder Book1Excel
        {
            get { return _book1excel; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class ExcelTestsRepositoryFolders
    {
        /// <summary>
        /// The Book1ExcelAppFolder folder.
        /// </summary>
        [RepositoryFolder("e22d9a7c-9790-46a6-aa66-eae57fc6476e")]
        public partial class Book1ExcelAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _restoredownInfo;
            RepoItemInfo _text1001Info;
            RepoItemInfo _filetabbuttonInfo;
            RepoItemInfo _somelistitemInfo;
            RepoItemInfo _aiostartdocument1Info;
            RepoItemInfo _openotherworkbooksInfo;
            RepoItemInfo _browseInfo;
            RepoItemInfo _linkedcellInfo;
            RepoItemInfo _netuianchorInfo;
            RepoItemInfo _excelInfo;
            RepoItemInfo _celllistInfo;
            RepoItemInfo _cellc2Info;
            RepoItemInfo _excel6Info;
            RepoItemInfo _systemitemnamedisplayInfo;
            RepoItemInfo _buttonopenInfo;
            RepoItemInfo _saveasInfo;
            RepoItemInfo _browse1Info;
            RepoItemInfo _buttonopen1Info;
            RepoItemInfo _excel1Info;
            RepoItemInfo _cella1Info;
            RepoItemInfo _cella6Info;
            RepoItemInfo _closeInfo;
            RepoItemInfo _saveInfo;

            /// <summary>
            /// Creates a new Book1Excel  folder.
            /// </summary>
            public Book1ExcelAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Book1Excel", "/form[@processname='EXCEL']", parentFolder, 30000, null, true, "e22d9a7c-9790-46a6-aa66-eae57fc6476e", "")
            {
                _restoredownInfo = new RepoItemInfo(this, "RestoreDown", "element[2]/container[@caption='Ribbon']//container[@name='Ribbon']/button[@name='Maximize']", ".//button[2]", 30000, null, "32927ec0-74ec-4c39-bd44-01880707f18c");
                _text1001Info = new RepoItemInfo(this, "Text1001", "?/?/container[@class='DirectUIHWND']/element[1]/combobox[@class='ComboBox']/text[@controlid='1001']", ".//text[@controlid='1001']", 30000, null, "38a1e864-b298-42e4-905b-dffc43f4eac2");
                _filetabbuttonInfo = new RepoItemInfo(this, "FileTabButton", "element[2]/container[@caption='Ribbon']//container[@name='Ribbon']/button[@automationid='FileTabButton']", ".//button[@automationid='FileTabButton']", 30000, null, "048c3ea2-a0e0-414a-826e-66d9172e0133");
                _somelistitemInfo = new RepoItemInfo(this, "SomeListItem", "element/?/?/container//list/listitem", ".//container/container/container/list/listitem", 30000, null, "8fb321d0-8115-4b08-913a-aff8d2a3458f");
                _aiostartdocument1Info = new RepoItemInfo(this, "AIOStartDocument1", ".//container[@automationid='BackstageView']//list/listitem", ".//container[@automationid='BackstageView']", 30000, null, "6c62ffb0-02bc-454d-9a36-029e541aed5f");
                _openotherworkbooksInfo = new RepoItemInfo(this, "OpenOtherWorkbooks", ".//container[@automationid='BackstageView']/container[@name='New']/?/?/container[@name='Recent']/link[@name='Open Other Workbooks']", ".//container[@automationid='BackstageView']", 30000, null, "f6c50d54-2fee-4baf-a14d-0b70c7b59a62");
                _browseInfo = new RepoItemInfo(this, "Browse", ".//container[@automationid='BackstageView']/container[@name='Open']/container[@name='Open']/?/?/contextmenu[@name='Open']/?/?/button[@name='Browse']", ".//button[@name='Browse']", 30000, null, "98273c1d-fb1b-439c-bca5-6876f6efecbf");
                _linkedcellInfo = new RepoItemInfo(this, "LinkedCell", ".//container[@name='Ribbon']/container[@name='Lower Ribbon']/?/?/container[@name='Styles']/container[@name='Cell Styles']/?/?/container[@name='Cell Styles']/table[@name='Cell Styles']/listitem[@name='Linked Cell']", ".//listitem[@name='Linked Cell']", 30000, null, "e0358cf4-0cee-47d2-a470-376cf6b01d48");
                _netuianchorInfo = new RepoItemInfo(this, "NetUIAnchor", ".//container[@name='Ribbon']/container[@name='Lower Ribbon']/container[@name='Home']/container[@name='Styles']/container[@name='Cell Styles']/menuitem[@classname='NetUIAnchor']", ".//menuitem[@helptext>'A colorful style is a great']", 30000, null, "99dc032c-1f22-45e4-8870-601a2655e78d");
                _excelInfo = new RepoItemInfo(this, "EXCEL", "element[@class='EXCEL;']", "element[@class='EXCEL;']", 30000, null, "a1b9b200-7b49-404c-9721-971bd2370aee");
                _celllistInfo = new RepoItemInfo(this, "CellList", ".//tabpagelist[@automationid='Book1.xlsx']/tabpage[@automationid='Sheet1']/table[@automationid='Grid']", "element", 30000, null, "c117cf30-ff9d-4aa3-b5ea-765892a8eb44");
                _cellc2Info = new RepoItemInfo(this, "CellC2", ".//tabpagelist[@automationid='Book1.xlsx']/tabpage[@automationid='Sheet1']/?/?/cell[@name='C2']", ".//cell[@name='C2']", 30000, null, "809ce61c-1945-4726-acbf-9e0549170ebc");
                _excel6Info = new RepoItemInfo(this, "EXCEL6", "?/?/element[@class='EXCEL6']", "?/?/element[@class='EXCEL6']", 30000, null, "da2791ee-7538-4ac1-bec5-da9df4222972");
                _systemitemnamedisplayInfo = new RepoItemInfo(this, "SystemItemNameDisplay", "element[@class='DUIViewWndClassName']//container[@caption='ShellView']/?/?/listitem[@automationid='1']/text[@automationid='System.ItemNameDisplay']", ".//listitem[@automationid='1']/text[@automationid='System.ItemNameDisplay']", 30000, null, "3b0bb978-948a-43fa-a8e0-5d4bc1c9c08f");
                _buttonopenInfo = new RepoItemInfo(this, "ButtonOpen", "form[@processname='EXCEL']/button[@text='&Open']", "button[@text='&Open']", 30000, null, "0e9d5e19-2e2f-47ca-a7b3-af845087d698");
                _saveasInfo = new RepoItemInfo(this, "SaveAs", ".//container[@automationid='BackstageView']/list[@automationid='NavBarMenu']/listitem[@name='Save As']", ".//listitem[@name='Save As']", 30000, null, "6623c739-41e7-46dd-9fd2-14df085b7456");
                _browse1Info = new RepoItemInfo(this, "Browse1", ".//container[@automationid='BackstageView']/container[@name='Save As']/container[@name='Saving Features']/?/?/contextmenu[@name='Saving Features']/?/?/button[@name='Browse']", ".//button[@name='Browse']", 30000, null, "a6124daf-552f-454b-8b07-e9cfe67463fc");
                _buttonopen1Info = new RepoItemInfo(this, "ButtonOpen1", "button[@text='&Open']", "button[@text='&Open']", 30000, null, "317630d3-e887-483d-ad5e-38314245e258");
                _excel1Info = new RepoItemInfo(this, "EXCEL1", "element[@class='EXCEL<']", "element[@class='EXCEL<']", 30000, null, "40f4ba2f-ebae-4976-9dff-796dfa6af281");
                _cella1Info = new RepoItemInfo(this, "CellA1", ".//table[@name='Sheet1']/row[@index='1']/cell[@address='A1']", ".//cell[@address='A1']", 30000, null, "b5816f5a-a3fc-42f2-b832-3f339a6e211d");
                _cella6Info = new RepoItemInfo(this, "CellA6", ".//table[@name='Sheet1']/row[@index='6']/cell[@address='A6']", ".//cell[@address='A6']", 30000, null, "b1b5ecb5-cdeb-4df8-b05e-9fa012ef3a26");
                _closeInfo = new RepoItemInfo(this, "Close", "element[2]/container[@caption='Ribbon']//container[@name='Ribbon']/button[@name='Close']", ".//button[@name='Close']", 30000, null, "c2239afe-689c-4f1d-a8b9-32c1a74b7526");
                _saveInfo = new RepoItemInfo(this, "Save", "?/?/form[@name='Microsoft Excel']/button[@name='Save']", ".//button[@name='Save']", 30000, null, "7dc0fe92-f0a2-4cee-8aa8-0e8d48a8961c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e22d9a7c-9790-46a6-aa66-eae57fc6476e")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e22d9a7c-9790-46a6-aa66-eae57fc6476e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RestoreDown item.
            /// </summary>
            [RepositoryItem("32927ec0-74ec-4c39-bd44-01880707f18c")]
            public virtual Ranorex.Button RestoreDown
            {
                get
                {
                    return _restoredownInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RestoreDown item info.
            /// </summary>
            [RepositoryItemInfo("32927ec0-74ec-4c39-bd44-01880707f18c")]
            public virtual RepoItemInfo RestoreDownInfo
            {
                get
                {
                    return _restoredownInfo;
                }
            }

            /// <summary>
            /// The Text1001 item.
            /// </summary>
            [RepositoryItem("38a1e864-b298-42e4-905b-dffc43f4eac2")]
            public virtual Ranorex.Text Text1001
            {
                get
                {
                    return _text1001Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1001 item info.
            /// </summary>
            [RepositoryItemInfo("38a1e864-b298-42e4-905b-dffc43f4eac2")]
            public virtual RepoItemInfo Text1001Info
            {
                get
                {
                    return _text1001Info;
                }
            }

            /// <summary>
            /// The FileTabButton item.
            /// </summary>
            [RepositoryItem("048c3ea2-a0e0-414a-826e-66d9172e0133")]
            public virtual Ranorex.Button FileTabButton
            {
                get
                {
                    return _filetabbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The FileTabButton item info.
            /// </summary>
            [RepositoryItemInfo("048c3ea2-a0e0-414a-826e-66d9172e0133")]
            public virtual RepoItemInfo FileTabButtonInfo
            {
                get
                {
                    return _filetabbuttonInfo;
                }
            }

            /// <summary>
            /// The SomeListItem item.
            /// </summary>
            [RepositoryItem("8fb321d0-8115-4b08-913a-aff8d2a3458f")]
            public virtual Ranorex.ListItem SomeListItem
            {
                get
                {
                    return _somelistitemInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The SomeListItem item info.
            /// </summary>
            [RepositoryItemInfo("8fb321d0-8115-4b08-913a-aff8d2a3458f")]
            public virtual RepoItemInfo SomeListItemInfo
            {
                get
                {
                    return _somelistitemInfo;
                }
            }

            /// <summary>
            /// The AIOStartDocument1 item.
            /// </summary>
            [RepositoryItem("6c62ffb0-02bc-454d-9a36-029e541aed5f")]
            public virtual Ranorex.ListItem AIOStartDocument1
            {
                get
                {
                    return _aiostartdocument1Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The AIOStartDocument1 item info.
            /// </summary>
            [RepositoryItemInfo("6c62ffb0-02bc-454d-9a36-029e541aed5f")]
            public virtual RepoItemInfo AIOStartDocument1Info
            {
                get
                {
                    return _aiostartdocument1Info;
                }
            }

            /// <summary>
            /// The OpenOtherWorkbooks item.
            /// </summary>
            [RepositoryItem("f6c50d54-2fee-4baf-a14d-0b70c7b59a62")]
            public virtual Ranorex.Link OpenOtherWorkbooks
            {
                get
                {
                    return _openotherworkbooksInfo.CreateAdapter<Ranorex.Link>(true);
                }
            }

            /// <summary>
            /// The OpenOtherWorkbooks item info.
            /// </summary>
            [RepositoryItemInfo("f6c50d54-2fee-4baf-a14d-0b70c7b59a62")]
            public virtual RepoItemInfo OpenOtherWorkbooksInfo
            {
                get
                {
                    return _openotherworkbooksInfo;
                }
            }

            /// <summary>
            /// The Browse item.
            /// </summary>
            [RepositoryItem("98273c1d-fb1b-439c-bca5-6876f6efecbf")]
            public virtual Ranorex.Button Browse
            {
                get
                {
                    return _browseInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Browse item info.
            /// </summary>
            [RepositoryItemInfo("98273c1d-fb1b-439c-bca5-6876f6efecbf")]
            public virtual RepoItemInfo BrowseInfo
            {
                get
                {
                    return _browseInfo;
                }
            }

            /// <summary>
            /// The LinkedCell item.
            /// </summary>
            [RepositoryItem("e0358cf4-0cee-47d2-a470-376cf6b01d48")]
            public virtual Ranorex.ListItem LinkedCell
            {
                get
                {
                    return _linkedcellInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The LinkedCell item info.
            /// </summary>
            [RepositoryItemInfo("e0358cf4-0cee-47d2-a470-376cf6b01d48")]
            public virtual RepoItemInfo LinkedCellInfo
            {
                get
                {
                    return _linkedcellInfo;
                }
            }

            /// <summary>
            /// The NetUIAnchor item.
            /// </summary>
            [RepositoryItem("99dc032c-1f22-45e4-8870-601a2655e78d")]
            public virtual Ranorex.MenuItem NetUIAnchor
            {
                get
                {
                    return _netuianchorInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The NetUIAnchor item info.
            /// </summary>
            [RepositoryItemInfo("99dc032c-1f22-45e4-8870-601a2655e78d")]
            public virtual RepoItemInfo NetUIAnchorInfo
            {
                get
                {
                    return _netuianchorInfo;
                }
            }

            /// <summary>
            /// The EXCEL item.
            /// </summary>
            [RepositoryItem("a1b9b200-7b49-404c-9721-971bd2370aee")]
            public virtual Ranorex.Unknown EXCEL
            {
                get
                {
                    return _excelInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The EXCEL item info.
            /// </summary>
            [RepositoryItemInfo("a1b9b200-7b49-404c-9721-971bd2370aee")]
            public virtual RepoItemInfo EXCELInfo
            {
                get
                {
                    return _excelInfo;
                }
            }

            /// <summary>
            /// The CellList item.
            /// </summary>
            [RepositoryItem("c117cf30-ff9d-4aa3-b5ea-765892a8eb44")]
            public virtual Ranorex.Table CellList
            {
                get
                {
                    return _celllistInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The CellList item info.
            /// </summary>
            [RepositoryItemInfo("c117cf30-ff9d-4aa3-b5ea-765892a8eb44")]
            public virtual RepoItemInfo CellListInfo
            {
                get
                {
                    return _celllistInfo;
                }
            }

            /// <summary>
            /// The CellC2 item.
            /// </summary>
            [RepositoryItem("809ce61c-1945-4726-acbf-9e0549170ebc")]
            public virtual Ranorex.Cell CellC2
            {
                get
                {
                    return _cellc2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellC2 item info.
            /// </summary>
            [RepositoryItemInfo("809ce61c-1945-4726-acbf-9e0549170ebc")]
            public virtual RepoItemInfo CellC2Info
            {
                get
                {
                    return _cellc2Info;
                }
            }

            /// <summary>
            /// The EXCEL6 item.
            /// </summary>
            [RepositoryItem("da2791ee-7538-4ac1-bec5-da9df4222972")]
            public virtual Ranorex.Unknown EXCEL6
            {
                get
                {
                    return _excel6Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The EXCEL6 item info.
            /// </summary>
            [RepositoryItemInfo("da2791ee-7538-4ac1-bec5-da9df4222972")]
            public virtual RepoItemInfo EXCEL6Info
            {
                get
                {
                    return _excel6Info;
                }
            }

            /// <summary>
            /// The SystemItemNameDisplay item.
            /// </summary>
            [RepositoryItem("3b0bb978-948a-43fa-a8e0-5d4bc1c9c08f")]
            public virtual Ranorex.Text SystemItemNameDisplay
            {
                get
                {
                    return _systemitemnamedisplayInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SystemItemNameDisplay item info.
            /// </summary>
            [RepositoryItemInfo("3b0bb978-948a-43fa-a8e0-5d4bc1c9c08f")]
            public virtual RepoItemInfo SystemItemNameDisplayInfo
            {
                get
                {
                    return _systemitemnamedisplayInfo;
                }
            }

            /// <summary>
            /// The ButtonOpen item.
            /// </summary>
            [RepositoryItem("0e9d5e19-2e2f-47ca-a7b3-af845087d698")]
            public virtual Ranorex.Button ButtonOpen
            {
                get
                {
                    return _buttonopenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOpen item info.
            /// </summary>
            [RepositoryItemInfo("0e9d5e19-2e2f-47ca-a7b3-af845087d698")]
            public virtual RepoItemInfo ButtonOpenInfo
            {
                get
                {
                    return _buttonopenInfo;
                }
            }

            /// <summary>
            /// The SaveAs item.
            /// </summary>
            [RepositoryItem("6623c739-41e7-46dd-9fd2-14df085b7456")]
            public virtual Ranorex.ListItem SaveAs
            {
                get
                {
                    return _saveasInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The SaveAs item info.
            /// </summary>
            [RepositoryItemInfo("6623c739-41e7-46dd-9fd2-14df085b7456")]
            public virtual RepoItemInfo SaveAsInfo
            {
                get
                {
                    return _saveasInfo;
                }
            }

            /// <summary>
            /// The Browse1 item.
            /// </summary>
            [RepositoryItem("a6124daf-552f-454b-8b07-e9cfe67463fc")]
            public virtual Ranorex.Button Browse1
            {
                get
                {
                    return _browse1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Browse1 item info.
            /// </summary>
            [RepositoryItemInfo("a6124daf-552f-454b-8b07-e9cfe67463fc")]
            public virtual RepoItemInfo Browse1Info
            {
                get
                {
                    return _browse1Info;
                }
            }

            /// <summary>
            /// The ButtonOpen1 item.
            /// </summary>
            [RepositoryItem("317630d3-e887-483d-ad5e-38314245e258")]
            public virtual Ranorex.Button ButtonOpen1
            {
                get
                {
                    return _buttonopen1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOpen1 item info.
            /// </summary>
            [RepositoryItemInfo("317630d3-e887-483d-ad5e-38314245e258")]
            public virtual RepoItemInfo ButtonOpen1Info
            {
                get
                {
                    return _buttonopen1Info;
                }
            }

            /// <summary>
            /// The EXCEL1 item.
            /// </summary>
            [RepositoryItem("40f4ba2f-ebae-4976-9dff-796dfa6af281")]
            public virtual Ranorex.Unknown EXCEL1
            {
                get
                {
                    return _excel1Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The EXCEL1 item info.
            /// </summary>
            [RepositoryItemInfo("40f4ba2f-ebae-4976-9dff-796dfa6af281")]
            public virtual RepoItemInfo EXCEL1Info
            {
                get
                {
                    return _excel1Info;
                }
            }

            /// <summary>
            /// The CellA1 item.
            /// </summary>
            [RepositoryItem("b5816f5a-a3fc-42f2-b832-3f339a6e211d")]
            public virtual Ranorex.Cell CellA1
            {
                get
                {
                    return _cella1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellA1 item info.
            /// </summary>
            [RepositoryItemInfo("b5816f5a-a3fc-42f2-b832-3f339a6e211d")]
            public virtual RepoItemInfo CellA1Info
            {
                get
                {
                    return _cella1Info;
                }
            }

            /// <summary>
            /// The CellA6 item.
            /// </summary>
            [RepositoryItem("b1b5ecb5-cdeb-4df8-b05e-9fa012ef3a26")]
            public virtual Ranorex.Cell CellA6
            {
                get
                {
                    return _cella6Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellA6 item info.
            /// </summary>
            [RepositoryItemInfo("b1b5ecb5-cdeb-4df8-b05e-9fa012ef3a26")]
            public virtual RepoItemInfo CellA6Info
            {
                get
                {
                    return _cella6Info;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("c2239afe-689c-4f1d-a8b9-32c1a74b7526")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("c2239afe-689c-4f1d-a8b9-32c1a74b7526")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }

            /// <summary>
            /// The Save item.
            /// </summary>
            [RepositoryItem("7dc0fe92-f0a2-4cee-8aa8-0e8d48a8961c")]
            public virtual Ranorex.Button Save
            {
                get
                {
                    return _saveInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Save item info.
            /// </summary>
            [RepositoryItemInfo("7dc0fe92-f0a2-4cee-8aa8-0e8d48a8961c")]
            public virtual RepoItemInfo SaveInfo
            {
                get
                {
                    return _saveInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
