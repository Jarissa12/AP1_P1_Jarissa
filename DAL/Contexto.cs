using AP1_P1_Jarissa.Model;
using Microsoft.EntityFrameworkCore;
namespace AP1_P1_Jarissa.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aporte> aporte { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

    }
}
