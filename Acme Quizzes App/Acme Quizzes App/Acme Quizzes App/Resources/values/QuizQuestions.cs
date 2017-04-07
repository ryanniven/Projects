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
using System.Collections;
using SQLite.Net;
using System.IO;
using QuizLibrary;

namespace Acme_Quizzes_App
{
    [Activity(Label = "Quiz Questions")]
    public class QuizQuestions : Activity
    {

        private TextView QuestionText;
        private RadioButton Option1;
        private RadioButton Option2;
        private RadioButton Option3;
        private RadioButton Option4;
        private RadioButton Option5;
        private string correctAnswer;
        






        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.QuizQuestions);


            var questions = new SQLiteRepository().GetAllQuestions();
 
            QuestionText = FindViewById<TextView>(Resource.Id.Question);
            QuestionText.SetText(questions[0].QuestionText, TextView.BufferType.Normal);

            Option1 = FindViewById<RadioButton>(Resource.Id.AnswerA);
            Option1.SetText(questions[0].Option1, RadioButton.BufferType.Normal);

            Option2 = FindViewById<RadioButton>(Resource.Id.AnswerB);
            Option2.SetText(questions[0].Option2, RadioButton.BufferType.Normal);

            Option3 = FindViewById<RadioButton>(Resource.Id.AnswerC);
            Option3.SetText(questions[0].Option3, RadioButton.BufferType.Normal);

            Option4 = FindViewById<RadioButton>(Resource.Id.AnswerD);
            Option4.SetText(questions[0].Option4, RadioButton.BufferType.Normal);

            //if (!questions[].Option5 == null )
            Option5 = FindViewById<RadioButton>(Resource.Id.AnswerE);
            Option5.SetText(questions[0].Option5, RadioButton.BufferType.Normal);

            Button NextButton = FindViewById<Button>(Resource.Id.NextButton);

            NextButton.Click += delegate
            {
                Intent intent = getIntent();
                
                for (int i = 0; i < )

                StartActivity(typeof(QuizResults));
            };


        }
    }
}