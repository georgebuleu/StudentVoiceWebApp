using StudentVoice.Domain.Entities;
using StudentVoice.Domain.IRepositories;
using StudentVoice.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StudentVoice.Persistance.Repositories
{
    public class QuestionRepository : BaseRepository<Question>,IQuestionRepository
    {
        public QuestionRepository(StudentVoiceDbContext studentVoiceDbContext) : base(studentVoiceDbContext)
        {

        }
    }
}