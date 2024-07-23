
# StandaloneMsi
This folder contains scripts that packages an appx file into an msi. It will also embed an installation script that will enable sideloading in the registry, trust the application cert if it is not already trusted and deploy the application. Currently this script is a proof of concept with hardcoded values, but later on it will be able to wrap any appx or appx bundle like this and read all the relevant information from the package directly.

## How it works
The [Wix toolset](http://wixtoolset.org/) is used to create a standard microsoft installer package. Msi files basically do two things, copy files and run scripts. The generated msi will extract the appx file, certificate and dependencies and then execute an included powershell script that uses the [Add-AppxPackage](https://technet.microsoft.com/en-us/library/dn448376.aspx) cmndlet to install the appx. The script also checks if the certificate for the application is trusted by the local machine and if sideloading is enabled, if not it performs these actions.


## Limitations
The scripts in this folder are at a proof of concept stage, the current implementation has several limitations

* Uninstallation is currently not implemented, but an emptry script is in place. When uninstalling the msi, the application will still be installed
* The msi installs the appx by extracting it to a folder in program files, before installing them into the uwp system. this means that the application is takeing up twice the disk space it really needs. In a future version, this temporary copy of the appx will be removed
* Currently the values in the wix file are hardcoded, in a future version these will be read from the appx package directly
* When installing appx apps via powershell or the packaging apis, its assumed that the capabilities the app demands are already approved by the users. The msis generated by this script do not currently display these to the users, or any other dialog boxes, it just installs the app. This means that the user is currently never told about what capabilties the app demands, but that is on the otherhand how win32 apps work today.