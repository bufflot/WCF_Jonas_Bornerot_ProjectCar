using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;

namespace WcfBookingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceBooking" in both code and config file together.
    [ServiceContract]
    public interface IServiceBooking
    {
        [OperationContract]
        Customer[] GetCustomerList();

        [OperationContract]
        Car[] GetCarList();

        [OperationContract]
        void CreateBooking(Booking booking);

        [OperationContract]
        Booking[] GetCurrentBookings();
    }
}
