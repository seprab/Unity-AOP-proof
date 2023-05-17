using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ITnnovative.AOP.Attributes.Method;
using ITnnovative.AOP.Processing.Execution.Arguments;
using System;

public class PlayerCounter : Attribute, IMethodExitAspect
{
    public void OnMethodExit(MethodExecutionArguments args)
    {
        float vel = (float)args.returnValue;
        //Debug.Log($"{args.method.Name}[OnMethodExit] = {vel}");
        GameStats.PlayerSpeed.Sample(vel);
    }
}
