using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Security.Permissions;
using System.Security.Principal;
using System.Net;

namespace red
{
    class GeneralInfo {
        public string osVersion;
        public string userName;
        public string currentDirectory;
        public string processName;
        public string  processId;
        public string executablePath;
        public string ipv4Address;
        public string hostName;
        public static bool isAdmin;
        public GeneralInfo() {
            osVersion = Environment.OSVersion.ToString();
            userName = Environment.UserName;
            hostName = Dns.GetHostName();
            ipv4Address = Dns.GetHostByName(hostName).AddressList[1].ToString();
            processName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            processId = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
            executablePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            using var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            var principal = new System.Security.Principal.WindowsPrincipal(identity);
            isAdmin = principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }

    }
}