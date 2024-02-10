using ApiAgenciaRecode.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ApiAgenciaRecode.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        { }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        
    }

}
