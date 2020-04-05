using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CaculatorService;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace cmdService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service)))
            {
                host.Open();

                Console.WriteLine("The service is ready");
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
