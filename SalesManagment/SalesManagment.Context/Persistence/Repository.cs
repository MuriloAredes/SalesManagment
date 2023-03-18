using Microsoft.EntityFrameworkCore;
using SalesManagment.Context.Data;
using SalesManagment.Context.Repository.interfaces;
using System.Linq.Expressions;


namespace SalesManagment.Context.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;
        DbSet<T> _dbSet;
        public Repository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<T> Add(T entity)
        {
           var result = await _dbSet.AddAsync(entity);
           await _context.SaveChangesAsync();
            return result.Entity;
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
           var result = await _dbSet.FirstOrDefaultAsync(predicate);
           
            return result;
        }

        public IEnumerable<T> GetAll()
        {           
          
            return _dbSet.AsEnumerable();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            var result =  _dbSet.FirstOrDefault(predicate);

            return result;
        }
    }
}
