using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Exercises
{
    [Activity(Label = "ListOfThingsActivity")]
    public class ListOfThingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListOfThingsLayout);
            var ourList = FindViewById<ListView>(Resource.Id.listView1);

            var car1 = new Car();
            car1.Name = "Ferrari";
            car1.Kw = 325;
            car1.Year = 2013;

            var car2 = new Car();
            car2.Name = "Bmw i8";
            car2.Kw = 210;
            car2.Year = 2017;

            var car3 = new Car();
            car3.Name = "Audi R8";
            car3.Kw = 280;
            car3.Year = 2017;

            var car4 = new Car();
            car4.Name = "Aston Martin";
            car4.Kw = 178;
            car4.Year = 2014;

            var car5 = new Car();
            car5.Name = "Porche";
            car5.Kw = 145;
            car5.Year = 2010;

            var car6 = new Car();
            car6.Name = "Opel";
            car6.Kw = 99;
            car6.Year = 2011;

            var car7 = new Car();
            car7.Name = "Wolksvagen Mk2 Gti 16v";
            car7.Kw = 110;
            car7.Year = 1989;


            var items = new string[] {"Bmw", "Audi", "Ferrari", "Mercedes", "Lada"};
            ourList.Adapter = new CustomAdapter(this,items);
            ourList.ItemClick += OurList_ItemClick;

        }

        private void OurList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Android.Widget.Toast.MakeText(this, "Vajutasid", Android.Widget.ToastLength.Short).Show();
        }
    }
}