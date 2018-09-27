using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(PrintTest.iOS.BrotherPrint_iOS))]
namespace PrintTest.iOS
{
    class BrotherPrint_iOS : IBrotherPrinter
    {
        public void print(string toPrint)
        {
            throw new NotImplementedException();
        }
    }
}