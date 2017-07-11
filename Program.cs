using System;
using Generics_5.Data;
using Generics_5.Model;
using Generics_5.Validator;

namespace Generics_5
{
    internal static class Program
    {
        private static void Main()
        {
            var user = new User { Id = 1, Name = "Name" };

            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            var userRepository = GetRepository<User, UserValidator>();
            userRepository.Add(user);

            var contactRepository = GetRepository<Contact, ContactValidator>();
            contactRepository.Add(phone);

            Console.WriteLine(contactRepository.GetById(1));
        }

        private static IRepository<TEntity> GetRepository<TEntity, TValidator>() where TEntity : IEntity where TValidator : IValidator<TEntity>, new()
        {
            return new EntityRepository<TEntity, TValidator>();
        }
    }
}
