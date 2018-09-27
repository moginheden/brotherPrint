using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Android;
using Android.Support.Design.Widget;

namespace PrintTest.Droid
{
    [Activity(Label = "PrintTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        readonly string[] PermissionsStorage =
        {
          Android.Manifest.Permission.ReadExternalStorage,
          Android.Manifest.Permission.WriteExternalStorage
        };

        const int RequestFilesId = 0;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            //Check to see if any permission in our group is available, if one, then all are
            const string permission = Manifest.Permission.AccessFineLocation;
            if (CheckSelfPermission(permission) == (int)Permission.Granted)
            {
                return;
            }

            //Finally request permissions with the list of permissions and Id
            RequestPermissions(PermissionsStorage, RequestFilesId);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override async void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            if (requestCode == RequestFilesId)
            {
                if (grantResults[0] == Permission.Granted)
                {
                    Toast.MakeText(this, "storage permision granted", ToastLength.Short);
                }
                else
                {
                    Toast.MakeText(this, "storage permision denied", ToastLength.Short);
                }
            }
        }
    }
}