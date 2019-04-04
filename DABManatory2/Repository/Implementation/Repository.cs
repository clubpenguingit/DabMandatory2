using DABMandatory2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DABMandatory2.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected BlackBoardContext _context;
        public Repository(BlackBoardContext blackboardDbContext)
        {
            _context = blackboardDbContext;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(params object[] keys)
        {
            _context.Set<T>().Remove(Get(keys));
        }

        public IEnumerable<T> Find(Expression<System.Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsEnumerable().ToList();
        }

        public T Get(params object[] keys)
        {
            return _context.Set<T>().Find(keys);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable().ToList();
        }
    }
}