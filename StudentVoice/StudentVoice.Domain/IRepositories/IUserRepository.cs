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
        public void BanUsers(int id);
        public void UnbanUsers(int id);

        public IEnumerable<User> GetUserBySurvey(int id);
    }
}
