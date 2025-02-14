#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.EventLogger;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.Alarm;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using FTOptix.WebUI;
using FTOptix.CODESYS;
using FTOptix.OPCUAClient;
using FTOptix.OPCUAServer;
using FTOptix.DataLogger;
using FTOptix.AuditSigning;
using FTOptix.System;
#endregion

public class rnlCustomAlarm : BaseNetLogic
{
    private IUAVariable errorId;
    private IUAVariable trigger;
    private IUAVariable changed;
    //private IVariable errorIDVariable;
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        errorId = Owner.GetVariable("ErrorID");
        trigger = Owner.GetVariable("Trigger");
        changed = Owner.GetVariable("Changed");

        errorId.VariableChange += OnErrorIDChanged;
        trigger.VariableChange += OnTriggerChanged;
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        errorId.VariableChange -= OnErrorIDChanged;
    }

    private void OnErrorIDChanged(object sender, VariableChangeEventArgs e)
    {
        // Обработка изменения переменной ErrorID
        //Log.Info("ErrorID изменился: " + e.NewValue);
        if (trigger.Value==true)
        {
            changed.Value = true;
        }
    }

    private void OnTriggerChanged(object sender, VariableChangeEventArgs e)
    {
        // Обработка изменения переменной ErrorID
        //Log.Info("ErrorID изменился: " + e.NewValue);
        if (trigger.Value==false)
        {
            changed.Value = false;
        }
        
    }
}
