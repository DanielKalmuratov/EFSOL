using System;

namespace Delegate
{
    class Program
    {
        delegate int Operation(int x, int z);

        static void Main(string[] args)
        {
            Operation Add = (int x, int y) => x + y;
            Operation Sub = (int x, int y) => x - y;
            Operation Mul = (int x, int y) => x * y;
            Operation Div = (int x, int y) => y != 0 ?  x / y : 0;

            int A = Add(1, 2);
            int S = Sub(54, 8);
            int M = Mul(12,5);
            decimal D = Convert.ToDecimal(Div(12,5));
            Console.WriteLine("Add={0}, Sub={1}, Mul={2}, Div={3}", Add(5,9), S, M, D);
        }
    }
}
