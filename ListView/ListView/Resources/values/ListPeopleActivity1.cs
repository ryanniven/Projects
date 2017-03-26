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
    public class ListPeopleActivity1 : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
    {
            base.OnCreate(bundle);
            var items = new string[] { "Fred", "Bob", "Beth", "Amy", "Toby" };
            ListAdapter = new ArrayAdapter<String>(this,
                Android.Resource.Layout.SimpleListItem1.items);
            
            
            // Create your application here
        }
    }
}