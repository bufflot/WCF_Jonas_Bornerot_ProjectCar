
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Booking : BaseEntity
    {
        public int CarID { get; set; }
        public int CustomerID { get; set; }


        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
