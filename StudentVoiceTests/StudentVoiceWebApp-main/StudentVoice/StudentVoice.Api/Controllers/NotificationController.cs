using Microsoft.AspNetCore.Mvc;
using StudentVoice.Business.Models;
using StudentVoice.Business.Services.IService;

namespace StudentVoice.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {

        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]

        public IActionResult GetAllNotifications()
        {
            return Ok(_notificationService.GetNotification());
        }

        [HttpGet("{id}")]

        public IActionResult GetNotification(int id)
        {
            return Ok(_notificationService.GetNotification(id));
        }
        
        [HttpPut("{id}")]

        public IActionResult SeenNotification(int id)
        {

            _notificationService.SeenNotification(id);

            return NoContent();
        }

        [HttpPost]

        public IActionResult AddNotification([FromBody] NotificationModel model)
        {

            return CreatedAtAction(null,_notificationService.AddNotification(model));
        }

    }  
}
