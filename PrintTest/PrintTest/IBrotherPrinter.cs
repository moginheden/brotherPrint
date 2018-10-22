using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintTest
{
    public interface IBrotherPrinter
    {
        void print(SKBitmap toPrint);
    }
}
