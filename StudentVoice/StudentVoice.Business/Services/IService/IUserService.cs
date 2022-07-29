using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Services.IService
{
    public interface IUserService
    {
        public IEnumerable<User> GetUsers();
        public User GetById(int id);
        public int AddUser(UserModel model);
        public IEnumerable<User> GetUserBySurvey(int id);
        public void Update(User user);
        public void Delete(int id);
        public int GetByEmail(string email);

    }
}