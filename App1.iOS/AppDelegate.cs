﻿using System;
using System.IO;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace App1.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            string dbName = "app_db.sqlite";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..",
                "Library");
            string fullpath = Path.Combine(folderPath, dbName);

            Forms.Init();
            LoadApplication(new App(fullpath));

            return base.FinishedLaunching(app, options);
        }
    }
}