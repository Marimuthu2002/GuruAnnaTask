using CURD_Operation.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.Query
{
    public class EmployeeListQuery:IRequest <List<Departments>>
    {
    }
}
