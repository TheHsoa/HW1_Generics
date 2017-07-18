using Generics_5.Model;

namespace Generics_5.Validator
{
    internal interface IValidator<in TEntity> where TEntity : IEntity
    {
        void Validate(TEntity entity);
    }
}
