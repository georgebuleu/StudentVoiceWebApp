using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Models
{
    public class SurveyModel
    {
        public int Rating { get; set; }
        public int Likes { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }
        public String Professor {get;set;}
        public String Class {get;set;}
        public String Subject{get;set;}
        public ICollection<Question> Questions {get;set;}

    }
}
