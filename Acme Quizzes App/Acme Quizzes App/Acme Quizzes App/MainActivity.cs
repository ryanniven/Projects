using Android.App;
using Android.Widget;
using Android.OS;
using System;
using QuizLibrary;
using System.IO;
using Java.IO;
using Android.Content;
using System.Linq;

namespace Acme_Quizzes_App
{
    [Activity(Label = "Acme Quizzes", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            //copying asset to local db
            string sqliteFileName = "Quiz.sqlite";
            string libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(libraryPath, sqliteFileName);
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

            Spinner NumberOfQuestions = FindViewById<Spinner>(Resource.Id.NumberOfQuestions);
           
            
            Button StartButton = FindViewById<Button>(Resource.Id.StartButton);
            var questions = new SQLiteRepository().GetAllQuestions();

            NumberOfQuestions.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(NumberOfQuestions_ItemSelected);
            var adapter = new ArrayAdapter<string>(
                this, Android.Resource.Layout.SimpleSpinnerItem, questions.Select((question, index) => (index + 1).ToString()).ToList()
            ); 

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            NumberOfQuestions.Adapter = adapter;

            StartButton.Click += delegate
            {
                var numberOfQuesitons = new Intent(this, typeof(QuizQuestions));
                numberOfQuesitons.PutExtra("spin", (string)NumberOfQuestions.GetItemAtPosition(position));
                StartActivity(numberOfQuesitons);
            };


           

        }
        public int position
        {
            get; set;
        }

        private void NumberOfQuestions_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner NumberOfQuestions = (Spinner)sender;

            string toast = string.Format("You have selected {0} questions", NumberOfQuestions.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }


    }
}

