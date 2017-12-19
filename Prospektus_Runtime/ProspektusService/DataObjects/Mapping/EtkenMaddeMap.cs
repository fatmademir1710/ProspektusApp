using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace ProspektusService.DataObjects.Mapping
{
    public class EtkenMaddeMap : EntityTypeConfiguration<EtkenMadde>
    {
        public EtkenMaddeMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id)
               .IsRequired();

            Property(t => t.Ad).
               IsRequired().
               HasMaxLength(50);

            ToTable("EtkenMaddes");

            HasOptional(t => t.Prospektus).
WithMany(t => t.EtkenMaddes).
HasForeignKey(d => d.ProspektusId);
        }

    }
}