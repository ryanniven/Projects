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
            TextView Result = FindViewById<TextView>(Resource.Id.ResultValue);
            TextView Result1 = FindViewById<TextView>(Resource.Id.QuestionsAnswered);

            int quizScore = Intent.GetIntExtra("QuizScore", 0);
            int questionsAttemped = Intent.GetIntExtra("QuestionsAttempted", 0);
            
            Result.SetText(quizScore.ToString(), TextView.BufferType.Normal);

            Result1.SetText(questionsAttemped.ToString(), TextView.BufferType.Normal);

            Restart.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}