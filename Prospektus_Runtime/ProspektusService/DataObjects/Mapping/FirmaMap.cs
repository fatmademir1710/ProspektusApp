using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProspektusService.DataObjects.Mapping
{
    public class FirmaMap: EntityTypeConfiguration<Firma>
    {
        public FirmaMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id)
                             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Ad).
               IsRequired().
               HasMaxLength(50);

            ToTable("Firmas");
        }
        
    }
}