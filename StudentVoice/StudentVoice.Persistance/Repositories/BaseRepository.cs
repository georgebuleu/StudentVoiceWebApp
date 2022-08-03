using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentVoice.Persistance.Data;
using StudentVoice.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Persistance.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly StudentVoiceDbContext _dbContext;

        public BaseRepository(StudentVoiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public void Delete(T entity)
        {
                _dbContext.Set<T>().Remove(entity);
                _dbContext.SaveChanges();
            
        }
        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
        public IReadOnlyList<T> ListAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChangesAsync();
        }
    }
}