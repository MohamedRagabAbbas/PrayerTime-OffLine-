using PrayerTime2.Model;
using PrayerTime2.Sound;
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
    public partial class SephaPage : ContentPage
    {
        int index=0;
        int localcounter = 0;
        int localhasan = 0;
        public SephaPage()
        {
            InitializeComponent();
            lable.Text = DB.AzkarFile1.تسابيح[index].content;
            Count.Text =  DB.AzkarFile1.تسابيح[index].count;
            ager.Text = DB.AzkarFile1.تسابيح[index].description;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            localcounter = 0;
            localhasan = 0;
            counter.Text = " عدد مرات التسبيح هي " + localcounter;
            hasana.Text = " عدد الحسنات قد تكون " + localhasan;
            if (index - 1 < 0)
            {
                index = 15;
                lable.Text = DB.AzkarFile1.تسابيح[index].content;
                Count.Text = DB.AzkarFile1.تسابيح[index].count;
                ager.Text = DB.AzkarFile1.تسابيح[index].description;
                return;
            }
            index = (index - 1) % 16;
            lable.Text = DB.AzkarFile1.تسابيح[index].content;
            Count.Text = DB.AzkarFile1.تسابيح[index].count;
            ager.Text = DB.AzkarFile1.تسابيح[index].description;
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            localcounter = 0;
            localhasan = 0;
            counter.Text = " عدد مرات التسبيح هي " + localcounter;
            hasana.Text = " عدد الحسنات قد تكون " + localhasan;
            index = (index + 1) % 16;
            lable.Text = DB.AzkarFile1.تسابيح[index].content;
            Count.Text = DB.AzkarFile1.تسابيح[index].count;
            ager.Text = DB.AzkarFile1.تسابيح[index].description;
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("sound.wav");
            localcounter += 1;
            localhasan += 10;
            counter.Text = " عدد مرات التسبيح هي " + localcounter;
            hasana.Text = " عدد الحسنات قد تكون " + localhasan;
        }
    }
}