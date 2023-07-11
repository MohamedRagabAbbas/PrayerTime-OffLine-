using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrayerTime2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AhadithPage : ContentPage
    {
        public AhadithPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(1));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(2));
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(3));
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(4));
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(5));
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(6));
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(7));
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(8));
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(9));
        }

        private async void Button_Clicked_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(10));
        }

        private async void Button_Clicked_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(11));
        }

        private async void Button_Clicked_12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(12));
        }

        private async void Button_Clicked_13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(13));
        }

        private async void Button_Clicked_14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(14));
        }

        private async void Button_Clicked_15(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(15));
        }

        private async void Button_Clicked_16(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(16));
        }

        private async void Button_Clicked_17(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayHadith(17));
        }
    }
}