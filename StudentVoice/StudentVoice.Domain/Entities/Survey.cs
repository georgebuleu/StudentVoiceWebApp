using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.Entities
{
    public class Survey : BaseEntity

    {
        public int Rating { get; set; }
        public int Likes { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Question> Questions { get; set; }
        public String Professor { get; set; }
        public String Class { get; set; }
        public String Subject { get; set; }
    }
}