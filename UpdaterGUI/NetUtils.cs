using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace UpdaterGUI
{
    public class NetUtils
    {
        public static void DlFile(string url, string path)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(url, path);
        }

        public static string StringFromUrl(string url)
        {
            WebClient wc = new WebClient();
            return wc.DownloadString(url);
        }
    }
}
