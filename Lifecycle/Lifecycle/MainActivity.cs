using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace Lifecycle
{
    [Activity(Label = "Lifecycle", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Activity1);
            Toast.MakeText(this, "OnCreate-Activity 1", ToastLength.Short).Show();
            var btn2 = FindViewById<Button>(Resource.Id.btnCAllActivity2);
            btn2.Click += delegate
            {
                var intent = new Intent(this, typeof(Activity2));
                intent.SetAction(Intent.ActionView);
                StartActivity(intent);
            };
        }

        protected override void OnStart()
        {
            base.OnStart();
            Toast.MakeText(this, "OnStart-Activity1", ToastLength.Short).Show();
        }

        protected override void OnResume()
        {
            base.OnResume();
            Toast.MakeText(this, "OnResume-Activity1", ToastLength.Short).Show();
        }

        protected override void OnPause()
        {
            base.OnPause();
            Toast.MakeText(this, "OnPause-Activity1", ToastLength.Short).Show();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Toast.MakeText(this, "OnDestroy-Activity1", ToastLength.Short).Show();
        }

        protected override void OnStop()
        {
            base.OnStop();
            Toast.MakeText(this, "OnStop-Activity1", ToastLength.Short).Show();
        }
    }
}


