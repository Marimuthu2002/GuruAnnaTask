using CURD_Operation.Command;
using CURD_Operation.Model;
using CURD_Operation.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeListController : ControllerBase
    {
        private readonly IMediator _mediator;   

        public EmployeeListController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("get")]
        public async Task<List<Departments>> GetEmployeeListAsync()
        {
            var EmployeeDetails = await _mediator.Send(new EmployeeListQuery());

            return EmployeeDetails;
        }
        [HttpPost("post")]
        public async Task<Departments> PostEmployeeListAsync(Departments Stud)
        {
            var studentDetail = await _mediator.Send(new CreateEmployee(
                Stud.StudId,
                Stud.StudName,
                Stud.StudAge,
                Stud.StudFees
                ));
            return studentDetail;
        }
        [HttpPut]
        public async Task<int> UpdateStudentAsync(Departments Stud)
        {
            var isEmployeeDetailUpdated = await _mediator.Send(new UpdateEmployee(
               Stud.StudId,
                Stud.StudName,
                Stud.StudAge,
                Stud.StudFees
                ));
            return isEmployeeDetailUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await _mediator.Send(new DeleteEmployee() { StudId = Id });
        }
    }
}
