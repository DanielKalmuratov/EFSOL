using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Method1() {
            Console.WriteLine("Method 1");
            for (int i = 0; i < 10; i++) {
                Thread.Sleep(200);
                Console.Write("\nCount method1: {0} ", i);
            }
        }
        static void Method2()
        {
            Console.WriteLine("Method 2");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("\nCount method2: {0} ", i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main method start!");
            Parallel.Invoke(Method1, Method2);
            Console.WriteLine("\nMain Method finish!");
            Console.ReadKey();
        }
        
    }
}
