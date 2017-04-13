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
                //copying db from assets folder into the specialfolder.personal to give the device access to the DB
                using (var f = this.Assets.Open("Quiz.sqlite"))
                {
                    using (var fileStream = System.IO.File.Create(path))
                    {
                        f.CopyTo(fileStream);
                    }
                }
            }

            //assigning the spinner to a variable "NumberOfQuestions"
            Spinner NumberOfQuestions = FindViewById<Spinner>(Resource.Id.NumberOfQuestions);
           
            //assigning the start button to a variable "StartButton"
            Button StartButton = FindViewById<Button>(Resource.Id.StartButton);
            var questions = new SQLiteRepository().GetAllQuestions();

           //binds adapter to simple spinner item
            NumberOfQuestions.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(NumberOfQuestions_ItemSelected);
            var adapter = new ArrayAdapter<int>(
                //spinner will dynamically give the user the option to select how many questions depending on the amount in the DB
                //intended on creating a random function so it doesnt give questions from the start of the list to finish
                //and it also gives questions that have not been answered in the current session
                this, Android.Resource.Layout.SimpleSpinnerItem, questions.Select((question, index) => index + 1).ToList()
            ); 

            //ensures spinner will display the amount of questions in the database
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            NumberOfQuestions.Adapter = adapter;

            //creating an activity to run when clicking the start button
            StartButton.Click += delegate
            {
                //creating an intent to carry the number of questions the user has selected into the next activity (Screen)
                var numberOfQuesitons = new Intent(this, typeof(QuizQuestions));
                numberOfQuesitons.PutExtra("MaxNumberOfQuestions", (int)NumberOfQuestions.SelectedItem);
                StartActivity(numberOfQuesitons);
            };

        }

        //toaster to show user number of questions they have selected
        private void NumberOfQuestions_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner NumberOfQuestions = (Spinner)sender;

            string toast = string.Format("You have selected {0} questions", NumberOfQuestions.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }


    }
}

