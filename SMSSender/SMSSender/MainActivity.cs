using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace SMSSender
{
    [Activity(Label = "SMSSender", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);

            Button send = FindViewById<Button>(Resource.Id.sendButton);
            EditText recipient = FindViewById<EditText>(Resource.Id.phoneNumber);
            MultiAutoCompleteTextView message = FindViewById<MultiAutoCompleteTextView>(Resource.Id.messageContent);

            send.Click += delegate (object sender, System.EventArgs e)
           {
               if (string.IsNullOrEmpty(recipient.Text) || string.IsNullOrEmpty(message.Text))
               {
                   var dialog = new AlertDialog.Builder(this);
                   dialog.SetTitle("Error");
                   dialog.SetMessage("You must supply a recipient and a message");
                   dialog.SetNeutralButton("OK", (s, a) => { });
                   dialog.Show();
                   return;
               }
               
               var sms = new Intent (Intent.ActionSend);

               sms.PutExtra(Intent.ExtraPhoneNumber, new string[] { recipient.Text });
               sms.PutExtra(Intent.ExtraText, message.Text);

               sms.SetType("message/rfc822");

               StartActivity(sms);

           };

            


        }

    }
}

