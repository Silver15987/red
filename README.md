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
- Add a new value with SetValue(String, Object) -> takes 2 args, first is name, and second is data to store. Will be setted up as SetValue("Name", "Path")

## Dropping the Payload
- Get the user to download the file using http requests.
we can use the WebClient class in order to send HTTP requests and download files. 
- find user's temp folder via Path.GetTempPath
- spawn payload using DownloadFile(Uri, String)

## Prepare for exectuion
- Create new method to change the set the current directory and then list the files and folders in the directory.
- two different functions can be created depending on the operation command, wether cd or ls.
- For this functions to return the enumerated data must be created so that information from GeneralInfo can be relayed.
- Relay command for execution, for this a new class 'Process' must be created to create a new process that will use cmd or powershell then an argument will be passed to it. (Note: Make sure the new process doesn't create a new window for stealth using CreateNoWindow property).
- Connect to the C2 server using http get request and sleep. 