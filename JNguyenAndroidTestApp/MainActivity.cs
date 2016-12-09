using Android.App;
using Android.Widget;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Android.OS;

namespace JNguyenAndroidTestApp
{
    [Activity(Label = "JNguyenAndroidTestApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            MobileCenter.Start("556b7455-ae3b-4baf-8299-23d64bd1be75",
                    typeof(Analytics), typeof(Crashes));
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

