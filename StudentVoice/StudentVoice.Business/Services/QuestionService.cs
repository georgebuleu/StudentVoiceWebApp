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
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository,IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public int AddQuestion(QuestionModel model)
        {
           var question = _questionRepository.Add(_mapper.Map<Question>(model));

            return question.Id;
        }

        public void DeleteQuestion(int id)
        {
           _questionRepository.Delete(_questionRepository.GetById(id));
        }

        public IEnumerable<Question> GetBySurveyId(int surveyId)
        {
          return  _questionRepository.GetBySurveyId(surveyId);
        }

        public Question GetQuestion(int id)
        {
           return _questionRepository.GetById(id);
        }

        public IEnumerable<Question> GetQuestion()
        {
            return _questionRepository.ListAll();
        }
    }
}