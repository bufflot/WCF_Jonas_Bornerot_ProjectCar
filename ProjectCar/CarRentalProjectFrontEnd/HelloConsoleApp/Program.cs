using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //ONLY FOR TESTING

            WcfServiceHost.CarServiceClient client = new WcfServiceHost.CarServiceClient("BasicHttpBinding_IServiceCar");
            client.Open();
            

            Console.WriteLine("Please Enter your Name: " );
            Console.WriteLine(client.GetMessageString(Console.ReadLine()));
            Console.ReadLine();
    }
    }
}
