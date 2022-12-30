using Chapter.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Chapter.WebApi.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext>options) : base(options)
        {
        }
        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-ADRIANO\\SQLEXPRESS; initial catalalog = Chapter; Integrated Security=true");

            }
        }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
