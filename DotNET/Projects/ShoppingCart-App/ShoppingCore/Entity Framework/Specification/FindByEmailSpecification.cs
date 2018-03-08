using LinqKit;
using ShoppingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Entity_Framework.Specification
{
    class FindByEmailSpecification : ISpecification<User>
    {
        private UserSearchCriteria _criteria;

        public FindByEmailSpecification(UserSearchCriteria criteria)
        {
            _criteria = criteria;
        }

        public System.Linq.Expressions.Expression<Func<User, bool>> Expression
        {
            get
            {
                var builder = PredicateBuilder.New<User>();

                if (!String.IsNullOrEmpty(_criteria.Email))
                {
                    builder = builder.And(x => x.Email.Equals(_criteria.Email));

                }

                if (!String.IsNullOrEmpty(_criteria.Password))
                {
                    builder = builder.And(x => x.Password.Equals(_criteria.Password));

                }

                return builder;
            }
        }
    }
}
