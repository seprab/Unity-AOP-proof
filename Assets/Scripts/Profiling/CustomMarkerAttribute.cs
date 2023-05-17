using ITnnovative.AOP.Attributes.Method;
using ITnnovative.AOP.Processing.Execution.Arguments;
using System;
using UnityEngine;
using Unity.Profiling;

public class CustomMarkerAttribute : Attribute, IMethodBoundaryAspect
{
    static readonly ProfilerMarker CustomPerfMarker = new ProfilerMarker(ProfilerCategory.Scripts, "MySystem.Simulate");
    public void OnMethodEnter(MethodExecutionArguments args)
    {
        CustomPerfMarker.Begin();
    }

    public void OnMethodExit(MethodExecutionArguments args)
    {
        CustomPerfMarker.End();
    }
}
