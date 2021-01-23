using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T>
    {
        T[] Array;
        T[] tempArray;

        public MyDictionary()
        {
            Array = new T[0];
        }

        public void Add(T item)
        {
            tempArray = Array;
            Array = new T[Array.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                Array[i] = tempArray[i];
            }
            Array[Array.Length - 1] = item;

        }
        public void Count()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(" {0}", Array[i]);
            }

        }
    }
}
