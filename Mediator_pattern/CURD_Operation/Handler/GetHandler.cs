using CURD_Operation.Model;
using CURD_Operation.Query;
using CURD_Operation.Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CURD_Operation.Handler
{
    public class GetHandler : IRequestHandler<EmployeeListQuery, List<Departments>>
    {
        private readonly IEmployee _Employee;
        public GetHandler(IEmployee Employee)
        {
            _Employee = Employee;
        }
        public async Task<List<Departments>> Handle(EmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _Employee.GetEmploye();
        }
    }
}
