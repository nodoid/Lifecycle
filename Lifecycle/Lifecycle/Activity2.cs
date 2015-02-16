using Android.App;
using Android.OS;
using Android.Widget;

namespace Lifecycle
{
    [Activity(Label = "Activity2")]			
    public class Activity2 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Activity2);
            Toast.MakeText(this, "OnCreate-Activity2", ToastLength.Short).Show();
            var btn1 = FindViewById<Button>(Resource.Id.btnCAllActivity1);
            btn1.Click += delegate
            {
                Finish();
            };
        }

        protected override void OnStart()
        {
            base.OnStart();
            Toast.MakeText(this, "OnStart-Activity2", ToastLength.Short).Show();
        }

        protected override void OnResume()
        {
            base.OnResume();
            Toast.MakeText(this, "OnResume-Activity2", ToastLength.Short).Show();
        }

        protected override void OnPause()
        {
            base.OnPause();
            Toast.MakeText(this, "OnPause-Activity2", ToastLength.Short).Show();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Toast.MakeText(this, "OnDestroy-Activity2", ToastLength.Short).Show();
        }

        protected override void OnStop()
        {
            base.OnStop();
            Toast.MakeText(this, "OnStop-Activity2", ToastLength.Short).Show();
        }
    }
}

