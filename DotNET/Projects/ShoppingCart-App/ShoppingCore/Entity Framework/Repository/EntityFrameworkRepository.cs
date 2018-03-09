using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShoppingCore.Entity_Framework.Repository.UnitOfWork;
using LinqKit;

namespace ShoppingCore.Entity_Framework.Repository
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : Entity
    {
        public Guid Add(T entity)
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Set<T>().Add(entity);
                unitOfWork.SaveChanges();
                return entity.Id;
            }
        }

        public int Count(ISpecification<T> specification)
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>().AsExpandable().Where(specification.Expression).Count();
            }
        }

        public int CountAll()
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>().AsExpandable().Count();
            }
        }

        public void Delete(Guid entityId)
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Set<T>().Remove(GetById(entityId));
                unitOfWork.SaveChanges();
            }
        }

        public IList<T> Find(ISpecification<T> specification)
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Reading))
            {
                var queryable = unitOfWork.DbContext.Set<T>().AsExpandable().Where(specification.Expression);
                return queryable.ToList();
            }
        }

        public IList<T> Get()
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Reading))
            {
                return unitOfWork.DbContext.Set<T>().ToList();
            }
        }

        public T GetById(Guid entityId)
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Reading))
            {
               return unitOfWork.DbContext.Set<T>().SingleOrDefault(x => x.Id == entityId);
            }
        }

        public void Update(T entity)
        {
            using (var unitOfWork = new UnitOfWorkScope<ShoppingCartContext>(UnitOfWorkScopePurpose.Writing))
            {
                unitOfWork.DbContext.Set<T>().Remove(GetById(entity.Id));
                unitOfWork.DbContext.Set<T>().Add(entity);
                unitOfWork.SaveChanges();
            }
        }
    }
}
