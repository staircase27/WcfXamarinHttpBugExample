using System;
using System.ServiceModel;
using WcfService;

namespace WcfServiceConsoleApplication
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var wcfService = new HelloService();
            using (var host = new ServiceHost(wcfService))
            {
                Console.WriteLine(host.Credentials.ServiceCertificate.Certificate);
                host.Open();
                Console.WriteLine("Press enter to stop");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter){}
                host.Close();
            }
        }
    }
}
