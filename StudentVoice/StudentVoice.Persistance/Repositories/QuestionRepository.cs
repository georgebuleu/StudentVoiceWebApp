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
    public class QuestionRepository : BaseRepository<Question>,IQuestionRepository
    {
        public QuestionRepository(StudentVoiceDbContext studentVoiceDbContext) : base(studentVoiceDbContext)
        {
            
        }
        public IEnumerable<Question> GetBySurveyId(int surveyId)
        {
            return from Question in _dbContext.Questions
                   where surveyId == Question.Id
                   select Question;
         }
    }
}