using MappingEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Domain;

namespace ContextService
{
    public class DatabaseContext : DbContext
    {       
        
        public DatabaseContext() : base(@"Server = (LocalDb)\MSSQLLocalDB; Integrated security = SSPI; database = CarRentalDB")
        {

            //Database.SetInitializer<DatabaseContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMapping());
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new BookingMapping());
        }
    }
}
