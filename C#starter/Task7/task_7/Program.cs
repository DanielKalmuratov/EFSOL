using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int add(int a, int b)
            {
                return a + b;
            };

            int sub(int a, int b)
            {
                return a - b;
            };

            int div(int a, int b)
            {
                return a / b;
            };
            int mul(int a, int b)
            {
                return a * b;
            };

            Console.WriteLine("результаты операций: сложения-{0}, вычитания-{1}, деления-{2}, умножения-{3} ", add(9, 3), sub(16, 8), div(15, 5), mul(5, 6));



            int Calc()
            {

                Console.WriteLine("Введите сумму: ");
                int summ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите курс: ");
                int rate = Convert.ToInt32(Console.ReadLine());
                return summ * rate;
            };



            double calc = Calc();
            Console.WriteLine(calc);


            string getNum(int num){

                string isSimple = "";
                string isPositiveNum = "";
                string isDivide = "";
                bool sim = true;
                int[] nums = new int[5] { 2, 5, 3, 6, 9 };


                foreach (int i in nums)
                {
                    if (num % i == 0) {
                        string s = i.ToString();
                        isDivide += $"{i}, ";
                    }
                }

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sim = false;
                        break;
                    }
                }
                if (sim)
                {
                    isSimple = "простое";
                }
                else{
                    isSimple = "не простое";
                }


                if (num < 0)
                {
                    isPositiveNum = "отрицательное";
                }
                else {
                    isPositiveNum = "положительное";
                };

                return $"Число - {isSimple}, {isPositiveNum}, делится без остатка на: {isDivide}";
            }


            Console.WriteLine("Введите число для проверки: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string result = getNum(N);
            Console.WriteLine(result);

            Console.ReadKey();


        }
    }
}
