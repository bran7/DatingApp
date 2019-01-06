using DatingApp.API.Models;
 
using Microsoft.EntityFrameworkCore;
 
namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
 
        }
 
        public DbSet<Value> Values { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
{
    string connectionString = @"Server=DESKTOP-4E3OTVN\SQLEXPRESS; DataBase=DatingApp.db; User ID=sa; Password=sa123456; Integrated Security= true;MultipleActiveResultSets=true;";
    optionbuilder.UseSqlServer(connectionString);
}
    
    }
}