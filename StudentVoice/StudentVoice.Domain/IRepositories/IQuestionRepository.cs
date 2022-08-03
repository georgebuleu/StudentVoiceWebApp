using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.IRepositories
{
    public interface IQuestionRepository: IBaseRepository<Question>
    {
        public IEnumerable<Question> GetBySurveyId(int surveyId);
    }
}
