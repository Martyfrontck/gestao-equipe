using API.Models;
using  Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        // Lista de propriedades que serão transformadas em tabelas no banco de dados
        public DbSet<Pessoa> Pessoas { get; set;}

    }
}
