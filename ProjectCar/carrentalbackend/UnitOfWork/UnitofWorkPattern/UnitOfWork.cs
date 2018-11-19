
using Services;
using Services.IServices;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfWork.UnitofWorkPattern
{
    
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly DbContext Context;
        
        public ICarService CarService { get; set; }
        public IBookingService BookingService { get; set; }
        public ICustomerService CustomerService { get; set; }

        public UnitOfWork(DbContext context)
        {
            this.Context = context;
            CarService = new CarService(context);
            BookingService = new BookingService(context, new CarService(context));
            CustomerService = new CustomerService(context);
            
        }

       

        public void Dispose()
        {
            Context.Dispose();
        }

        public int Save()
        {
           return Context.SaveChanges();
           
        }

       
    }
}
