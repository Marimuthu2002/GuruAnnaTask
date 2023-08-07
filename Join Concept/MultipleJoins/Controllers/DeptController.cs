using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LogicLayer;
namespace MultipleJoins.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptController : ControllerBase
    {
        private readonly IDataLogic _dataLogic;
        public DeptController(IDataLogic dataLogic)
        {
            _dataLogic = dataLogic;
        }

        [HttpGet("Departments")]
        public IActionResult Departments()
        {
            var data = _dataLogic.GetDepartments();
            return Ok(data);
        } 
        

      

    }
}
