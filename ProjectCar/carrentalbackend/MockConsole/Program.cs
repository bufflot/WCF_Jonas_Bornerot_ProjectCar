using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsOfWork.UnitofWorkPattern;
using Domain;
using ContextService;
using System.Configuration;

namespace MockConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            IUnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());
            Console.WriteLine(unitOfWork.CustomerService.FindByID(1).FirstName);
            Console.ReadLine();

            //unitOfWork.CustomerService.Insert(new Customer { FirstName = "Jonas", LastName = "Bornerot", Email = "Jonas.Borneroth@Gmail.com" });
            //  var  y = unitOfWork.CarService.Insert(new Car { Avaliable = true, Brand= "da1445", Model= "xghah2", Year=1993,RegistrationNumber = "dad" });
            //   var tt = new Booking();
            //   tt.Car = y;
            //   tt.Customer = x;
            //   tt.StartTime = DateTime.UtcNow;
            //   tt.EndTime = DateTime.UtcNow;
            //   unitOfWork.BookingService.Insert(tt);
            //unitOfWork.CarService.Insert(new Car());
            //unitOfWork.CarService.Insert(new Car());
            //unitOfWork.CustomerService.Insert(new Customer());
            //unitOfWork.BookingService.Insert(new Booking
            //{
            //    CarID = 2,
            //    CustomerID = 1,
            //    StartTime = DateTime.UtcNow,
            //    EndTime = DateTime.UtcNow.AddHours(2),

            //});


            //Console.WriteLine(unitOfWork.CustomerService.FindByID(1).FirstName);

            //Console.ReadLine();

            //unitOfWork.CarService.Insert(new Car { Avaliable = true, Brand = "Merssaaaa", Year = 1996 });

            //unitOfWork.CarService.LendCar(4);

            //var cars = unitOfWork.CarService.GetBookable(DateTime.UtcNow.AddHours(1), DateTime.UtcNow.AddDays(1));
            //Console.WriteLine("available cars : " + cars.Count);

            //unitOfWork.BookingService.CreateBooking(new Booking(), new Car(), new Customer());
            //unitOfWork.BookingService.GetAllAvailableBookings();
            unitOfWork.Save();
        }
    }
}
