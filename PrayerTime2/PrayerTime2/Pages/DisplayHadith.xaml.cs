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
    public partial class DisplayHadith : ContentPage
    {
        int selection = 0;
        Root2 root = new Root2();
        public DisplayHadith(int SectionNumber)
        {
            InitializeComponent();
            selection = SectionNumber;
            section();
            BindingContext = this;
            listview.ItemsSource = root.data.hadiths;
        }
        void section()
        {
            if (selection == 1)
                root = DB.AhadithFile1;
            if (selection == 2)
                root = DB.AhadithFile2;
            if (selection == 3)
                root = DB.AhadithFile3;
            if (selection == 4)
                root = DB.AhadithFile4;
            if (selection == 5)
                root = DB.AhadithFile5;
            if (selection == 6)
                root = DB.AhadithFile6;
            if (selection == 7)
                root = DB.AhadithFile7;
            if (selection == 8)
                root = DB.AhadithFile8;
            if (selection == 9)
                root = DB.AhadithFile9;
            if (selection == 10)
                root = DB.AhadithFile10;
            if (selection == 11)
                root = DB.AhadithFile11;
            if (selection == 12)
                root = DB.AhadithFile12;
            if (selection == 13)
                root = DB.AhadithFile13;
            if (selection == 14)
                root = DB.AhadithFile14;
            if (selection == 15)
                root = DB.AhadithFile15;
            if (selection == 16)
                root = DB.AhadithFile16;
            if (selection == 17)
                root = DB.AhadithFile17;
        }
        
    }
}