using StudentVoice.Domain.Entities;
using StudentVoice.Domain.IRepositories;
using StudentVoice.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Persistance.Repositories
{
    public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(StudentVoiceDbContext studentVoiceDbContext) : base(studentVoiceDbContext)
        {
            
        }

        public void SeenNotifications(int id)
            {
                Notification notification = _dbContext.Set<Notification>().Find(id);
                notification.isSeen = true;
                _dbContext.SaveChanges();
            }

        public void UnseenNotifications(int id)
        {
            Notification notification = _dbContext.Set<Notification>().Find(id);
            notification.isSeen = false;
            _dbContext.SaveChanges();
        }
    }
}