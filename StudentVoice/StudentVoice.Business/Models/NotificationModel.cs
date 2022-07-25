using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Models
{
    public class NotificationModel
    {
        public string Notification { get; set; }
        public DateTime NotificationDate { get; set; }
        public Boolean isSeen { get; set; }

    }
}
