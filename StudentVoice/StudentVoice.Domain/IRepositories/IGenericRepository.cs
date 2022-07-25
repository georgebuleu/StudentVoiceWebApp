using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Domain.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);

        IReadOnlyList<T> ListAll();

        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
