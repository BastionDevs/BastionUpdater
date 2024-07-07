using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UpdaterGUI
{
    public class AppInfo
    {
        public bool AppInstalled(string app)
        {
            JObject AppManifest = JObject.Parse(File.ReadAllText(@"C:\BastionSG\Updater\manifest.json"));
            if ((string)AppManifest[app]["installed"] == "true")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string AppVer(string app)
        {
            JObject AppManifest = JObject.Parse(File.ReadAllText(@"C:\BastionSG\Updater\manifest.json"));
            return (string)AppManifest[app]["version"];
        }

        public bool AppIsLatestVersion(string app, string manifest)
        {
            JObject WebManifest = JObject.Parse(manifest);
            if ((string)WebManifest[app]["latestversion"] == AppVer(app)) {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
