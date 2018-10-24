using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SkiaSharp;
using SkiaSharp.Views.iOS;
using BRPtouchPrintKitW;

[assembly: Xamarin.Forms.Dependency(typeof(PrintTest.iOS.BrotherPrint_iOS))]
namespace PrintTest.iOS
{
    class BrotherPrint_iOS : IBrotherPrinter
    {

        public void print(SKBitmap toPrint)
        {
            try
            {
                BRPtouchPrintInfo printInfo = new BRPtouchPrintInfo();

                printInfo.StrPaperName = @"36mm";

                BRPtouchPrinter printer = new BRPtouchPrinter("Brother PT-P950NW", ConnectionType.Wlan);

                printer.SetIPAddress("192.168.43.126"); //192.168.43.126
                printer.SetPrintInfo(printInfo);

                bool worked = printer.StartCommunication();

                CoreGraphics.CGImage cgImage2 = new CoreGraphics.CGImage(toPrint.Width, toPrint.Height, 8, toPrint.BytesPerPixel * 8, toPrint.BytesPerPixel * toPrint.Width, CoreGraphics.CGColorSpace.CreateGenericGray(), CoreGraphics.CGBitmapFlags.None, new CoreGraphics.CGDataProvider(toPrint.Bytes), null, false, CoreGraphics.CGColorRenderingIntent.Default);

                using (CoreGraphics.CGImage cgImage = toPrint.ToCGImage())
                {
                    printer.PrintImage(cgImage, 1);
                    printer.PrintImage(cgImage2, 1);
                }
                printer.EndCommunication();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("ERROR: " + ex.Message + "\r\n" + ex.StackTrace);
            }
        }
    }
}