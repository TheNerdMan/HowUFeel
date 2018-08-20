using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using WeatherApp;
using System.IO;
using SQLite;

namespace HowUFeel.android
{    
    [Activity(Label = "Sample Weather App",
                Theme = "@android:style/Theme.Material.Light",
                MainLauncher = true)]
    public class MainActivity : Activity
    {

        //Database path
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbHowUFeel.db3");

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.main);                       

            //setup db connection
            var db = new SQLiteConnection(dbPath);

            //Setup db
            db.CreateTable<DayMood>();

        }
    }    
}

