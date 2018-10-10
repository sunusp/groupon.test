using System.Collections.Generic;

namespace TechnicalTests
{
    public class Sorter
    {
        private IList<T> BubbleSort<T>(IList<T> list, IComparer<T> comparer)
        {
            bool incomplete = true;
            while (incomplete)
            {
                incomplete = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    T x = list[i];
                    T y = list[i + 1]; 
                    if (comparer.Compare(x, y) > 0)
                    {
                        list[i] = y;
                        list[i + 1] = x;
                        incomplete = true;
                    }
                }
            }

            return list;
        }

        public IList<T> BubbleSort<T>(IList<T> list) => BubbleSort(list, Comparer<T>.Default);
        
    }
}
