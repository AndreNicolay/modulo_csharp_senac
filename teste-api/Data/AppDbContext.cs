using Microsoft.EntityFrameworkCore;
using teste_api.Models;

namespace teste_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Fruta> Frutas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}