using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Advanced
{
    internal class FixedSizeList<T>
    {
        private readonly List<T> Items;
        public int Capacity  { get; }


        public FixedSizeList(int _capacity)
        {
            Capacity=_capacity;

            Items = new List<T>(_capacity);
        }

        public void Add(T Item) 
        {
            if (Items.Count >= Capacity)
                Console.WriteLine("Can't Add Item Because List Is Full.");
            Items.Add(Item);
        }

        public T Get(int NumOfIndex) 
        {
            if (NumOfIndex < 0 || NumOfIndex >= Items.Count)
                Console.WriteLine("Index is out of range.");

            return Items[NumOfIndex];
        }
    }
}
