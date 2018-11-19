using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEntity
{
    public class CarMapping : EntityTypeConfiguration<Car>
    {
        public CarMapping()
        {
            HasKey(x => x.ID);
            ToTable(nameof(Car));
        }
    }
}
