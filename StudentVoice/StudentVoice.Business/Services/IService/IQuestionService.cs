using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Services.IService
{
    public interface IQuestionService
    {
        public IEnumerable<Question> GetQuestion();
        public Question GetQuestion(int id);
        public int AddQuestion(QuestionModel model);
        public IEnumerable<Question> GetBySurveyId(int surveyId);
        public void DeleteQuestion(int id);
    }
}