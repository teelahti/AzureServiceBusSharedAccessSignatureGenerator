using System;
using System.IO;
using System.Reflection;
using Microsoft.ServiceBus;

namespace AzureServiceBusSharedAccessSignatureGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                PrintHelps();
                return;
            }

            string resource = args[0];
            string keyName = args[1];
            string primaryKey = args[2];

            string signature = SharedAccessSignatureTokenProvider.GetSharedAccessSignature(
                keyName,
                primaryKey,
                resource,
                TimeSpan.FromDays(500));

            Console.WriteLine("Complete HTTP header format signature:");
            Console.WriteLine(signature);
        }

        private static void PrintHelps()
        {
            var exe = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine("Usage: {0} resourceUri keyName primaryKey", exe);
            Console.WriteLine("e.g. {0} http://foo-ns.servicebus.windows.net/foo WriteEvents cia1mGdvhkD/XDXZD+vChY+fqVsGJr7N21fwHuABbMs=");
        }
    }
}
