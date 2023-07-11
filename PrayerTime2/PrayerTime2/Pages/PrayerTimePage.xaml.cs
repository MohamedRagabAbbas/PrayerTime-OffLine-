using PrayerTime2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PrayerTime2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrayerTimePage : ContentPage
    {
        Root root = new Root();
        public PrayerTimePage()
        {
            InitializeComponent();
            DB.AlternativeConstructor();
            datepicker.Date = (DateTime.Today);
            section1();
            section2();
            //NextPrayer();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                NextPrayer();
                return true; 
            });
        }
        void month(int number)
        {
            if (number == 1)
                root = DB.Month1;
            else if (number == 2)
                root = DB.Month2;
            else if (number == 3)
                root = DB.Month3;
            else if (number == 4)
                root = DB.Month4;
            else if (number == 5)
                root = DB.Month5;
            else if (number == 6)
                root = DB.Month6;
            else if (number == 7)
                root = DB.Month7;
            else if (number == 8)
                root = DB.Month8;
            else if (number == 9)
                root = DB.Month9;
            else if (number == 10)
                root = DB.Month10;
            else if (number == 11)
                root = DB.Month11;
            else if (number == 12)
                root = DB.Month12;
        }
        public void section1()
        {
            month(Int32.Parse(((datepicker.Date).Month).ToString()));
            melady.Text = (datepicker.Date).ToString("dd:MM:yyyy");
            hegry.Text = (root.data[(datepicker.Date).Day - 1].date.hijri.date).ToString();
            yowm.Text = (root.data[(datepicker.Date).Day-1].date.hijri.weekday.ar);
        }

        public void section2()
        {
            fager.Text = Formate((root.data[(datepicker.Date).Day - 1].timings.Fajr).ToString());
            shorok.Text = Formate((root.data[(datepicker.Date).Day - 1].timings.Sunrise).ToString());
            Zohr.Text = Formate((root.data[(datepicker.Date).Day - 1].timings.Dhuhr).ToString());
            Aser.Text = Formate((root.data[(datepicker.Date).Day - 1].timings.Asr).ToString());
            Maghreb.Text = Formate((root.data[(datepicker.Date).Day - 1].timings.Maghrib).ToString());
            Ashea.Text = Formate((root.data[(datepicker.Date).Day - 1].timings.Isha).ToString());
        }
        private string Formate(string date)
        {
            string result = "";
            string FirstTowCharacters = date[0].ToString() + date[1].ToString();
            FirstTowCharacters = (int.Parse(FirstTowCharacters)).ToString();
            if (int.Parse(FirstTowCharacters) > 12)
            {
                FirstTowCharacters = (int.Parse(FirstTowCharacters) - 12).ToString();
                result = FirstTowCharacters + date.Substring(2);
                return result.Replace("(EEST)", "Pm");
            }
            result = FirstTowCharacters + date.Substring(2);
            return result.Replace("(EEST)", "AM");

        }

        private struct remainingTime
        {
            public int hour;
            public int minute;
        }
        private remainingTime returnFormatedHour(string sahah)
        {

            string Fager = root.data[(datepicker.Date).Day - 1].timings.Fajr;
            string Zohr = root.data[(datepicker.Date).Day - 1].timings.Dhuhr;
            string Aser = root.data[(datepicker.Date).Day - 1].timings.Asr;
            string Maghreb = root.data[(datepicker.Date).Day - 1].timings.Maghrib;
            string Ashea = root.data[(datepicker.Date).Day - 1].timings.Isha;

            List<string> list = new List<string>();
            list.Add(Fager);
            list.Add(Zohr);
            list.Add(Aser);
            list.Add(Maghreb);
            list.Add(Ashea);
            remainingTime remainingTime;
            string Hours;
            string Munites;
            List<remainingTime> remainingTimes = new List<remainingTime>();
            foreach (string s in list)
            {
                remainingTime = new remainingTime();
                Hours = s.Substring(0, 2);
                Munites = s.Substring(3, 2);
                remainingTime.hour = int.Parse(Hours) - DateTime.Now.Hour;
                remainingTime.minute = int.Parse(Munites) - DateTime.Now.Minute;
                if (remainingTime.minute < 0)
                {
                    remainingTime.hour--;
                    remainingTime.minute += 60;
                }
                remainingTimes.Add(remainingTime);
            }
            //sort List
            remainingTimes.Sort((x, y) => x.hour.CompareTo(y.hour));
            foreach (remainingTime r in remainingTimes)
            {
                if (r.hour >= 0)
                {
                    return r;
                }
            }
            return new remainingTime();
        }

        public void NextPrayer(object o=null)
        {
            string sahah = "";
            remainingTime remainingTime = returnFormatedHour(sahah);
            if (remainingTime.hour < 0)
            {
                remainingTime.hour += 24;
            }
            if (remainingTime.hour == 0 && remainingTime.minute == 0)
            {
                section2();
            }
            else
            {
                AfterTimeLable.Text = "الصلاة القادمة بعد " + remainingTime.hour + " ساعة و " + remainingTime.minute + " دقيقة";
            }
            //int now = (DateTime.Now).Hour;
            //if (now < int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Fajr).ToString()).Substring(0, 2)))
            //{
            //    int x = 0;
            //    int y = 0;
            //    if ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Fajr).ToString()).Substring(3, 2)) - (DateTime.Now).Minute) < 0)
            //        { x = 2; y = 60; }
            //    AfterTimeLable.Text = ("صلاة الفجر بعد  ")+ (int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Fajr).ToString()).Substring(0, 2)) - now - x+ "  ساعة  " + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Fajr).ToString()).Substring(3, 2))- (DateTime.Now).Minute)+y)+ "  دقيقة  ").ToString();
            //}
            //else if (now < int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Dhuhr).ToString()).Substring(0, 2)))
            //{
            //    int x = 0;
            //    int y = 0;
            //    if ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Dhuhr).ToString()).Substring(3, 2)) - (DateTime.Now).Minute) < 0)
            //    { x = 1; y = 60; }
            //    AfterTimeLable.Text = ("صلاة الظهر بعد  ") + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Dhuhr).ToString()).Substring(0, 2)) - now - x) + "  ساعة  " + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Dhuhr).ToString()).Substring(3, 2)))- (DateTime.Now).Minute + y) + "  دقيقة  ").ToString();
            //}
            //else if(now < int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Asr).ToString()).Substring(0, 2)))
            //{
            //    int x = 0;
            //    int y = 0;
            //    if ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Asr).ToString()).Substring(3, 2)) - (DateTime.Now).Minute) < 0)
            //    { x = 1; y = 60; }
            //    AfterTimeLable.Text = ("صلاة العصر بعد  ") + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Asr).ToString()).Substring(0, 2)) - now - x) + "  ساعة  " + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Asr).ToString()).Substring(3, 2)))- (DateTime.Now).Minute+ y) + "  دقيقة  ").ToString();
            //}
            //else if(now < int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Maghrib).ToString()).Substring(0, 2)))
            //{
            //    int x = 0;
            //    int y = 0;
            //    if ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Maghrib).ToString()).Substring(3, 2)) - (DateTime.Now).Minute) < 0)
            //    { x = 1; y = 60; }
            //    AfterTimeLable.Text = ("صلاة المغرب بعد  ") + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Maghrib).ToString()).Substring(0, 2)) - now - x) + "  ساعة  " + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Maghrib).ToString()).Substring(3, 2)))- (DateTime.Now).Minute+ y) + "  دقيقة  ").ToString();
            //}
            //else if(now < int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Isha).ToString()).Substring(0, 2)))
            //{
            //    int x = 0;
            //    int y = 0;
            //    if ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Isha).ToString()).Substring(3, 2)) - (DateTime.Now).Minute) < 0)
            //    { x = 1; y = 60; }
            //    AfterTimeLable.Text = ("صلاة العشاء بعد  ") + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Isha).ToString()).Substring(0, 2)) - now - x) + "  ساعة  " + ((int.Parse(((root.data[(datepicker.Date).Day - 1].timings.Isha).ToString()).Substring(3, 2)))- (DateTime.Now).Minute + y) + "  دقيقة  ").ToString();
            //}
        }

        private void datepicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            section1();
            section2();
        }
    }
}