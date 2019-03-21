using Android.App;
using Android.Content;
using Android.Gms.Common;
using Android.OS;
using Android.Util;
using Android.Widget;

using Firebase.Iid;
using Firebase.Messaging;

namespace FCMNotifications
{
    [Activity(Label = "Login", MainLauncher = true, Icon = "@drawable/icon")]
    public class Login : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            var logingBtn = FindViewById<Button>(Resource.Id.loginButton);
            logingBtn.Click += delegate
            {
                StartActivity(typeof(Menu));
            };
        }
    }
}