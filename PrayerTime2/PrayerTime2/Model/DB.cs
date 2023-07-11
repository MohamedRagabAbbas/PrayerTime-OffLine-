using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;
using PrayerTime2.Model;
using System.Net.Http;

namespace PrayerTime2.Model
{
    class DB
    {
        public static Root Month1 = new Root();
        public static Root Month2 = new Root();
        public static Root Month3 = new Root();
        public static Root Month4 = new Root();
        public static Root Month5 = new Root();
        public static Root Month6 = new Root();
        public static Root Month7 = new Root();
        public static Root Month8 = new Root();
        public static Root Month9 = new Root();
        public static Root Month10 = new Root();
        public static Root Month11 = new Root();
        public static Root Month12 = new Root();
        public static Root2 AhadithFile1 = new Root2();
        public static Root2 AhadithFile2 = new Root2();
        public static Root2 AhadithFile3 = new Root2();
        public static Root2 AhadithFile4 = new Root2();
        public static Root2 AhadithFile5 = new Root2();
        public static Root2 AhadithFile6 = new Root2();
        public static Root2 AhadithFile7 = new Root2();
        public static Root2 AhadithFile8 = new Root2();
        public static Root2 AhadithFile9 = new Root2();
        public static Root2 AhadithFile10 = new Root2();
        public static Root2 AhadithFile11 = new Root2();
        public static Root2 AhadithFile12 = new Root2();
        public static Root2 AhadithFile13 = new Root2();
        public static Root2 AhadithFile14 = new Root2();
        public static Root2 AhadithFile15 = new Root2();
        public static Root2 AhadithFile16 = new Root2();
        public static Root2 AhadithFile17 = new Root2();
        public static Root3 AzkarFile1 = new Root3();
        public DB()
        {

        }
        public static void AlternativeConstructor()
        {
            get_json1();
            get_json2();
            get_json3();
            get_json4();
            get_json5();
            get_json6();
            get_json7();
            get_json8();
            get_json9();
            get_json10();
            get_json11();
            get_json12();
            get_json_ahadith1();
            get_json_ahadith2();
            get_json_ahadith3();
            get_json_ahadith4();
            get_json_ahadith5();
            get_json_ahadith6();
            get_json_ahadith7();
            get_json_ahadith8();
            get_json_ahadith9();
            get_json_ahadith10();
            get_json_ahadith11();
            get_json_ahadith12();
            get_json_ahadith13();
            get_json_ahadith14();
            get_json_ahadith15();
            get_json_ahadith16();
            get_json_ahadith17();
            get_json_azkar1();
        }













        private static void get_json1()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month1.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month1 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json2()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month2.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month2 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json3()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month3.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month3 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json4()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month4.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month4 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json5()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month5.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month5 = JsonConvert.DeserializeObject<Root>(json);

            }
        }
        private static void get_json6()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month6.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month6 = JsonConvert.DeserializeObject<Root>(json);

            }
        }
        private static void get_json7()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month7.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month7 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json8()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month8.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month8 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json9()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month9.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month9 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json10()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month10.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month10 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json11()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month11.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month11 = JsonConvert.DeserializeObject<Root>(json);
            }
        }
        private static void get_json12()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.month12.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                Month12 = JsonConvert.DeserializeObject<Root>(json);
            }
        }

        private static void get_json_ahadith1()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith1.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile1 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith2()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith2.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile2 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith3()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith3.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile3 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith4()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith4.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile4 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith5()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith5.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile5 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith6()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith6.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile6 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith7()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith7.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile7 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith8()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith8.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile8 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith9()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith9.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile9 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith10()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith10.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile10 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith11()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith11.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile11 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith12()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith12.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile12 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith13()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith13.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile13 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith14()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith14.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile14 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith15()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith15.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile15 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith16()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith16.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile16 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }
        private static void get_json_ahadith17()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Ahadith17.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AhadithFile17 = JsonConvert.DeserializeObject<Root2>(json);
            }
        }


        private static void get_json_azkar1()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrayerTime2.Model.Azkar.json");
            using (StreamReader reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                AzkarFile1 = JsonConvert.DeserializeObject<Root3>(json);
            }
        }
    }
}

