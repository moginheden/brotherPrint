using System;
using ObjCRuntime;

[assembly: LinkWith ("BRPtouchPrinterKitW", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]
