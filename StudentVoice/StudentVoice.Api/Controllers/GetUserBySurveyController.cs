using Microsoft.AspNetCore.Mvc;
using StudentVoice.Business.Services.IService;

namespace StudentVoice.Api.Controllers
{
    public class GetUserBySurveyController : ControllerBase
    {
        private readonly IUserService _userService;

        public GetUserBySurveyController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{surveyId}/GetUserBySurvey")]
        public IActionResult GetUserBySurvey(int surveyId)
        {
            return Ok(_userService.GetUserBySurvey(surveyId));
        }

    }
}
