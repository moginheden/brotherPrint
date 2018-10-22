using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrintTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPrint_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IBrotherPrinter>().print(generateLabelBitmap("John", "Doe", "Jack of all trades, master of none"));
        }

        private SKBitmap generateLabelBitmap(string fName, string lName, string title)
        {
            const int width = 596;
            const int margin = 4;
            const int height = 241;
            const float maxFontSizeName = 65;
            const float maxFontSizeBrokerage = 30;

            SKBitmap bitmap = new SKBitmap(width + margin, height, SKColorType.Gray8, SKAlphaType.Opaque);
            bitmap.Erase(new SKColor(255, 255, 255));
            SKCanvas canvas = new SKCanvas(bitmap);

            //setup default paint style
            SKPaint paint = new SKPaint();
            paint.TextAlign = SKTextAlign.Center;
            paint.TextSize = maxFontSizeName;
            paint.Color = new SKColor(0,0,0);
            paint.Typeface = SKTypeface.FromFamilyName("Arial");
            paint.TextScaleX = 1;

            int textWidth = (int)(paint.MeasureText(fName + ' ' + lName) + 0.5f);
            if (textWidth > width)
            {
                paint.TextSize = ((float)width) / textWidth * maxFontSizeName;
                paint.TextSize = (int)paint.TextSize; //round down
            }
            float baseline = -paint.FontMetrics.Ascent;
            float verticalOffset = (baseline / 2) + (height / 4);
            canvas.DrawText(fName + ' ' + lName, width/2, verticalOffset, paint);

            //2nd line brokerage
            paint.TextSize = maxFontSizeBrokerage;
            textWidth = (int)(paint.MeasureText(title) + 0.5f);
            if (textWidth > width)
            {
                paint.TextSize = ((float)width) / textWidth * maxFontSizeBrokerage;
                paint.TextSize = (int)paint.TextSize; //round down
            }
            baseline = -paint.FontMetrics.Ascent;
            verticalOffset = (baseline / 2) + (height / 4) + (height / 2);
            canvas.DrawText(title, width/2, verticalOffset, paint);

            return bitmap;
        }
    }
}
