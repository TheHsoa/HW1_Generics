using Generics_5.Model;

namespace Generics_5.Validator
{
    internal class UserValidator : IValidator<User>
    {
        private const string ErrorMessage = "Contact with id = {0} have incorrect field \"Name\" = {1}";
        public bool Validate(User user, out string errorMessage)
        {
            errorMessage = null;

            var validationResult = user.Name != null;

            if (!validationResult) errorMessage = string.Format(ErrorMessage, user.Id, user.Name ?? "null");

            return validationResult;
        }
    }
}

