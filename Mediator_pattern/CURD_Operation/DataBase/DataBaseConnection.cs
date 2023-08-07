using CURD_Operation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.DataBase
{
    public class DataBaseConnection : DbContext
    {
        private readonly IConfiguration _IConfiguration;
        public DataBaseConnection(IConfiguration IConfiguration)
        {
            _IConfiguration = IConfiguration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_IConfiguration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Departments> Stud { get; set; }
    }
}
