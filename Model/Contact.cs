namespace Generics_5.Model
{
    internal class Contact : IEntity
    {
        public long Id { get; set; }
        public virtual string Value { get; set; }

        public override string ToString()
        {
            return string.Format("Id={0}, Value={1}", Id, Value);
        }
    }
}
