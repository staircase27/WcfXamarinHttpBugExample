using System;
using System.Net;
using WcfClient;

namespace WcfConsoleClient
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;

            Console.WriteLine("Using http for bob");
            RunClient(false, "bob");
            Console.WriteLine("Using https for ben");
            RunClient(true, "ben");
        }

        private static void RunClient(bool useHttps, string name)
        {
            var client = new Client(useHttps);
            client.Open().Wait();
            try
            {
                Console.WriteLine($@"Got ""{client.SayHello(name).Result}"" on {client.Url}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"Exception for name - ""{name}"" on client - {client.Url}:
{exception}");
            }
        }
    }
}
