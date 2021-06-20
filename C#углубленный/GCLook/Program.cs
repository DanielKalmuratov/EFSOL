using System;
using System.Threading;

namespace GCLook
{
    class LookResource
    {
        readonly int limit;

        public LookResource(int limit)
        {
            this.limit = limit;
        }

        bool IsOverLimit()
        {
            return this.limit < GC.GetTotalMemory(false);
        }

        public void ExceptWarning(object err)
        {
            if (IsOverLimit())
            {
                Console.WriteLine("{0}", err);
            }
        }

    }

    class LargeObject
    {
        int[] array = new int[50000000]; 

        public void Method(int i)
        {
            Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main()
        {

            Timer timer = new Timer(new LookResource(10000000).ExceptWarning, "Warning", 0, 500);

            LargeObject[] array = new LargeObject[800];

            for (int i = 0; i < array.Length; i++)
            {
                new LargeObject().Method(i);
            }

            Console.ReadKey();
        }
    }
}
