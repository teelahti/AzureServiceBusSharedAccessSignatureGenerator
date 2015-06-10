using Microsoft.ServiceBus;

if (Env.ScriptArgs.Count() != 3) {
	Console.WriteLine("Usage: scriptcs sasgenerator -- resourceUri keyName primaryKey");
	Console.WriteLine("e.g. scriptcs sasgenerator -- http://foo-ns.servicebus.windows.net/foo WriteEvents cia1mGdvhkD/XDXZD+vChY+fqVsGJr7N21fwHuABbMs=");
	Environment.Exit(-1);
}

var resource = Env.ScriptArgs[0];
var keyName = Env.ScriptArgs[1];
var primaryKey = Env.ScriptArgs[2];

string signature = SharedAccessSignatureTokenProvider.GetSharedAccessSignature(
    keyName,
    primaryKey,
    resource,
    TimeSpan.FromDays(500));

Console.WriteLine("Complete HTTP header format signature:");
Console.WriteLine(signature);