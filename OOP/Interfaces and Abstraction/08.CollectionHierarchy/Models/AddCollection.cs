using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class AddCollection : Collection, IAddCollection
    {
        public AddCollection() : base()
        {

        }

        public override int Add(string element)
        {
            int index = _items.Count;

            _items.Add(element);

            return index;
        }
    }
}
