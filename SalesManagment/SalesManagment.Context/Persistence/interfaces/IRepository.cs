﻿using System.Linq.Expressions;

namespace SalesManagment.Context.Repository.interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        T Get(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
