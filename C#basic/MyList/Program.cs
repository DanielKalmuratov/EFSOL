using System;

namespace MyList
{
   
    public class MyList<T>
    {
        private T[] array;
        private int current = 0;
        public int Count { get { return array == null ? 0 : array.Length; } }
        public void Add(T value)
        {
            if (array == null)
                array = new T[1];
            if (array.Length == current)
                Array.Resize(ref array, array.Length + 1);
            array[current] = value;
            current++;
        }
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> array = new MyList<int>();
            array.Add(1);
            array.Add(3);
            Console.WriteLine("Индекс [0] = " + array[0]);
            Console.WriteLine("Индекс [1] = " + array[1]);
            Console.WriteLine("Array.Length: " + array.Count);
            Console.ReadKey();
        }
    }
}
