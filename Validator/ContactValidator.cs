using System;
using Generics_5.Model;

namespace Generics_5.Validator
{
    internal class ContactValidator : IValidator<Contact>
    {
        private const string ErrorMessage = "Contact with id = {0} have incorrect field \"Value\" = {1}";

        public void Validate(Contact contact)
        {
            if (contact.Value == null) throw new ArgumentException(string.Format(ErrorMessage, contact.Id, contact.Value ?? "null"));
        }
    }
}
