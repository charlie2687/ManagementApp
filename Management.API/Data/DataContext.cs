using Management.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Management.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Department> Departments { get; set; }
    }
}