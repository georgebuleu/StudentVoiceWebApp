using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentVoice.Domain.Entities
{
    public class User:BaseEntity  
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isAdmin {get; set; }
        public  ICollection<Survey> Surveys { get; set; }
        public ICollection<Notification> Notifications { get; set; }

    }
}
