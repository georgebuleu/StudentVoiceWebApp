using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Services.IService
{
    public interface ISurveyService
    {
        public IEnumerable<Survey> GetSurveys();
        public Survey GetSurvey(int id);
        public int AddSurvey(SurveyModel survey);
        public void Update(Survey survey);
        public void Delete(int id);
        public IEnumerable< Survey> GetSurveyByUser(int id);
    }
}
