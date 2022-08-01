using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.IRepositories
{
    public interface ISurveyRepository: IBaseRepository<Survey>
    {
        public IEnumerable<Survey> GetSurveyByUser(int userId);
    }
}
