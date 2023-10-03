using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Trigger.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            // Triggering the deep link.
            var url = new NSUrl("SeeingIGo://Notify_SIG_of_Navigation_By_Site_Id?site_id=88600001"); // You can add more parameters if needed.
            if (UIApplication.SharedApplication.CanOpenUrl(url))
            {
                UIApplication.SharedApplication.OpenUrl(url);
            }

            return base.FinishedLaunching(app, options);
        }
    }
}
