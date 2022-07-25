using AutoMapper;
using StudentVoice.Business.Models;
using StudentVoice.Business.Services.IService;
using StudentVoice.Domain.Entities;
using StudentVoice.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IMapper _mapper;

        public NotificationService(INotificationRepository notificationRepository,IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }

        public int AddNotification(NotificationModel model)
        {
            var notification = _notificationRepository.Add(_mapper.Map<Notification>(model));
            return notification.Id;
        }

        public Notification GetNotification(int id)
        {
           return _notificationRepository.GetById(id);
        }

        public IEnumerable<Notification> GetNotification()
        {
            return _notificationRepository.ListAll();
        }

        public void SeenNotification(int id)
        {
            _notificationRepository.SeenNotifications(id);
        }

        public void UnseenNotification(int id)
        {
            _notificationRepository.UnseenNotifications(id);
        }
    }
}
