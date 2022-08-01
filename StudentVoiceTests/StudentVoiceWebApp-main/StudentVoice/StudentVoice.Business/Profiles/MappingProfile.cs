using AutoMapper;
using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Survey, SurveyModel>().ReverseMap();

            CreateMap<User, UserModel>().ReverseMap();

            CreateMap<Notification, NotificationModel>().ReverseMap();

            CreateMap<Question, QuestionModel>().ReverseMap();


        }

    }
}
