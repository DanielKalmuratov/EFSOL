using System;

namespace ObseleteClass
{
    class ObselClass
    {
        [Obsolete("Метод устарел")]
        public void FirstMethod()
        {
            Console.WriteLine("Устаревший метод!");
        }

        [Obsolete("Метод не используеться", true)]
        public void SecondMethod()
        {
            Console.WriteLine("Устаревший не используемый метод!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ObselClass instance = new ObselClass();
            instance.FirstMethod();
            //instance.SecondMethod(); Выдает ошибку
        }
    }
}
