using _08.CollectionHierarchy.Interfaces;
using System.Linq;

namespace _08.CollectionHierarchy.Models
{
    public class MyList : Collection, IMyList
    {
        public MyList() : base()
        {

        }

        public int Used => _items.Count;

        public string Remove()
        {
            string lastElement = _items.First();

            _items.RemoveAt(0);

            return lastElement;
        }
    }
}
