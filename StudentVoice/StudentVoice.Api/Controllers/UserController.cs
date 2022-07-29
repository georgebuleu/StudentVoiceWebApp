using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentVoice.Business.Models;
using StudentVoice.Business.Services.IService;
using StudentVoice.Domain.Entities;
using System;

namespace StudentVoice.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class UserController : ControllerBase { 

        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
    }

    [HttpGet]
   
    public IActionResult GetAll()
    {
        return Ok(_userService.GetUsers());
    }
        

        [HttpGet("{id}")]
      public IActionResult GetByID([FromBody] int id)
        {
            var userID = _userService.GetById(id);
            return Ok(userID);
        }

        [HttpGet("survey/{id}")]
        public IActionResult GetUserBySurvey(int id)
        {
            return Ok(_userService.GetUserBySurvey(id));
        }
       



        [HttpPost]
        public IActionResult AddUser([FromBody] UserModel model)
        {

            try
            {

                if (model.Email.Equals(_userService.GetById(_userService.GetByEmail(model.Email)).Email))
                return BadRequest("Email already exists");
            }
            catch (Exception) {

                return CreatedAtAction(null, _userService.AddUser(model));
            }
            return BadRequest("Email already exists2");
        }
        [HttpPut]

        public IActionResult Update([FromBody] User model)
        {
            _userService.Update(model);
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
