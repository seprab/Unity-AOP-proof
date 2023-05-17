
using ITnnovative.AOP.Attributes.Method;
using ITnnovative.AOP.Processing.Execution.Arguments;
using System;
using UnityEngine;

public class ParticleCounterAttribute : Attribute, IMethodExitAspect
{
    public void OnMethodExit(MethodExecutionArguments args)
    {
        int bullets = (int)args.returnValue;
        //Debug.Log($"{args.method.Name}[OnMethodExit] = {bullets}");
        GameStats.BulletCount.Sample(bullets);
    }
}
