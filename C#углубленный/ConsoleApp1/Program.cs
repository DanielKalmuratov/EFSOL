using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            action.BeginInvoke(callback, "some string");

        }
        static void Method()
        {
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }
            Console.WriteLine("Thread id: {0}", Thread.CurrentThread.ManagedThreadId);
        }
        static void CallBack(IAsyncResult asyncResult)
        {
            Console.WriteLine("Thread id: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
