using Microsoft.EntityFrameworkCore;
using ProEventos.API.models;

namespace ProEventos.API.data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}