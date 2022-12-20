using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EFCoreCodeFirst.Models
{
    public class EmpoyeeContext :DbContext
    {
        public EmpoyeeContext(DbContextOptions<EmpoyeeContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
