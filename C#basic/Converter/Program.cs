using System;

namespace Converter
{

    public class Converter
    {
        public double USD;
        public double EUR;
        public double RUB;

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }


        public double ConvertToUsd(double value)
        {
            return value / USD;
        }

        public double ConvertToEur(double value)
        {
            return value / EUR;
        }

        public double ConvertToRub(double value)
        {
            return value / RUB;
        }

        public double ConvertFromUsd(double value)
        {
            return USD * value;
        }

        public double ConvertFromEur(double value)
        {
            return EUR * value;
        }

        public double ConvertFromRub(double value)
        {
            return RUB * value;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var converter = new Converter(83.4, 101.2, 1.12);

            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Конвертировать в KGS");
            Console.WriteLine("2: Конвертировать с KGS");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }

            Console.WriteLine("Продолжить?");
            Console.WriteLine("1: да");
            Console.WriteLine("2: нет");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Choose option:");
                    Console.WriteLine("1: Конвертировать в KGS");
                    Console.WriteLine("2: Конвертировать с KGS");

                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            ConvertTo(converter);
                            break;
                        case 2:
                            ConvertFrom(converter);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Спасибо!!!");
                    break;
            }
            Console.ReadKey();
        }

        private static void ConvertTo(Converter currencyConverter)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1: Конвертировать с USD");
            Console.WriteLine("2: Конвертировать с EUR");
            Console.WriteLine("3: Конвертировать с RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertFromRub(input));
                    break;
            }
        }

        private static void ConvertFrom(Converter currencyConverter)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1: Конвертировать в USD");
            Console.WriteLine("2: Конвертировать в EUR");
            Console.WriteLine("3: Конвертировать в RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertToRub(input));
                    break;
            }

        }
    }

}

