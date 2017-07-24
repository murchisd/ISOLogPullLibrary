# Office 365 Log Pull Library

Office 365 Log Pull Library is a library written in C# to help applications interact with the Office 365 Management API to manage logs. The project was started as a way to re-establish logging user access for Exchange after a migration from an on-premises Exchange Server to Exchange Online.

There are 3 means to access logs in Exchange Online. 

* The web based security and compliance user interface
* Powershell scripts
* Office 365 Management API

The Office 365 Management API is the only means that will scale, and should be considered to be the primary way to retrieve activity logs for online Office 365 services.

This library helps applications 

* Authenticate to the Microsoft Management Activty API 
* Start, Stop, and List subscriptions
* Retrieve available activity log content

When used with [ExchangeOnlineLogPull](https://github.com/murchisd/ExchangeOnlineLogPull) Console Application it provides a quick and easy way to retrieve activity logs from online services such as Exchange, SharePoint, and Azure Active Directory.

## Authors

* **Donald Murchison** - *Initial work* - [murchisd](https://github.com/murchisd)

