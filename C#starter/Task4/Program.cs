using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
			// Машинная математика

			double pi = 3.141592653;
			double e = 2.7182818284;
			Console.WriteLine(pi);
			Console.WriteLine(" ");
			Console.WriteLine(e);

			string first = "\nмоя строка 1";
			string second = "\tмоя строка 2";
			string third = "\aмоя строка 3";
			Console.WriteLine(first);
			Console.WriteLine(second);
			Console.WriteLine(third);

			// Переменные и типы данных

			int x = 10, y = 12, z = 3;
			x += y - x++ * z;
			Console.WriteLine(x);
			z = --x - y * 5;
			Console.WriteLine(z);
			y /= x + 5 % z;
			Console.WriteLine(y);
			z = x++ + y * 5;
			Console.WriteLine(z);
			x = y - x++ * z;
			Console.WriteLine(x);

			int a = 5, b = 8, c = 9;
			int sum = a + b + c;
			int mid = sum / 3;
			Console.WriteLine("Среднее арифметическое: " + mid);

			double PI = 3.14;
			double r = 5;

			double circleArea = PI * r * r;
			Console.WriteLine("Circle area is: " + circleArea);

			double R = 2;
			double h = 3;
			double sqr = R * R;
			double res1 = PI * sqr * h;
			Console.WriteLine("Объем V цилиндра: " + res1);
			double res2 = 2 * PI * R * (R + h);
			Console.WriteLine("Площадь S поверхности: " + res2);



			//Условные конструкции

			Console.WriteLine("Operand 1 ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Operand 2 ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Выберите операцию: +,-,*,/ ");
			char sign = Convert.ToChar(Console.ReadLine());

			switch (sign)
			{
				case '+':
					Console.WriteLine("Your result " + (num1 + num2));
					break;
				case '-':
					Console.WriteLine("Your result = " + (num1 - num2));
					break;
				case '*':
					Console.WriteLine("Your result= " + (num1 * num2));
					break;
				case '/':
					Console.WriteLine("Your result= " + (num1 / num2));
					break;
			}


			Console.WriteLine("Type the number from 0-100 ");
			int num3 = Convert.ToInt32(Console.ReadLine());

			if (num3 >= 0 && num3 <= 14)
			{
				Console.Write("Your number is in: [0 - 14]");
			}
			else if (num3 >= 15 && num3 <= 35)
			{
				Console.Write("Your number is in: [15 - 35]");
			}
			else if (num3 >= 36 && num3 <= 50)
			{
				Console.Write("Your number is in: [36 - 50]");
			}
			else if (num3 >= 51 && num3 <= 100)
			{
				Console.Write("Your number is in: [50 - 100]");
			}


			Console.ReadKey();
		}
    }
}
