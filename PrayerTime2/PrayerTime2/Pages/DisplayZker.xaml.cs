using PrayerTime2.Model;
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
    public partial class DisplayZker : ContentPage
    {
        int selection = 0;
        int localcounter = 0;
        object Sender;

        public DisplayZker(int SectionNumber)
        {
            InitializeComponent();
            selection = SectionNumber;
            Counter.Text = localcounter.ToString();
            BindingContext = this;
            section();
        }
        void section()
        {
            if (selection == 1)
                listview.ItemsSource = DB.AzkarFile1.أذكارالصباح;
            if (selection == 2)
                listview.ItemsSource = DB.AzkarFile1.أذكارالمساء;
            if (selection == 3)
                listview.ItemsSource = DB.AzkarFile1.أذكاربعدالسلاممنالصلاةالمفروضة;
            if (selection == 4)
                listview.ItemsSource = DB.AzkarFile1.تسابيح;
            if (selection == 5)
                listview.ItemsSource = DB.AzkarFile1.أذكارالنوم;
            if (selection == 6)
                listview.ItemsSource = DB.AzkarFile1.أذكارالاستيقاظ;
            if (selection == 7)
                listview.ItemsSource = DB.AzkarFile1.أدعيةقرآنية;
            if (selection == 8)
                listview.ItemsSource = DB.AzkarFile1.أدعيةالأنبياء;
        }

        private void Frame_Focused(object sender, FocusEventArgs e)
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Sender != sender)
                localcounter = 0;
            localcounter += 1;
            Counter.Text = localcounter.ToString();
            Sender = sender;
        }
    }
}