using System.Reflection;
#if __UNIFIED__
using ObjCRuntime;
#else
using MonoTouch.ObjCRuntime;
#endif

[assembly: AssemblyVersion("1.8.1")]
[assembly: AssemblyFileVersion("1.8.1")]

[assembly: LinkWith(
    "libDZNEmptyDataSet.a",
    LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64,
    ForceLoad = true)]

