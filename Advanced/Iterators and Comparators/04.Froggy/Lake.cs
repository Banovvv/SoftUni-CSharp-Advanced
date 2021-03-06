using System.Collections;
using System.Collections.Generic;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        public Lake(List<int> stones)
        {
            Stones = stones;
        }

        public List<int> Stones { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Count; i += 2)
            {
                yield return Stones[i];
            }
            for (int i = Stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return Stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
