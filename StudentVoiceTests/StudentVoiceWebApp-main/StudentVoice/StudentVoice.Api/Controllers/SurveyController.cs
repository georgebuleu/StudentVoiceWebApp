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

        [HttpGet("{id}")]
        public IActionResult GetSurveyByUser(int id)
        {
            return Ok(_surveyService.GetSurveyByUser(id));
        }

        [HttpPost]
        public IActionResult AddSurvey([FromBody] SurveyModel model)
        {
            return CreatedAtAction(null, _surveyService.AddSurvey(model));
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
