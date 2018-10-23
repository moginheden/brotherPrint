using System;
using ObjCRuntime;

[assembly: LinkWith ("BRPtouchPrinterKitW.a", 
                     LinkTarget = LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64 | LinkTarget.ArmV7,
                     SmartLink = true,
                     ForceLoad = true,
                     IsCxx = true,
                     LinkerFlags = "-lc++",
                     Frameworks = "CFNetwork CoreBluetooth ExternalAccessory")]
