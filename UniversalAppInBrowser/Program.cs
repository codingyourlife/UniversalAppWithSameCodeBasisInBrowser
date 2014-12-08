using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalAppInBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            string sharedDir = "\"file://" + Directory.GetCurrentDirectory() + "..\\..\\..\\..\\AngularJSAgendaApp\\AngularJSAgendaApp.Shared\\default.html\"";

            var proc1 = new ProcessStartInfo();
            string anyCommand = "chrome.exe " + sharedDir + " -disable-web-security";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\\Program Files (x86)\\Google\\Chrome\\Application\\";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }
    }
}
