using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.IRepositories
{
    public interface IUserRepository: IBaseRepository <User>
    {
        public IEnumerable<User> GetUserBySurvey(int id);
        public int GetUserByEmail(string email);
    }
}
