using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithQuestion;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesAssessments.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AssessmentAnswersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AssessmentAnswersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<GetAssessmentAnswerVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAssessmentAnswerVm>>> AssessmentAnswers()
        {
            var query = new GetAssessmentAnswersQuery();
            var dtos = await _mediator.Send(query);
            return Ok(dtos);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<AssessmentAnswersWithQuestionVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<AssessmentAnswersWithQuestionVm>>> AssessmentAnswersWithQuestion()
        {
            var query = new GetAssessmentAnswersWithQuestionQuery();
            var dtos = await _mediator.Send(query);
            return Ok(dtos);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateAssessmentAnswerCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
