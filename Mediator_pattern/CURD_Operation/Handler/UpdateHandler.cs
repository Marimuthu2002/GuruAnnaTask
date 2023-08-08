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
    public class UpdateHandler : IRequestHandler<UpdateEmployee, int>
    {
        private readonly IEmployee _employee;

        public UpdateHandler(IEmployee employee)
        {
            _employee = employee;
        }
     

        public async Task<int> Handle(UpdateEmployee request, CancellationToken cancellationToken)
        {
            var EmployeeDetails = await _employee.GetEmployeeId(request.StudId);
            if (EmployeeDetails == null)
                return default;

            EmployeeDetails.StudName = request.StudName;
            EmployeeDetails.StudAge = request.StudAge;
            EmployeeDetails.StudFees = request.StudFees;

            return await _employee.UpdateStud(EmployeeDetails);
        }
    }
}
