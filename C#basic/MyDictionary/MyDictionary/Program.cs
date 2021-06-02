using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        class MyDictionary<TKey, TValue> {
            List<TKey> tkey;
            List<TValue> tvalue;
            private int counter = 0;
            private int current = 0; 
            
            public int Counter
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
            Console.WriteLine(dictionary[1]);
            Console.ReadKey();
            Dictionary<int, string> dfd = new Dictionary<int, string>();
        }
    }
}
