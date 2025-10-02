using DataAccessLayer.Models.Students;
using DataAccessLayer.Models.Teachers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Contexts
{
    public class MasaqDbContext:DbContext
    {
        public MasaqDbContext(DbContextOptions<MasaqDbContext> options) : base(options)
        {
        }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        public DbSet<Teacher> Teachers {  get; set; }
        public DbSet<Student> Students {  get; set; }
    }
}
