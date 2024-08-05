
using Ionic.Zip;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace UpdaterCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://stackoverflow.com/questions/47269609/system-net-securityprotocoltype-tls12-definition-not-found
            //https://learn.microsoft.com/en-us/dotnet/api/system.net.securityprotocoltype
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)(12288); //TLS 1.3
            if (args.Length >= 2)
            {
                if (args[0] == "install")
                {
                    Install(args[1]);
                }
                else if (args[0] == "uninstall")
                {
                    Uninstall(args[1]);
                } else
                {
                    Console.WriteLine("Unrecognised command");
                }
            } else
            {
                Console.WriteLine();
            }
        }

        static void Install(string id)
        {
            if (PkgIndexObj().ContainsKey(id))
            {
                if (!Directory.Exists(@"C:\BastionSG\Updater\DL\" + id))
                {
                    Directory.CreateDirectory(@"C:\BastionSG\");
                    Directory.CreateDirectory(@"C:\BastionSG\" + id);
                    Directory.CreateDirectory(@"C:\BastionSG\Updater\DL\" + id);
                }
                new WebClient().DownloadFile("https://raw.githubusercontent.com/BastionDevs/BastionUpdater/main/pkg/"+id+"/latest/download.zip", @"C:\BastionSG\Updater\DL\"+id+@"\download.zip");
                
                using (ZipFile zip = ZipFile.Read(@"C:\BastionSG\Updater\DL\" + id + @"\download.zip"))
                {
                    zip.ExtractAll(@"C:\BastionSG\" + id);
                }
            } else
            {
                Console.WriteLine("Invalid package ID");
            }
        }

        static void Uninstall(string id)
        {
            if (!Directory.Exists(@"C:\BastionSG\"+id))
            {
                Console.WriteLine("Package not installed");
            } else
            {
                Directory.Delete(@"C:\BastionSG\"+id, true);
                Console.WriteLine("Package uninstalled");
            }
        }

        static JObject PkgIndexObj()
        {
            using (WebClient client = new WebClient())
            {
                return JObject.Parse(client.DownloadString("https://raw.githubusercontent.com/BastionDevs/BastionUpdater/main/packages.json"));
            }
        }
    }
}
