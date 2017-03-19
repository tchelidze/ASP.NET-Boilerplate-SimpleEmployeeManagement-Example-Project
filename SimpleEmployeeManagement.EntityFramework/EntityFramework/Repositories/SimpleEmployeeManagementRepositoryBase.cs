using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SimpleEmployeeManagement.EntityFramework.Repositories
{
    public abstract class SimpleEmployeeManagementRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SimpleEmployeeManagementDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SimpleEmployeeManagementRepositoryBase(IDbContextProvider<SimpleEmployeeManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SimpleEmployeeManagementRepositoryBase<TEntity> : SimpleEmployeeManagementRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SimpleEmployeeManagementRepositoryBase(IDbContextProvider<SimpleEmployeeManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
