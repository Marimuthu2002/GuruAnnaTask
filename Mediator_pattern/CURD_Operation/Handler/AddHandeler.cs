using CURD_Operation.Command;
using CURD_Operation.Model;
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
    public class AddHandeler : IRequestHandler<CreateEmployee, Departments>
    {
        private readonly IEmployee _employee;

        public AddHandeler(IEmployee employee)
        {
            _employee = employee;
        }
        public async Task<Departments> Handle(CreateEmployee request, CancellationToken cancellationToken)
        {
            var Employee = new Departments()
            {
                StudId = request.StudId,
                StudName = request.StudName,
                StudAge = request.StudAge,
                StudFees = request.StudFees
            };
            return await _employee.AddStud(Employee);
        }
    }
}
