using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class DepDetails: DbContext
    {
        public DepDetails(DbContextOptions<DepDetails> options) : base(options)
        {

        }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<DeptEmployees> DeptEmployees { get; set; }
        public DbSet<DeptSalaryDetails> DeptSalaryDetails { get; set; }
        public DbSet<DeptAccountDetails> DeptAccountDetails { get; set; }
    }
}
