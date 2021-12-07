using Microsoft.EntityFrameworkCore;

namespace Tacos
{
    public class TacosContext:DbContext
    {
        public DbSet<Tacos> Tacos { get; set; }

        public DbSet<Ingredient> Ingredient { get; set; }
        
        public TacosContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = "server=127.0.0.1;port=33061;database=tacos;uid=root;password=;TreatTinyAsBoolean=false";
            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        }

    }
}