using System;

namespace Temprerature
{
    public class Temperature
    {
        public decimal ToFahrenheit(decimal temperature)
        {
            return temperature * 9 / 5 + 32;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
