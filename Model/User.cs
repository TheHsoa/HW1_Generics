using System.Collections.Generic;
using Generics_5.Validator;

namespace Generics_5.Model
{
    internal class User : IEntity, IValidatable
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Contact> Contacts { get; private set; }

        public User()
        {
            Contacts = new HashSet<Contact>();
        }

        public void Validate()
        {
            this.ValidateUser();
        }
    }
}
