using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerTime2.Model
{
    public class Date
    {
        public string readable { get; set; }
        public string timestamp { get; set; }
        public Gregorian gregorian { get; set; }
        public Hijri hijri { get; set; }
    }

    public class Datum
    {
        public Timings timings { get; set; }
        public Date date { get; set; }
        public Meta meta { get; set; }
    }

    public class Designation
    {
        public string abbreviated { get; set; }
        public string expanded { get; set; }
    }

    public class Gregorian
    {
        public string date { get; set; }
        public string format { get; set; }
        public string day { get; set; }
        public Weekday weekday { get; set; }
        public Month month { get; set; }
        public string year { get; set; }
        public Designation designation { get; set; }
    }

    public class Hijri
    {
        public string date { get; set; }
        public string format { get; set; }
        public string day { get; set; }
        public Weekday weekday { get; set; }
        public Month month { get; set; }
        public string year { get; set; }
        public Designation designation { get; set; }
        public List<object> holidays { get; set; }
    }

    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Meta
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set; }
        public Method method { get; set; }
        public string latitudeAdjustmentMethod { get; set; }
        public string midnightMode { get; set; }
        public string school { get; set; }
        public Offset offset { get; set; }
    }

    public class Method
    {
        public int id { get; set; }
        public string name { get; set; }
        public Params @params { get; set; }
        public Location location { get; set; }
    }

    public class Month
    {
        public int number { get; set; }
        public string en { get; set; }
        public string ar { get; set; }
    }

    public class Offset
    {
        public int Imsak { get; set; }
        public int Fajr { get; set; }
        public int Sunrise { get; set; }
        public int Dhuhr { get; set; }
        public int Asr { get; set; }
        public int Maghrib { get; set; }
        public int Sunset { get; set; }
        public int Isha { get; set; }
        public int Midnight { get; set; }
    }

    public class Params
    {
        public double Fajr { get; set; }
        public double Isha { get; set; }
    }

    public class Root
    {
        public int code { get; set; }
        public string status { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Timings
    {
        public string Fajr { get; set; }
        public string Sunrise { get; set; }
        public string Dhuhr { get; set; }
        public string Asr { get; set; }
        public string Sunset { get; set; }
        public string Maghrib { get; set; }
        public string Isha { get; set; }
        public string Imsak { get; set; }
        public string Midnight { get; set; }
    }

    public class Weekday
    {
        public string en { get; set; }
        public string ar { get; set; }
    }
    public class Data
    {
        public string name { get; set; }
        public string id { get; set; }
        public int available { get; set; }
        public int requested { get; set; }
        public List<Hadith> hadiths { get; set; }
    }

    public class Hadith
    {
        public int number { get; set; }
        public string arab { get; set; }
        public string id { get; set; }
    }

    public class Root2
    {
        public int code { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
        public bool error { get; set; }
    }
    public class Root3
    {
        [JsonProperty("أذكار الصباح")]
        public List<أذكارالصباح> أذكارالصباح { get; set; }

        [JsonProperty("أذكار المساء")]
        public List<أذكارالمساء> أذكارالمساء { get; set; }

        [JsonProperty("أذكار بعد السلام من الصلاة المفروضة")]
        public List<أذكاربعدالسلاممنالصلاةالمفروضة> أذكاربعدالسلاممنالصلاةالمفروضة { get; set; }
        public List<تسابيح> تسابيح { get; set; }

        [JsonProperty("أذكار النوم")]
        public List<أذكارالنوم> أذكارالنوم { get; set; }

        [JsonProperty("أذكار الاستيقاظ")]
        public List<أذكارالاستيقاظ> أذكارالاستيقاظ { get; set; }

        [JsonProperty("أدعية قرآنية")]
        public List<أدعيةقرآنية> أدعيةقرآنية { get; set; }

        [JsonProperty("أدعية الأنبياء")]
        public List<أدعيةالأنبياء> أدعيةالأنبياء { get; set; }
    }

    public class أدعيةالأنبياء
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }

    public class أدعيةقرآنية
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }

    public class أذكارالاستيقاظ
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }

    public class أذكارالصباح
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }

    public class أذكارالمساء
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }

    public class أذكارالنوم
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }

    public class أذكاربعدالسلاممنالصلاةالمفروضة
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }

    public class تسابيح
    {
        public string category { get; set; }
        public string count { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string content { get; set; }
    }










}
