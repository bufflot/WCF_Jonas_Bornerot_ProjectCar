using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Domain
{
    [DataContract]
    public class Car : BaseEntity
    {
        [DataMember]
        public string RegistrationNumber { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int? Year { get; set; }
        [DataMember]
        public bool Avaliable { get; set; }

        public virtual Booking[] Bookings{ get; set; }
    }
}
