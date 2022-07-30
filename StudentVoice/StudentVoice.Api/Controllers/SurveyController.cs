using Microsoft.AspNetCore.Mvc;
using StudentVoice.Business.Models;
using StudentVoice.Business.Services.IService;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService _surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;

        }
        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_surveyService.GetSurveys());
        }

        [HttpGet("user/{id}")]
        public IActionResult GetSurveyByUser(int id)
        {
            return Ok(_surveyService.GetSurveyByUser(id));
        }
        [HttpGet("{id}")]
        public IActionResult GetSurveyById(int id)
        {
            return Ok(_surveyService.GetSurvey(id));
        }

        [HttpPost]
        public IActionResult AddSurvey([FromBody] SurveyModel model)
        {
            var survey = _surveyService.AddSurvey(model);
          
            return CreatedAtAction(null, survey);
         
        }
        [HttpPut]

        public IActionResult Update([FromBody] Survey model)
        {
            _surveyService.Update(model);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            _surveyService.Delete(id);
            return NoContent();
        }
    }
}
