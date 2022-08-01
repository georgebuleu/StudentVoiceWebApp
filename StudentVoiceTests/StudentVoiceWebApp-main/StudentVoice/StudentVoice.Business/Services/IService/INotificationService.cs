using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Services.IService
{
    public interface INotificationService
    {
        public IEnumerable<Notification> GetNotification();
        public Notification GetNotification(int id);
        public int AddNotification(NotificationModel model);
        public void SeenNotification(int id);
        public void UnseenNotification(int id);
    }
}