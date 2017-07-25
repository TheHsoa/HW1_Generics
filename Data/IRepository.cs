using Generics_5.Model;

namespace Generics_5.Data
{
    internal interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity entity);

        void Remove(TEntity entity);

        TEntity GetById(long id);

        TEntity[] GetAll();
    }
}
