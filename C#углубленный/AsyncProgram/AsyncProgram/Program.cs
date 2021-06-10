using System;
using System.Threading;

namespace AsyncProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Thread id: {0}", Thread.CurrentThread.ManagedThreadId);
            Action action = new Action(Method);
            AsyncCallback callback = new AsyncCallback(CallBack);

            Console.ReadKey();
            action.BeginInvoke(callback, new object());
            
        }
        static void Method() {

            for (int i = 0; i < 100; i++) {
                Thread.Sleep(1000);
                Console.Write("2");
            }
            Console.WriteLine("Thread id: {0}", Thread.CurrentThread.ManagedThreadId);

        }
        static void CallBack(IAsyncResult asyncResult)
        {
            Console.WriteLine("Thread id: {0}",Thread.CurrentThread.ManagedThreadId);
        }
    }
}
