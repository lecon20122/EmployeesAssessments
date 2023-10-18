using EmployeesAssessments.Application.Features.AssessmentAnswers.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesAssessments.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssessmentAnswersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AssessmentAnswersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<AssessmentAnswerVm>>> AssessmentAnswers(long? id)
        {
            var query = new GetAssessmentAnswersQuery() { AssessmentId = id };
            var dtos = await _mediator.Send(query);
            return Ok(dtos);
        }
    }
}
