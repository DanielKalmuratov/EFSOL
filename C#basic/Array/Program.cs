using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            int big = 0;
            int mid = 0;
            int small = 9915;
            int[] array;
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            array = new int[n];
            for (int i = 0; i < n; i++) {
                array[i] = rnd.Next(1,99);
            }
            
            for (int j = 0; j < array.Length; j++) {

                Console.Write(array[j] + " ");
                sum += array[j];
                if (small > array[j]) {
                    small = array[j];
                }
                if (big < array[j]) {
                    big = array[j];
                }
                mid = sum / n;
            }
            Console.Write("\n");
            Console.WriteLine($"Сумма всех чисел: {sum},\nсреднее арифметическое: {mid}, \nсамое большое число: {big}, \nсамое маленькое число: {small}");
            Console.ReadKey();
        }
    }
}
