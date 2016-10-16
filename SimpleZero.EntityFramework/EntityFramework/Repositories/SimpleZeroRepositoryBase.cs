using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SimpleZero.EntityFramework.Repositories
{
    public abstract class SimpleZeroRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SimpleZeroDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SimpleZeroRepositoryBase(IDbContextProvider<SimpleZeroDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SimpleZeroRepositoryBase<TEntity> : SimpleZeroRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SimpleZeroRepositoryBase(IDbContextProvider<SimpleZeroDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
