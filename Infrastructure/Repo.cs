using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace blog.Infrastructure
{
    public class Repo<T> where T : class, IEntity
    {
        private readonly UnitOfWork _uow;
        public Repo()
        {
            _uow = new UnitOfWork();
        }

        public DbSet<T> Set()
        {
            return _uow.context.Set<T>();
        }

        public IQueryable<T> Query()
        {
            return Set().AsQueryable();
        }
        
        public IEnumerable<T> GetAll()
        {
            return Query().ToArray();
        }

        public T GetById(int id)
        {
            return Query().SingleOrDefault(s => s.Id == id);
        }

        public void Add(T obj)
        {
            Set().Add(obj);
        }

        public void Remove(T obj)
        {
            Set().Remove(obj);
        }

        public void Save() {
            _uow.Commit();
        }
    }
}