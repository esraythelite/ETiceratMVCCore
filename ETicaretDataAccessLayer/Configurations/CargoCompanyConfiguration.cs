using ETicaretEntities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretDataAccessLayer.Configurations
{
    public class CargoCompanyConfiguration : IEntityTypeConfiguration<CargoCompany>
    {
        public void Configure(EntityTypeBuilder<CargoCompany> builder)
        {
            
        }
    }
}
