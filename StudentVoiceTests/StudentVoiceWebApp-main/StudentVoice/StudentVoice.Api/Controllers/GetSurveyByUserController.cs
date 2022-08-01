using Microsoft.AspNetCore.Mvc;
using StudentVoice.Business.Services.IService;

namespace StudentVoice.Api.Controllers
{
    public class GetSurveyByUserController : ControllerBase
    {
        private readonly ISurveyService _surveyService;

        public GetSurveyByUserController( ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpGet("{id}")]
        public IActionResult GetSurveyByUser(int id)
        {
            return Ok(_surveyService.GetSurveyByUser(id));
        }

    }
}
