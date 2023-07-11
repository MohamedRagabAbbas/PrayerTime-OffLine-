using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("ScheherazadeNew-Regular.ttf", Alias ="font1")]
[assembly: ExportFont("Changa-VariableFont_wght.ttf", Alias ="font2")]
[assembly: ExportFont("NotoNastaliqUrdu-Regular.ttf", Alias ="font3")]
namespace PrayerTime2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pages.MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
