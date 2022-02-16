# Task list

## Enumerate the information:
- OS version and system hostname
- Current user privileges
- Network configuration (IPV4, later update for IPV6)
- Current Directory
- Current process name and process id
- Executable path
- Detect if antivirus is installed and being run

## Gain Persistence
- Use run at start-up feature and setup persistance
- For this maybe setup a persistence class and define the function to add our executable file to the start-up folder for windows. Then Registry class can be used (Microsoft.Win32.Registry (Registry class))
- Path to can be opened with “HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run” with Registry.CurrentUser.OpenSubKey(string, boolean) method. Takes 2 args, first the name or path to subkey and access type. (Set access type to true)
- 