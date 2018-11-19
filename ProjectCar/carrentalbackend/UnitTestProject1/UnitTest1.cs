using System;
using ContextService;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitsOfWork.UnitofWorkPattern;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IUnitOfWork work = new UnitOfWork(new DatabaseContext());
            var CarService = work.CarService;
        var car =  CarService.Insert(new Car
            {
                Avaliable = true,
                Brand ="Volvo2",
                Model ="volvo",
                RegistrationNumber="rgdf5", Year=1993,
                ID = 5
               



        });

         var customer =   work.CustomerService.Insert(new Customer
            {
                Email = "testmail",
                FirstName = "wilmaar",
                Tel =044555,
                LastName ="test"
            });
 try
            {
                var x = work.BookingService.CreateBooking(new Booking
                {
                    EndTime = DateTime.UtcNow,
                    StartTime = DateTime.UtcNow.AddHours(1),



                }, car, customer

              );
                Assert.Fail(); // If it gets to this line, no exception was thrown
            }
            catch (Exception e) {
                var x = work.BookingService.CreateBooking(new Booking
                {
                   
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow.AddHours(1),



                }, car, customer

            );


            }
           
            work.Save();

          
           
            work.BookingService.GetAllAvailableBookings();

        }
    }
}
