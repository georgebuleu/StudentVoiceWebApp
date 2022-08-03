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
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository _surveyRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public SurveyService(ISurveyRepository surveyRepository, IQuestionRepository questionRepository, IMapper mapper)
        {
            _surveyRepository = surveyRepository;
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public int AddSurvey(SurveyModel model)
        {
            var survey = _surveyRepository.Add(_mapper.Map<Survey>(model));
         
            return survey.Id;
        }

        public void Delete(int id)
        {
           _surveyRepository.Delete(_surveyRepository.GetById(id));
         
            
        }

        public Survey GetSurvey(int id)
        {
           return _surveyRepository.GetById(id);
        }

        public IEnumerable<Survey> GetSurveys()
        {
            return _surveyRepository.ListAll();
        }

        public void Update(Survey survey)
        {
            _surveyRepository.Update(survey);
        }
        public IEnumerable< Survey> GetSurveyByUser(int id) 
        {

          return _surveyRepository.GetSurveyByUser(id);
            
        }
    }
}
