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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(StudentVoiceDbContext studentVoiceDbContext) : base(studentVoiceDbContext)
        {
            
        }

        public void BanUsers(int id)
        {
            User user = _dbContext.Set<User>().Find(id);
            user.isBanned = true;
            _dbContext.SaveChanges();
        }

       
            public IEnumerable<User> GetUserBySurvey(int surveyId)
            {
                return from Survey in _dbContext.Surveys
                       where  Survey.Id== surveyId
                       from Users in Survey.Users
                       select Users;
            }
      

        public void UnbanUsers(int id)
        {
            User user = _dbContext.Set<User>().Find(id);
            user.isBanned = false;
            _dbContext.SaveChanges();
        }




    }
}
