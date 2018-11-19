
using Domain;
using Repository;
using Services.IServices;
using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;

namespace Services.Services
{
    public class BookingService : Repository<Booking>, IBookingService
    {
        private readonly ICarService _carService;
        public BookingService(DbContext context, ICarService carService) : base(context)
        {
            _carService = carService;
        }



        public Booking CreateBooking(Booking booking)
        {
            try
            {
            var Currentcustumer = GetRepository(booking.Customer).FindByID(booking.CustomerID);
            var avaliableCars = _carService.GetBookable(booking.StartTime, booking.EndTime);
            return Insert(booking);
            }
            catch
            {
            throw new Exception("The input data does not match the constraints!");
            }
        }

        public ICollection GetAllAvailableBookings()
        {

            return GetAllWhere(x => x.StartTime.Day >= DateTime.UtcNow.Day).ToList();


        }

    }
}
