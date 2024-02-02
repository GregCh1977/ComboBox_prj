#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
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
    public void ExecuteMethods()
    {
        MethodInvocation methodInvocation1 = (MethodInvocation)Owner.Get("SetVariable1");
        MethodInvocation methodInvocation2 = (MethodInvocation)Owner.Get("SetVariable2");
        var selectedValueCombo = Project.Current.GetVariable("Model/SelectedValueVar").Value.Value;
        if(selectedValueCombo.Equals("Variable1"))
        {
            methodInvocation1.Invoke();
        }
        else
            methodInvocation2.Invoke();
    }
}
