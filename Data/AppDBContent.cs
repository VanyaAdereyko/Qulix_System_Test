using Microsoft.EntityFrameworkCore;
using Qulix_Test_Task.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data
{
    public class AppDBContent : DbContext

    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Company> Company { get; set; }

    }
}
