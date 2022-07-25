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
    public class SurveyRepository : BaseRepository<Survey>, ISurveyRepository
    {
        public SurveyRepository(StudentVoiceDbContext studentVoiceDbContext) : base(studentVoiceDbContext)
        {

        }
        public IEnumerable<Survey> GetSurveyByUser(int userId)
        {
            return from User in _dbContext.Users
                   where User.Id == userId
                   from Surveys in User.Surveys
                   select Surveys;
        }
    }
}
