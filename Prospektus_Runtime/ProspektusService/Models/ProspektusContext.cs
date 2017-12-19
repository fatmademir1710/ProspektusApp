using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Tables;
using ProspektusService.DataObjects;
using ProspektusService.DataObjects.Mapping;

namespace ProspektusService.Models
{
    public class ProspektusContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        private const string connectionStringName = "Name=EnesConnectionString";

        public ProspektusContext() : base(connectionStringName)
        {
        } 

        public DbSet<Ilac> Ilacs { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Prospektus> Prospektuss { get; set; }
        public DbSet<EtkenMadde> EtkenMaddes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new EtkenMaddeMap());
            modelBuilder.Configurations.Add(new FirmaMap());
            modelBuilder.Configurations.Add(new IlacMap());
            modelBuilder.Configurations.Add(new ProspektusMap());

            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }
    }

}
