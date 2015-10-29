using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using OxyPlot.Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using OxyPlot.Xamarin.Android;

namespace OxyPlotTest01.Droid
{
	[Activity (Label = "OxyPlotTest01.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			OxyPlot.Xamarin.Forms.Platform.Android.Forms.Init();

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}

