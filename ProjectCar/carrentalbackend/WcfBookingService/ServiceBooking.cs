using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ContextService;
using Domain;
using UnitsOfWork.UnitofWorkPattern;

namespace WcfBookingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceBooking" in both code and config file together.
    public class ServiceBooking : IServiceBooking
    {
        IUnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public void CreateBooking(Booking booking)
        {
            try
            {
                Console.WriteLine("creating new booking for customer: "+ booking.Customer.FirstName);
                unitOfWork.BookingService.CreateBooking(booking);

                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new FaultException(e.Message);
            }
        }

        public Customer[] GetCustomerList()
        {
            try
            {
                Customer[] customer = unitOfWork.CustomerService.GetAll().ToArray();

                return customer;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new FaultException(e.Message);
            }
        }

        public Car[] GetCarList()
        {
            try
            {
                Car[] cars = unitOfWork.CarService.GetAll().ToArray();
                return cars;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new FaultException(e.Message);
            }
        }

        public Booking[] GetCurrentBookings()
        {
            Booking[] booking = unitOfWork.BookingService.GetAll().ToArray();
            return booking;
        }
    }
}
