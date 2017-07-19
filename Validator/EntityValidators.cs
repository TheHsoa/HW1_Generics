using System;
using Generics_5.Model;
using Generics_5.Properties;

namespace Generics_5.Validator
{
    internal static class EntityValidators
    {


        public static void ValidateContact(this Contact contact)
        {
            if (contact.Value == null)
            {
                throw new ArgumentException(string.Format(Resources.NullPropertyException, nameof(contact.Value)), contact.GetType().Name);
            }
        }

        public static void ValidateUser(this User user)
        {
            if (user.Name == null)
            {
                throw new ArgumentException(string.Format(Resources.NullPropertyException, "Name"), user.GetType().Name);
            }
        }

        public static void ValidateEntityNotNull<TEntity>(this TEntity entity) where TEntity : IEntity
        {
            if (entity == null)
            {
                throw new ArgumentNullException(typeof(TEntity).Name);
            }
        }
    }
}
