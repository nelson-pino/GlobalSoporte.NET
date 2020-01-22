using GlobalSoporte.NET.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GlobalSoporte.NET.DataAccess
{
    public class SoporteContext : DbContext
    {
        public SoporteContext() : base("SoporteContext") 
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Transport> Transport { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Factura> Factura { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}