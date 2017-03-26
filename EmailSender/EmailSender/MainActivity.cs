using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace EmailSender
{
    [Activity(Label = "EmailSender", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button send;
        EditText recipient;
        EditText subject;
        EditText message;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
             send = FindViewById<Button>(Resource.Id.sendButton);
             recipient = FindViewById<EditText>(Resource.Id.email);
             subject = FindViewById<EditText>(Resource.Id.subject);
             message = FindViewById<EditText>(Resource.Id.message);

            send.Click += Send_Click;
            }

        private void Send_Click(object sender, System.EventArgs e)
        {
            var email = new Intent(Android.Content.Intent.ActionSend);

            email.PutExtra(Android.Content.Intent.ExtraEmail,
                      new string[] { recipient.Text });

            email.PutExtra(Android.Content.Intent.ExtraSubject, subject.Text);
            email.PutExtra(Android.Content.Intent.ExtraText,
                             message.Text);

            email.SetType("message/rfc822");

            StartActivity(email);

        }
    }
}

