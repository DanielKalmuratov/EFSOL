using System;
using System.Collections;
using System.Collections.Specialized;

namespace Compare
{
    class Program
    {
        public class Car { 
            public string name { set; get; }

            public Car(string n) {
                this.name = n;
            }

            public override int GetHashCode()
            {
                return name.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                var nCar = obj as Car;
                if (nCar == null) {
                    return false;
                }
                return nCar.name == name;
            }
        }


        static void Main(string[] args)
        {
            var cars = new OrderedDictionary();
            var car1 = new Car("Audi");
            var car2 = new Car("Mazda");
            cars.Add(car1, "626");
            cars.Add(car2, "A4");
            
            try 
            {
                cars.Add(car1, "fds");
            } 
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Console.Write("Ошибка одинаковых ключей");
            }

            foreach (DictionaryEntry item in cars)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
