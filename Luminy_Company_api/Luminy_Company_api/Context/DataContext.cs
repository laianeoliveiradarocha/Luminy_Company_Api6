using Luminy_Company_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Luminy_Company_api.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Passagens> Passagens { get; set; }
        public DbSet<Compras> Compras { get; set; }
    }
}
