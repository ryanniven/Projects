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

namespace ListView.Resources.values
{
    [Activity(Label = "Activity1")]
    public class ListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ListView list = FindViewById<ListView>(Resource.Id.listView1);

            var items = new string[] { "Fred", "Bob", "Beth", "Amy", "Toby" };
            list.Adapter = new ArrayAdapter<String>(this,
                Android.Resource.Layout.SimpleExpandableListItem1, items);
        }
    }
}