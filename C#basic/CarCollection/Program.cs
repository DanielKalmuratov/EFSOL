using System;

namespace CarCollection
{
    interface ICar
    {
        string Name { get; set; }
        int Year { get; set; }

    }
    class CarCollection<T> where T: ICar, new()
    {
        private T[] Cars;
        private int current = 0;
        public int Count { get { return Cars == null ? 0 : Cars.Length; } }

        public void Add(string Name, int Year)
        {
            if (Cars == null)
                Cars = new T[1];
            if (Cars.Length == current)
                Array.Resize(ref Cars, Cars.Length + 1);
            Cars[current] = new T() { Name = Name, Year = Year };
            current++;
        }

        public T this[int Index]
        {
            get { return Cars[Index]; }
            set { Cars[Index] = value; }
        }
    }
    class Car : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"Car : {Name} {Year}";
        }

    }
        class Program
    {
        static void Get<T>() where T : ICar, new()
        {
            var collection = new CarCollection<T>();
            collection.Add("AUDI", 2021);
            collection.Add("BMW", 2012);

            Console.WriteLine("Collection length: {0}", collection.Count);
            for (int i = 0; i < collection.Count; i++)
                Console.WriteLine("[{0}]: {1}",i ,collection[i]);
        }
        static void Main(string[] args)
        {

                Get<Car>();
                Console.ReadKey();
        }
    }
}
