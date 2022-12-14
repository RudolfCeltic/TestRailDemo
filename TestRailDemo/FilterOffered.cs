///////////////////////////////////////////////////////////////////////////////
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

namespace TestRailDemo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FilterOffered recording.
    /// </summary>
    [TestModule("d7df3803-948d-4d91-9df8-78f435a2327d", ModuleType.Recording, 1)]
    public partial class FilterOffered : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRailDemoRepository repository.
        /// </summary>
        public static TestRailDemoRepository repo = TestRailDemoRepository.Instance;

        static FilterOffered instance = new FilterOffered();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FilterOffered()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FilterOffered Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShawQA.EbxLegacyComponent.EbxIcon' at 5;6.", repo.ShawQA.EbxLegacyComponent.EbxIconInfo, new RecordItemIndex(0));
            repo.ShawQA.EbxLegacyComponent.EbxIcon.Click("5;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShawQA.EbxLegacyComponent.EbxSimpleSearchFilterNodeSelectorListF' at 296;15.", repo.ShawQA.EbxLegacyComponent.EbxSimpleSearchFilterNodeSelectorListFInfo, new RecordItemIndex(1));
            repo.ShawQA.EbxLegacyComponent.EbxSimpleSearchFilterNodeSelectorListF.Click("296;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShawQAGoogleChrome' at 1469;487.", repo.ShawQAGoogleChrome.SelfInfo, new RecordItemIndex(2));
            repo.ShawQAGoogleChrome.Self.Click("1469;487");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShawQA.EbxLegacyComponent.EbxIcon1' at 7;8.", repo.ShawQA.EbxLegacyComponent.EbxIcon1Info, new RecordItemIndex(3));
            repo.ShawQA.EbxLegacyComponent.EbxIcon1.Click("7;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShawQA.EbxLegacyComponent.Offered' at 51;14.", repo.ShawQA.EbxLegacyComponent.OfferedInfo, new RecordItemIndex(4));
            repo.ShawQA.EbxLegacyComponent.Offered.Click("51;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShawQA.EbxLegacyComponent.Apply' at 27;12.", repo.ShawQA.EbxLegacyComponent.ApplyInfo, new RecordItemIndex(5));
            repo.ShawQA.EbxLegacyComponent.Apply.Click("27;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
