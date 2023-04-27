using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Meditor.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-R7AR1ND;initial catalog=DesignPattern8;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
