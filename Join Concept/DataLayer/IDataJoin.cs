using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDataJoin
    {
        public object GetDepartmentsAll(DBModel DBModel);
        public object GetDeptAccountDetailsAll(DeptAccountDetails DeptAccountDetails);
        public object GetDeptEmployeesAll(DeptEmployees DeptEmployees);
        public object GetDeptSalaryDetailsAll(DeptSalaryDetails DeptSalaryDetails);
    }
}
