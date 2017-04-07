using Android.App;
using Android.Widget;
using Android.OS;
using System;
using QuizLibrary;
using System.IO;
using Java.IO;
using Android.Content;

namespace Acme_Quizzes_App
{
    [Activity(Label = "Acme Quizzes", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Spinner NumberOfQuestions = FindViewById<Spinner>(Resource.Id.NumberOfQuestions);
            Button StartButton = FindViewById<Button>(Resource.Id.StartButton);

            NumberOfQuestions.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(NumberOfQuestions_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.number_of_questions_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            NumberOfQuestions.Adapter = adapter;

            StartButton.Click += delegate
            {
                var activity2 = new Intent(this, typeof(QuizQuestions));
                QuizQuestions.
                StartActivity(typeof(QuizQuestions));
            };


            //copying asset to local db
            string sqliteFileName = "Quiz.sqlite";
            string libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(libraryPath, sqliteFileName);
            //if there isn't a db in the path... create one!
            if (!System.IO.File.Exists(path))
            {
                using (var f = this.Assets.Open("Quiz.sqlite"))
                {
                    using (var fileStream = System.IO.File.Create(path))
                    {
                        f.CopyTo(fileStream);
                    }
                }
            }
               
        }

        private void NumberOfQuestions_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner NumberOfQuestions = (Spinner)sender;

            string toast = string.Format("You have selected {0} questions", NumberOfQuestions.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }


    }
}

