using CURD_Operation.DataBase;
using CURD_Operation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.Repositry
{
    public class Employee : IEmployee
    {
        private readonly DataBaseConnection _dataBaseConnection;
        public Employee(DataBaseConnection dataBaseConnection)
        {
            _dataBaseConnection= dataBaseConnection;    
        }
        public async Task<List<Departments>> GetEmploye()
        {
            var data = await _dataBaseConnection.Stud.ToListAsync();
            return data;
        }
    }
}
