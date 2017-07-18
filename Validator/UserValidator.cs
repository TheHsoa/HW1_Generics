using System;
using Generics_5.Model;

namespace Generics_5.Validator
{
    internal class UserValidator : IValidator<User>
    {
        private const string ErrorMessage = "Contact with id = {0} have incorrect field \"Name\" = {1}";
        public void Validate(User user)
        {
            if (user.Name == null) throw new Exception(string.Format(ErrorMessage, user.Id, user.Name ?? "null"));
        }
    }
}
