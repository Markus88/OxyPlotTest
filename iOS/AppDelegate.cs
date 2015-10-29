using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using OxyPlot.Xamarin.Forms;

namespace OxyPlotTest01.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			OxyPlot.Xamarin.Forms.Platform.iOS.Forms.Init();
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

