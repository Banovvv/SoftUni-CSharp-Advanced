using _08.CollectionHierarchy.Interfaces;
using System.Linq;

namespace _08.CollectionHierarchy.Models
{
    public class AddRemoveCollection : Collection, IAddCollection, IRemoveCollection
    {
        public AddRemoveCollection() : base()
        {

        }

        public string Remove()
        {
            string lastElement = _items.Last();

            _items.RemoveAt(_items.Count - 1);

            return lastElement;
        }
    }
}
