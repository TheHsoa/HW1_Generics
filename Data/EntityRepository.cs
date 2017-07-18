using System.Collections.Generic;
using System.Linq;
using Generics_5.Model;

namespace Generics_5.Data
{
    internal class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity, IValidatable
    {
        private readonly List<TEntity> _storage = new List<TEntity>();

        public void Add(TEntity entity)
        {
            entity.Validate();
            _storage.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _storage.Remove(entity);
        }

        public TEntity GetById(long id)
        {
            return _storage.FirstOrDefault(o => o.Id == id);
        }

        public TEntity[] GetAll()
        {
            return _storage.ToArray();
        }
    }
}
