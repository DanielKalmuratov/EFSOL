using System;
using System.Threading;

namespace TaskMutex
{
    class Program
    {
        static Mutex mutexObj = new Mutex();
        static int x = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) {
                Thread thread = new Thread(Start);
                thread.Name = $"Thread name-{i}";
                thread.Start();
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
        public static void Start() {
            mutexObj.WaitOne();
            x = 1;
            for (int i = 0; i < 6; i++) {
                Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
                x++;
                
            }
            mutexObj.ReleaseMutex();
        }
    }
}
