#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using FTOptix.Alarm;
using FTOptix.EventLogger;
using FTOptix.WebUI;
using FTOptix.CODESYS;
using FTOptix.OPCUAClient;
using FTOptix.OPCUAServer;
using FTOptix.DataLogger;
using FTOptix.AuditSigning;
using FTOptix.System;
#endregion

public class rnlRecipeItem : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void PrepareEditPage()
    {

        var RecipeVariableIndex = Project.Current.GetVariable("Model/RecipeControl/RecipeVariableIndex");
        var RecipeVariableIndexDown = Project.Current.GetVariable("Model/RecipeControl/RecipeVariableIndexDown");
        var RecipeVariableMax = Project.Current.GetVariable("Model/RecipeControl/RecipeVariableMax");

        var RecipeVariableControl = Project.Current.GetVariable("Model/RecipeControl/RecipeVariableControl");
        var RecipeVariablePages = Project.Current.GetVariable("Model/RecipeControl/RecipeVariablePages");
        var RecipeVariableCurrentPage = Project.Current.GetVariable("Model/RecipeControl/RecipeVariableCurrentPage");
        

        var RecipeVariables = (Int32[])RecipeVariableControl.Value.Value;
        
        for (int i = 0; i < 20; i++)
        {
            RecipeVariables[i] = 1;
            
        }
        RecipeVariableControl.SetValue(RecipeVariables);

        RecipeVariableIndex.Value = 2;
        RecipeVariableIndexDown.Value = 0;
        RecipeVariableMax.Value = 0;
        RecipeVariablePages.Value = 0;
        RecipeVariableCurrentPage.Value = 0;

    }


}
