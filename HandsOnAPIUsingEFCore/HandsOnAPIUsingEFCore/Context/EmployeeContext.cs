using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnAPIUsingEFCore.Models;


namespace HandsOnAPIUsingEFCore.Context
{
    public class EmployeeContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-FRJ149G\NANDINI;Database=ApiEFcore1;Trusted_Connection=True;");
        //}
        //DBset
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Employees { get; set; }

       
    }
}
