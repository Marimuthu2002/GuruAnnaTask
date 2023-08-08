using CURD_Operation.Command;
using CURD_Operation.Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CURD_Operation.Handler
{
    public class DeleteHandler : IRequestHandler<DeleteEmployee, int>
    {
        private readonly IEmployee _employee;

        public DeleteHandler(IEmployee employee)
        {
            _employee = employee;
        }

        public async Task<int> Handle(DeleteEmployee request, CancellationToken cancellationToken)
        {
            var EmployeeDetails = await _employee.GetEmployeeId(request.StudId);
            if (EmployeeDetails == null)
                return default;

            return await _employee.DeleteEmployee(EmployeeDetails.StudId);
        }
    }
}
