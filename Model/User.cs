using System.Collections.Generic;

namespace Generics_5.Model
{
    internal class User : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Contact> Contacts { get; private set; }

        public User()
        {
            Contacts = new HashSet<Contact>();
        }
    }
}
