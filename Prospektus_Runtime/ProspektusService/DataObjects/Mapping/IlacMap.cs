using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace ProspektusService.DataObjects.Mapping
{
    public class IlacMap: EntityTypeConfiguration<Ilac>
    {
        public IlacMap()
        {
            HasKey(t => t.Id);


            Property(t => t.Id)
                .IsRequired();

           Property(t => t.Ad).
                IsRequired().
                HasMaxLength(50);

            Property(t => t.Barkod)
                 .HasColumnName("Barkod");

            Property(t => t.Fiyat);


            ToTable("Ilacs");


                HasOptional(t => t.Firma).
                WithMany(t => t.Ilacs).
                HasForeignKey(d => d.FirmaId);

            HasRequired(m => m.Prospektus)
          .WithMany()
          .HasForeignKey(c => c.ProspektusId);
        }   


    }
}