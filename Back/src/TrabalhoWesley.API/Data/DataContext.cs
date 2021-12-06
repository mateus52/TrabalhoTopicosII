using Microsoft.EntityFrameworkCore;
using TrabalhoWesley.API.Models;

namespace TrabalhoWesley.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Loja> Loja { get; set; }
    }
}