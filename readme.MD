Create Azure service bus shared access token via command line
=============================================================

[Shared access signatures](https://msdn.microsoft.com/en-us/library/azure/dn170477.aspx) 
are required when using the [Azure Service Bus REST API](https://msdn.microsoft.com/en-us/library/azure/hh780717.aspx). 
There is no easy tool to create these tokens, but there is a 
.NET SDK [API method GetSharedAccessSignature](https://msdn.microsoft.com/en-us/library/microsoft.servicebus.sharedaccesssignaturetokenprovider.getsharedaccesssignature.aspx). This project is just a simple command line 
wrapper for that method.

This same could easily be done with [ScriptCS](http://scriptcs.net), 
as it supports [installing NuGet packages](https://github.com/scriptcs/scriptcs/wiki/Package-installation).