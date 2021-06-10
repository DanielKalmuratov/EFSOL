using System;
using MyDictionary;

namespace usingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Book");
            dictionary.Add(2, "student");
            dictionary.Add(3, "food");
            dictionary.Add(4, "water");

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item}");
            }


            Console.ReadKey();
        }
    }
}
