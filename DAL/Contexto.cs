using AP1_P1_Jarissa.Model;
using Microsoft.EntityFrameworkCore;
namespace AP1_P1_Jarissa.DAL{
public class Contexto : DbContext
{
    public DbSet<Regist> Regist { get; set; }
    

    
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
    }

}
}
 