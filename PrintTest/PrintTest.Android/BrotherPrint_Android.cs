using System;
using System.IO;
using System.Threading;
using Android.Graphics;

using Com.Brother.Ptouch.Sdk;

[assembly: Xamarin.Forms.Dependency(typeof(PrintTest.Droid.BrotherPrint_Android))]
namespace PrintTest.Droid
{
    class BrotherPrint_Android : IBrotherPrinter
    {
        public void print(string toPrint)
        {
            ThreadPool.QueueUserWorkItem(o => printThread(toPrint));
        }

        public void printThread(string toPrint)
        {
            try
            {
                var context = global::Android.App.Application.Context;

                Printer printer = new Printer();

                string[] models = new string[6];
                models[0] = PrinterInfo.Model.PtP950nw.ToString();
                models[1] = PrinterInfo.Model.PtP950nw.ToString().Replace("_", "-");
                models[2] = "PtP950nw";
                models[3] = "PTP950NW";
                models[4] = "PT-P950NW";
                models[5] = "Pt-P950nw";

                NetPrinter[] printers = new NetPrinter[0];// printer.GetNetPrinters(models);

                PrinterInfo printInfo = new PrinterInfo();
                printInfo.PrinterModel = PrinterInfo.Model.PtP950nw;
                printInfo.Port = PrinterInfo.PortEnum.Net;

                if (printers.Length == 0)
                {
                    printInfo.IpAddress = "192.168.43.126";
                }
                else
                {
                    printInfo.IpAddress = printers[0].IpAddress;
                }

                printInfo.PaperSize = PrinterInfo.PaperSizeEnum.Custom;
                printInfo.PaperPosition = PrinterInfo.AlignEnum.Center;
                printInfo.Orientation = PrinterInfo.OrientationEnum.Landscape;

                printInfo.LabelNameIndex = LabelInfo.PT.W36.Ordinal();
                printInfo.IsAutoCut = true;
                printInfo.IsCutAtEnd = true;

                printer.SetPrinterInfo(printInfo);

                printer.StartCommunication();

                Bitmap bmp = stringToBitmap(toPrint);

                PrinterStatus status = printer.PrintImage(bmp);

                System.Diagnostics.Debug.WriteLine(status.ErrorCode.ToString());

                printer.EndCommunication();
            }
            catch (Exception ex)
            {

            }
        }

        public Bitmap stringToBitmap(string input)
        {
            Paint paint = new Paint(PaintFlags.AntiAlias);
            paint.TextSize = 200;
            paint.Color = Color.Black;
            paint.TextAlign = Paint.Align.Left;
            float baseline = -paint.Ascent(); // ascent() is negative
            int width = (int)(paint.MeasureText(input) + 0.5f); // round
            int height = (int)(baseline + paint.Descent() + 0.5f);
            Bitmap image = Bitmap.CreateBitmap(width, height, Bitmap.Config.Argb8888);
            image.EraseColor(Color.White);
            Canvas canvas = new Canvas(image);
            canvas.DrawText(input, 0, baseline, paint);
            return image;
        }
    }
}