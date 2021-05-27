using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Треугольник");
            int num = 0;

            for (int i = 0; i < 9; i++) {
                
                for (int j = 0; j < 9; j++)
                {
                    if (j <= num) {
                        Console.Write('*');
                    }
                    else {
                        Console.Write(' ');
                    };
                    

                }
                Console.Write("\n");
                num++;
            };

            Console.WriteLine("Прямоугольник");
            num = 0;

            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
                num++;
            };


            Console.WriteLine("Ромб");

            int n = 10;
            int p = n-1;
            for (int i = 0; i < n; i++, p--)
                {
                    for (int j = 0; j < p; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int m = 0; m < i * 2; m++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            n = 10;
            p = 0;
            for (int i = 0; i < n; i++, p++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int m = 19; m > i * 2; m--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }



            //Имеется N клиентов, которым компания производитель должна доставить товар. Сколько существует
            //возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных
            //вариантов доставки товара. Для решения задачи, используйте факториал N!, рассчитываемый с
            //помощью цикла do -while.

            int N = 5;
            int factorial = 1;
            do{

                for (int i = 2; i <= N; i++) 
                {
                    factorial = factorial * i;
                    
                }         
                Console.WriteLine("Возможные варианты доставки: {0}", factorial);
                factorial = 1;
                N--;

            } while (N>0);

            Console.ReadKey();
        }
    }
}
