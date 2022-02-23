using CQRS_MediatR.Commands;
using CQRS_MediatR.Model;
using CQRS_MediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS_MediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<List<StudentModel>> Get()
        //{
        //    return await _mediator.Send(new GetStudentListQuery());
        //}

        /// <summary>
        /// Get Student.
        /// </summary>
        /// <returns>Danh sách sinh viên </returns>
        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await _mediator.Send(new GetStudentListQuery()).ConfigureAwait(false));

        //[HttpPost]
        //public async Task<StudentModel> Post([FromBody] Student value)
        //{
        //    var model = new AddStudentCommand(value.FirstName, value.LastName, value.Age);
        //    return await _mediator.Send(model);
        //}

        [HttpPost]
        public async Task<IActionResult> Post(AddStudentCommand request)
            => Ok(await _mediator.Send(request).ConfigureAwait(false));
    }
}
