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
            //assigning items on page to variables
            Button Restart = FindViewById<Button>(Resource.Id.Restart);
            TextView Result = FindViewById<TextView>(Resource.Id.ResultValue);
            TextView Result1 = FindViewById<TextView>(Resource.Id.QuestionsAnswered);
            //creating a variable to store the quiz score which is being passed as an intent from previous acitivity
            int quizScore = Intent.GetIntExtra("QuizScore", 0);
            //creating a variable to store the questions attempted which is being passed as an intent from previous acitivity
            int questionsAttemped = Intent.GetIntExtra("QuestionsAttempted", 0);
            
            //setting text to give the variable quizScore, this is to make it dynamic 
            Result.SetText(quizScore.ToString(), TextView.BufferType.Normal);
            //setting text to give the variable questionattemped, this is to make it dynamic 
            Result1.SetText(questionsAttemped.ToString(), TextView.BufferType.Normal);

            //intended to do the above functionality in one line using string interpolation, code compliles but application was crashing so resorted to this (attemped code below)    
            //Result.Text = string.Format("You have scored {0} out of {1}", quizScore, questionsAttemped);

            //activity to take back to start of quiz
            Restart.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}