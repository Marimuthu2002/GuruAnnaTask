using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Departments
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepName { get; set; }
     
    }
    public class DeptEmployees
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public int DepartmentID { get; set; }
    } 
    public class DeptSalaryDetails
    {
        [Key]
        public int SalaryId { get; set; }
        public int SalaryAmount { get; set; }
        public int EmpID { get; set; }
    }    
    public class DeptAccountDetails
    {
        [Key]
        public string AccType { get; set; }
        public string AccHolderName { get; set; }
        public int SalaryId { get; set; }
    }
}
