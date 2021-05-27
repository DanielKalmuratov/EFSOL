using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число, которое желаете проверить");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPowerofTwo = (num != 0) && ((num & (num - 1)) == 0 ? true : false);
            Console.WriteLine(isPowerofTwo);
            


            Console.WriteLine ("Введите число, которое желаете проверить");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a & 1) == 0)
            {
                Console.WriteLine("Не четное");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Четное");
                Console.ReadKey();
            };

            int x = 5, y = 10,  z = 15;

            x += y - x+1 * z;
            z = 1-x - y * 5;
            y /= x + 5 % z;
            z = x+1 + y * 5;
            x = y - x+1 * z;

            Console.WriteLine("{0} {1} {2}", x, y, z);



            Console.WriteLine("Ваш трудовой стаж? ");
            int exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваша заработная плата? ");
            int money = Convert.ToInt32(Console.ReadLine());

            if (exp > 0 && exp < 5)
            {
                double res = money * 0.15;
                Console.WriteLine("Ваша премия: {0}$. ", res);

            } else if (exp > 0 && exp < 5) {
                double res = money * 0.10;
                Console.WriteLine("Ваша премия: {0}$. ", res);
            }
            else if (exp >= 5 && exp < 10)
            {
                double res = money * 0.15;
                Console.WriteLine("Ваша премия: {0}$. ", res);
            }
            else if (exp >= 10 && exp < 15)
            {
                double res = money * 0.25;
                Console.WriteLine("Ваша премия: {0}$. ", res);
            }
            else if (exp >= 15 && exp < 20)
            {
                double res = money * 0.35;
                Console.WriteLine("Ваша премия: {0}$. ", res);
            }
            else if (exp >= 20 && exp < 25)
            {
                double res = money * 0.45;
                Console.WriteLine("Ваша премия: {0}$. ", res);
            } else if (exp >= 25) {
                double res = money * 0.5;
                Console.WriteLine("Ваша премия: {0}$. ", res);
            }
                Console.ReadKey();

        }

    }
}
