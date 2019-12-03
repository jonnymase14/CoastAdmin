using CoastAdmin.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoastAdmin.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        //Names table Values when scaffold DB
        public DbSet<Value> Values { get; set;}
    }
}