using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Models
{
    public class SurveyModel
    {
        public String status { get; set; }
        public String name { get; set; }
        public int rating { get; set; }
        public int likes { get; set; }
        public DateTime date { get; set; }
        public DateTime experationDate { get; set; }
        public String Professor {get;set;}
        public String Class {get;set;}
        public String Subject{get;set;}
    }
}
