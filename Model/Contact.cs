using Generics_5.Validator;

namespace Generics_5.Model
{
    internal class Contact : IEntity, IValidatable
    {
        public long Id { get; set; }
        public virtual string Value { get; set; }

        public void Validate()
        {
            new ContactValidator().Validate(this);
        }

        public override string ToString()
        {
            return string.Format("Id={0}, Value={1}", Id, Value);
        }
    }
}
