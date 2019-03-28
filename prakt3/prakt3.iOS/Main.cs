using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

namespace prakt3.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            var db = "db.db";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var fullpath = Path.Combine(path, db);
            if (!File.Exists(fullpath))
            {
                File.Copy(db, fullpath);
            }
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
