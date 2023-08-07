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
    }
}
