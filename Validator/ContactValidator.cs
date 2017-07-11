using Generics_5.Model;

namespace Generics_5.Validator
{
    internal class ContactValidator : IValidator<Contact>
    {
        private const string ErrorMessage = "Contact with id = {0} have incorrect field \"Value\" = {1}";
        public bool Validate(Contact contact, out string errorMessage)
        {
            errorMessage = null;

            var validationResult = contact.Value != null;

            if (!validationResult) errorMessage = string.Format(ErrorMessage, contact.Id, contact.Value ?? "null");

            return validationResult;
        }
    }
}
