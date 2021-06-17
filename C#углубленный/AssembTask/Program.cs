using System;
using System.Reflection;

namespace AssembTask
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assemb = Assembly.Load("Temprerature");
            dynamic temp = Activator.CreateInstance(assemb.GetType("Temprerature.Temperature"));
            Console.WriteLine("{1}°C = {0}°F",temp.ToFahrenheit(5m), 5);
            Console.ReadLine();
        }
    }
}
