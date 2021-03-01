using Microsoft.EntityFrameworkCore;

namespace Projeto_MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost; port=3306; database=projetomvc; user=root; password=1234; Persist Security Info=False; Connect Timeout=300");
        }
    }
}