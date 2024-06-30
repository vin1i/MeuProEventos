using MeuProEvento.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuProEvento.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Eventos = Set<Evento>(); // Inicializa o DbSet<Evento>
        }
    }
}
