using System;
using System.Diagnostics;
namespace red
{
    class driver
    {
        static void Main(string[] args)
        {
            GeneralInfo ob = new GeneralInfo();
            Debug.WriteLine("UserInfo\nOS Version:{0}\nUser:{1}\nHost Name:{2}\nIPV4:{3}\nProcess ID:{4}\nProcess Name:{5}\nExecutable Path:{6}", ob.osVersion, ob.userName, ob.hostName, ob.ipv4Address, ob.processId, ob.processName, ob.executablePath);
        }
    }
}
