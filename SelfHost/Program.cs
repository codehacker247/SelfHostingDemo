using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var servicehost = new ServiceHost(typeof(MathService)))
            {
                ServiceEndpoint BasicHttpEndPoint1 = servicehost.AddServiceEndpoint(
                    typeof(IMathService),
                    new BasicHttpBinding(),
                    "http://localhost:4444/MathService");

                ServiceEndpoint BasicHttpEndPoint2 = servicehost.AddServiceEndpoint(
                    typeof(IMathService),
                    new BasicHttpBinding(),
                    "http://localhost:5555/MathService");

                ServiceEndpoint NettcpEndPoint = servicehost.AddServiceEndpoint(
                    typeof(IMathService),
                    new NetTcpBinding(),
                    "net.tcp://localhost:6666/MathService");

                servicehost.Open();

                Console.WriteLine("Your WCF Service is running");
                Console.WriteLine("Your WCF Math Service is running is listening on below endpoints");

                foreach(ServiceEndpoint endpoint in servicehost.Description.Endpoints)
                {
                    Console.WriteLine("Address : {0} Binding Name : {1}",endpoint.Address.ToString(),endpoint.Binding.Name);
                }
                Console.WriteLine("Press any key to stop your WCF Math Service.");
                Console.ReadKey();  

                servicehost.Close();    
            }

        }
    }
}
