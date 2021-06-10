using System;
using System.Collections.Generic;

namespace EngRuDict
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictinary = new Dictionary<dynamic, dynamic>
            {
                { new{key="book" }, new{value="книга" } },
                { new{key="school" }, new{value="школа" } },
                { new{key="computer" }, new{value="компьютер" } },
                { new{key="car" }, new{value="машина" } },
                { new{key="bus" }, new{value="автобус" } },
                { new{key="red" }, new{value="красный" } },
                { new{key="green" }, new{value="зеленый" } },
                { new{key="flower" }, new{value="цветок" } },
                { new{key="phone" }, new{value="телефон" } },
                { new{key="window" }, new{value="окно" } },
            };
            foreach(var item in dictinary) {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
