using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MT.EntityFramework.Repositories
{
    public abstract class MTRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MTDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MTRepositoryBase(IDbContextProvider<MTDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MTRepositoryBase<TEntity> : MTRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MTRepositoryBase(IDbContextProvider<MTDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
