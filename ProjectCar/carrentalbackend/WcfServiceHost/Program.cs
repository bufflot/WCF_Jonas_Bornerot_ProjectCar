using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfBookingService;
using WcfCarService;
using WcfCustomerService;
using System.ServiceModel;

namespace WcfServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost[] hosts = new ServiceHost[]
            {
               new ServiceHost(typeof(ServiceCar)),
               new ServiceHost(typeof(ServiceBooking)),
               new ServiceHost(typeof(ServiceCustomer))
            };
            foreach (ServiceHost s in hosts)
            {
                s.Open();
                Console.WriteLine(s.Description.Name + " running @ " + DateTime.Now + " host status: " + s.State);
            }
            Console.ReadLine();


        }
    }
}
