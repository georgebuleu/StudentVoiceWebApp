using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.Entities
{
    public class Question : BaseEntity
    {
        public string QuestionName { get; set; }

        public string TextField { get; set; }


        public int Rating { get; set; }

    }
}
