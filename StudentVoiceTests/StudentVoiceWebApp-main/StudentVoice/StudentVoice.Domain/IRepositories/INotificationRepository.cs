using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.IRepositories
{
    public interface INotificationRepository: IBaseRepository<Notification>
    {
        public void SeenNotifications(int id);
        public void UnseenNotifications(int id);


    }
}
