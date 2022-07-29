using Microsoft.AspNetCore.Mvc;
using StudentVoice.Business.Models;
using StudentVoice.Business.Services.IService;

namespace StudentVoice.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_questionService.GetQuestion());
        }
        
        [HttpPost]
        public IActionResult AddQuestion([FromBody]QuestionModel model)
        {
            return CreatedAtAction(null,_questionService.AddQuestion(model));
        }

    }
}
