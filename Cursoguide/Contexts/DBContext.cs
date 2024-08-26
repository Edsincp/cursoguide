using Microsoft. EntityFrameworkCore;
using Courseguide.Objects. Models. Entities;
using Cursoseguide.Contexts.Builders;

namespace CourseGuide.Contexts
{

public class AppDBContext : DbContext
    {
        // Mapeamento Relacional dos Objetos no Bando de Dados
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        // Conjunto: Usuário
        public DbSet<UserModel> Users { get; set; }
        // Fluent API      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Entidades de Usuário:
            UserBuilder.Build(modelBuilder);
        }
    }
}