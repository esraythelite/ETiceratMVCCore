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
    public class BrandConfiguration: IEntityTypeConfiguration<Brand>
    {        
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(a => a.BrandPhone).HasMaxLength(21).IsRequired();
            builder.Property(a => a.BrandName).IsRequired().HasMaxLength(40);
            builder.Property(a => a.BrandAdress).IsRequired().HasMaxLength(50);

            builder.Ignore(a => a.BrandPhoto);

        }
    }
}
