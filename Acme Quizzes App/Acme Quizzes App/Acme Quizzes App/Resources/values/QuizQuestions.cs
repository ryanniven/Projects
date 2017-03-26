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
using Acme_Quizzes_App.Resources.values;

namespace Acme_Quizzes_App
{
    [Activity(Label = "Quiz Questions")]
    public class QuizQuestions : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.QuizQuestions);

            Button NextButton = FindViewById<Button>(Resource.Id.NextButton);

            NextButton.Click += delegate
            {
                StartActivity(typeof(QuizResults));
            };
        }
    }
}