using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AppBug4635.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow _window;
        public override UIWindow Window
        {
            get => _window;
            set => _window = value;
        }

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_sqlite3());

            Window = new UIWindow()
            {
                RootViewController = new UINavigationController(new MainViewController())
            };

            Window.MakeKeyAndVisible();
            return true;
        }
    }
}
