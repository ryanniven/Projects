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
        //assigning variables to objects on the page, only accessible to this class
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
            //accessing the database method set up to get all questions and store them in the variable questions
            var questions = new SQLiteRepository().GetAllQuestions();
            //assinging intents to pass to next acitivity/screen to variables 
            int maxNumberOfQuestions = Intent.GetIntExtra("MaxNumberOfQuestions", 1);
            int currentQuestion = Intent.GetIntExtra("CurrentQuestion", 1);
            //this line tells the list of questions to start the current question to start from 0 as arrays/lists are zero based so a list of 10 items would be stored 0-9
            Question question = questions[currentQuestion - 1];
            //assinging intents passed from previous acitivity/screen to variables accessible on this activity
            int correctAnswers = Intent.GetIntExtra("CorrectAnswers",0);
            correctAnswer = question.CorrectAnswer;
            int questionsAnswered = maxNumberOfQuestions;

            //replacing the text in the page item QuestionText with the question text from the field in our question table
            QuestionText = FindViewById<TextView>(Resource.Id.Question);
            QuestionText.SetText(question.QuestionText, TextView.BufferType.Normal);
            //replacing the text in the page item radio button text with the answer text from the fields in our question table

            Option1 = FindViewById<RadioButton>(Resource.Id.AnswerA);
            Option1.SetText(question.Option1, RadioButton.BufferType.Normal);

            Option2 = FindViewById<RadioButton>(Resource.Id.AnswerB);
            Option2.SetText(question.Option2, RadioButton.BufferType.Normal);

            Option3 = FindViewById<RadioButton>(Resource.Id.AnswerC);
            Option3.SetText(question.Option3, RadioButton.BufferType.Normal);

            Option4 = FindViewById<RadioButton>(Resource.Id.AnswerD);
            Option4.SetText(question.Option4, RadioButton.BufferType.Normal);
            
            Option5 = FindViewById<RadioButton>(Resource.Id.AnswerE);
            Option5.SetText(question.Option5, RadioButton.BufferType.Normal);
            //not all questions have 5 answers, if they dont make the fifth radio button invisible                                                                                 
            if (Option5.Text == "")
            {

                Option5.Visibility = ViewStates.Invisible;       
            }

            //logic behind clicking the next button, if the answer clicked is equal to the correctAnswer field value in database, increment by 1
            Button NextButton = FindViewById<Button>(Resource.Id.NextButton);
            NextButton.Click += delegate
            {
                switch (correctAnswer)
                {
                    case "1":
                        if (Option1.Checked) correctAnswers++;
                        break;
                    case "2":
                        if (Option2.Checked) correctAnswers++;
                        break;
                    case "3":
                        if (Option3.Checked) correctAnswers++;
                        break;
                    case "4":
                        if (Option4.Checked) correctAnswers++;
                        break;
                    case "5":
                        if (Option5.Checked) correctAnswers++;
                        break;
                }
                //continue to display the same page with the next question in our questions table until user is on the last question when next button is clicked
                if (currentQuestion < maxNumberOfQuestions)
                {
                    var numberOfQuesitons = new Intent(this, typeof(QuizQuestions));
                    numberOfQuesitons.PutExtra("MaxNumberOfQuestions", (int)maxNumberOfQuestions);
                    numberOfQuesitons.PutExtra("CorrectAnswers", (int)correctAnswers);
                    numberOfQuesitons.PutExtra("CurrentQuestion", (int)(currentQuestion + 1));
                    StartActivity(numberOfQuesitons);
                }
                else
                {
                    //when on the last question carry the data for the amount of questions answered and the amount of quesitons answered correctly to results activity/page
                    var totalCorrect = new Intent(this, typeof(QuizResults));
                    totalCorrect.PutExtra("QuizScore", (int)correctAnswers);
                    totalCorrect.PutExtra("QuestionsAttempted", (int)questionsAnswered);
                    StartActivity(totalCorrect);
                }
            };

        }
    }
}