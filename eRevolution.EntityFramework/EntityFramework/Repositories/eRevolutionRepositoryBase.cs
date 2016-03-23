using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace eRevolution.EntityFramework.Repositories
{
    public abstract class eRevolutionRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<eRevolutionDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected eRevolutionRepositoryBase(IDbContextProvider<eRevolutionDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class eRevolutionRepositoryBase<TEntity> : eRevolutionRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected eRevolutionRepositoryBase(IDbContextProvider<eRevolutionDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
