using System.Collections.Generic;

namespace _08.CollectionHierarchy.Models
{
    public abstract class Collection
    {
        private readonly int _size = 100;
        protected List<string> _items;

        public Collection()
        {
            _items = new List<string>(_size);
        }

        public virtual int Add(string element)
        {
            _items.Insert(0, element);

            return 0;
        }
    }
}
