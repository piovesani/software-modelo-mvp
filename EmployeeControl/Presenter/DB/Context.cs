using EmployeeControl.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeControl.Presenter.DB
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options) { }
       
        public DbSet<EmployeeModel> Employees { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EmployeesDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>(entity =>
            {
                entity.Property(prop => prop.Id);
                entity.HasKey(prop => prop.Id);
            });
        }
    }
}
