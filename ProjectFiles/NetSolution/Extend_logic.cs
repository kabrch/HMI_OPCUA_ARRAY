#region Using directives
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.Alarm;
using FTOptix.Recipe;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.DataLogger;
using FTOptix.EventLogger;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
using FTOptix.WebUI;
using FTOptix.CODESYS;
using FTOptix.OPCUAClient;
using FTOptix.OPCUAServer;
using FTOptix.AuditSigning;
using FTOptix.System;
#endregion

public class Extend_logic : BaseNetLogic
{
    private int PanelLeftWidth = 90;
    private int PanelLeftWidthExpanded = 640;
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void ExtendingPanel()
    {

        Project.Current.GetVariable("Model/UI/pnlExtend_stt").Value ^= true;
        
        if (Project.Current.GetVariable("Model/UI/pnlExtend_stt").Value)
        {
            Project.Current.GetVariable("Model/UI/btnExtend_img").Value = @"ns=9;%PROJECTDIR%/bootstrap-icons/chevron-double-left.svg";
        }
        else
        {
            Project.Current.GetVariable("Model/UI/btnExtend_img").Value = @"ns=9;%PROJECTDIR%/bootstrap-icons/chevron-double-right.svg";
        }
    }

}
