using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Acme_Quizzes_App
{
    [Activity(Label = "Acme Quizzes", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);

            Spinner NumberOfQuestions = FindViewById<Spinner>(Resource.Id.NumberOfQuestions);
            Button StartButton = FindViewById<Button>(Resource.Id.StartButton);

            NumberOfQuestions.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(NumberOfQuestions_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.number_of_questions_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            NumberOfQuestions.Adapter = adapter;

            StartButton.Click += delegate
            {
                StartActivity(typeof(QuizQuestions));
            };
        }

        private void NumberOfQuestions_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner NumberOfQuestions = (Spinner)sender;

            string toast = string.Format("You have selected {0} questions", NumberOfQuestions.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
    }
}

