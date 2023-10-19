using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentAndQuestion;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentQuestion;
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
        [ProducesResponseType(typeof(List<AssessmentAnswerVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<AssessmentAnswerVm>>> AssessmentAnswers()
        {
            var query = new GetAssessmentAnswersQuery();
            var dtos = await _mediator.Send(query);
            return Ok(dtos);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<AssessmentAnswersWithAssessmentQuestionVm>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<AssessmentAnswersWithAssessmentQuestionVm>>> AssessmentAnswersWithAssessmentQuestion()
        {
            var query = new GetAssessmentAnswersWithAssessmentQuestionQuery();
            var dtos = await _mediator.Send(query);
            return Ok(dtos);
        }

    }
}
