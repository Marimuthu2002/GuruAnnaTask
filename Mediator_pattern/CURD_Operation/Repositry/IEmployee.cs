using CURD_Operation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.Repositry
{
    public interface IEmployee
    {
        public Task<List<Departments>> GetEmploye();
    }
}
