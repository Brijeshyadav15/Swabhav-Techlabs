using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIApiApp
{
    public interface IRepository<T> where T : Student
    {
        void Add(T entity);

        IQueryable<T> Get();
    }
}