
using ITnnovative.AOP.Attributes.Method;
using ITnnovative.AOP.Processing.Execution.Arguments;
using System;
using UnityEngine;

public class ExplosionsCounterAttribute : Attribute, IMethodExitAspect
{
    public void OnMethodExit(MethodExecutionArguments args)
    { 
        GameStats.ExplosionCount.Value += (int)args.returnValue;
    }
}
