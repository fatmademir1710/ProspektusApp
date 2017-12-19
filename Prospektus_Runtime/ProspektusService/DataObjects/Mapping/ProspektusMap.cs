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
    public class ProspektusMap: EntityTypeConfiguration<Prospektus>
    {
        public ProspektusMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            ToTable("Prospektuss");

        }
    }
}