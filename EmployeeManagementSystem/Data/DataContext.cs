using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;



namespace EmployeeManagementSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        { }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<EmpTask> Tasks { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeTask>().HasKey(et => new { et.EmployeeId, et.EmpTaskId });
        modelBuilder.Entity<EmployeeTask>().HasOne(e => e.Employee).WithMany(et => et.EmployeeTasks).HasForeignKey(e => e.EmployeeId);
        modelBuilder.Entity<EmployeeTask>().HasOne(e => e.Task).WithMany(et => et.EmployeeTasks).HasForeignKey(et => et.EmpTaskId);

    }
}
}
