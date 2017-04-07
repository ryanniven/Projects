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

namespace Acme_Quizzes_App.Resources.values
{
    [Activity(Label = "QuizResults")]
    public class QuizResults : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.QuizResults);

            Button Restart = FindViewById<Button>(Resource.Id.Restart);

            Restart.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}