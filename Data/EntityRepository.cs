using System;
using System.Collections.Generic;
using System.Linq;
using Generics_5.Model;
using Generics_5.Validator;

namespace Generics_5.Data
{
    internal class EntityRepository<TEntity, TValidator> : IRepository<TEntity> where TEntity : IEntity where TValidator : IValidator<TEntity>, new()
    {
        private readonly List<TEntity> _storage = new List<TEntity>();
        private readonly IValidator<TEntity> _validator = new TValidator();

        public void Add(TEntity entity)
        {
            string errorMessage;

            if (!_validator.Validate(entity, out errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }

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
