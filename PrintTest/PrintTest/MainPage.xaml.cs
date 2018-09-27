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
            DependencyService.Get<IBrotherPrinter>().print("Hello");
        }
    }
}
