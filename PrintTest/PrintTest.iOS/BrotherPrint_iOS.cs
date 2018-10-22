using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SkiaSharp;
using BRPtouchPrintKitW;

[assembly: Xamarin.Forms.Dependency(typeof(PrintTest.iOS.BrotherPrint_iOS))]
namespace PrintTest.iOS
{
    class BrotherPrint_iOS : IBrotherPrinter
    {

        public void print(SKBitmap toPrint)
        {
            BRPtouchPrinter printer = null;

        }
    }
}