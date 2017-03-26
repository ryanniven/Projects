using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;


namespace ListViewsIHaveLoved
{

    [Activity(Label = "ListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        string[] items;

        protected override void OnCreate(Bundle savedInstancesState)
        {
            base.OnCreate(savedInstancesState);


            SetContentView(Resource.Layout.Main);

            ListView list = FindViewById<ListView>(Resource.Id.listView1);

            items = new string[] { "SimpleSelectableListItem", "SimpleListItem1", "SimpleListItem2", "SimpleListItemSingleChoice" };

            list.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);

            list.ItemClick += List_ItemClick;
        }

        void List_ItemClick (object sender, AdapterView.ItemClickEventArgs e)
        {
            var menuItem = items[e.Position];

            var activityType = Type.GetType(string.Format("ListViewsIHaveLoved.{0}", menuItem));

            if (activityType != null)
            {
                Intent nextActivity = new Intent(this, activityType);
                StartActivity(nextActivity);

            }


        }






        }
    }
}

