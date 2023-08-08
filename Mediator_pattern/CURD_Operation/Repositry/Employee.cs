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

        public async Task<Departments> AddStud(Departments stud)
        {
            var data =  _dataBaseConnection.Stud.Add(stud);
            await _dataBaseConnection.SaveChangesAsync();
            return data.Entity;

        }

        public async Task<int> DeleteEmployee(int studId)
        {
            var filterdata = _dataBaseConnection.Stud.Where(a => a.StudId == studId).FirstOrDefault();
            _dataBaseConnection.Remove(filterdata);
            return await _dataBaseConnection.SaveChangesAsync();
        }

        public async Task<List<Departments>> GetEmploye()
        {
            var data = await _dataBaseConnection.Stud.ToListAsync();
            return data;
        }

        public async Task<Departments> GetEmployeeId(int employeeId)
        {
            var data = await _dataBaseConnection.Stud.Where(x => x.StudId == employeeId).FirstOrDefaultAsync();
            return data;
        }

        public async Task<int> UpdateStud(Departments stud)
        {
            _dataBaseConnection.Stud.Update(stud);
            return await _dataBaseConnection.SaveChangesAsync();
        }
    }
}
