using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentVoice.Business.Models;
using StudentVoice.Business.Services.IService;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : ControllerBase { 

        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetUsers());
    }
        [Authorize]
        [HttpGet("{id}")]
      public IActionResult GetByID([FromBody] int id)
        {
            var userID = _userService.GetById(id);
            return Ok(userID);
        }
        

        [HttpPost]
        public IActionResult AddSurvey([FromBody] UserModel model)
        {
            return CreatedAtAction(null, _userService.AddUser(model));
        }
        [HttpPut]

        public IActionResult Update([FromBody] User model)
        {
            _userService.Update(model);
            return NoContent();
        }
        
        [HttpPut ("{id}")]

        public IActionResult BanUser( int id)
        {
            
            _userService.BanUser(id);

            return NoContent();
        }
        
   

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}
