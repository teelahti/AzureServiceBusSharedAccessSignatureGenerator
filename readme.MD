Create Azure service bus shared access signature via command line
=============================================================

[Shared access signatures](https://msdn.microsoft.com/en-us/library/azure/dn170477.aspx) 
are required when using the [Azure Service Bus REST API](https://msdn.microsoft.com/en-us/library/azure/hh780717.aspx). 
There is no easy tool to create these tokens, but there is a 
.NET SDK [API method GetSharedAccessSignature](https://msdn.microsoft.com/en-us/library/microsoft.servicebus.sharedaccesssignaturetokenprovider.getsharedaccesssignature.aspx). 
This [ScriptCS](http://scriptcs.net/) script is just a simple wrapper for that SDK.

To see helps run 

    $ scriptcs sasgenerator
	Usage: scriptcs sasgenerator -- resourceUri keyName primaryKey                                
    e.g. scriptcs sasgenerator -- http://foo-ns.servicebus.windows.net/foo WriteEvents cia1mGdvhkD/XDXZD+vChY+fqVsGJr7N21fwHuABbMs=
	                                              