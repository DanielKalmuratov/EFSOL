using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        class MyDictionary<TKey, TValue> : IEnumerator, IEnumerable
        {
            List<TKey> tkey;
            List<TValue> tvalue;
            private int counter = 0;
          
            public int Count
            {
                get { return this.counter; }
            }

            public MyDictionary()
            {
                this.tkey = new List<TKey>(1);
                this.tvalue = new List<TValue>(1);
                counter = 1;

            }
            public TValue this[TKey key] {
                get { return tvalue[GetInd(key)]; }
            }

            private int GetInd(TKey key)
            {
                for (int itm = 0; itm < tkey.Count; itm++) {
                    if ($"{tkey[itm]}" == $"{key}")
                        return itm;
                };
                return -1;
            }

            int position = -1;

            bool IEnumerator.MoveNext()
            {
                if (position < tvalue.Count - 1)
                {
                    position++;
                    return true;
                }
                ((IEnumerator)this).Reset();
                return false;
            }
            void IEnumerator.Reset()
            {
                position = -1;
            }
            object IEnumerator.Current
            {
                get { return tvalue[position]; }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)this;
            }

            public void Add(TKey key, TValue value)
            {
                tkey.Add(key);
                tvalue.Add(value);
                this.counter = tvalue.Count;
            }



        }
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Book");
            dictionary.Add(2, "student");
            dictionary.Add(3, "food");
            dictionary.Add(4, "water");

            foreach (var item in dictionary) {
                Console.WriteLine($"{item}");
            }
            

            Console.ReadKey();
            
        }
    }
}
