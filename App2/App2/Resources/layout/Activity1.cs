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

namespace MyFirstAndroidApp.Resources.layout
{
    [Activity(Label = "Activity1", MainLauncher =true, Icon ="@drawable/icon")]
    public class Activity1 : Activity
    {
        Fragment[] _fragments;
        protected override void OnCreate(Bundle bundle)
        {
            //1. Set ActionBar mode
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            TextView message = FindViewById<TextView>(Resource.Id.textViewMessage);
            message.Text = "Hello World!";
            Button button1 = FindViewById<Button>(Resource.Id.button);
        }

    }
}