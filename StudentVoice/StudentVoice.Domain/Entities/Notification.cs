using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public string NotificationName { get; set; }
        public DateTime NotificationDate { get; set; }
        public Boolean isSeen { get; set; }
    }
}
