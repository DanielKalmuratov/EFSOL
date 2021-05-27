using System;

namespace Print
{
    static class PrintConsole {
        public enum Colors { Yellow = 14, Green = 10, Red = 12 }
        public static void Print(string stroka, Colors color) {

            Console.ForegroundColor = (ConsoleColor)Convert.ToInt32(color); ;
            Console.WriteLine(stroka);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type text");
            string str = Console.ReadLine();
            Console.WriteLine("Type color of text\n1: Yellow\n2: Green\n3: Red");
            int color = Convert.ToInt32(Console.ReadLine());
            
            switch (color) {
                case 1:
                    PrintConsole.Print(str, PrintConsole.Colors.Yellow);
                    break;
                case 2:
                    PrintConsole.Print(str, PrintConsole.Colors.Green);
                    break;
                case 3:
                    PrintConsole.Print(str, PrintConsole.Colors.Red);
                    break;
                default:
                    Console.WriteLine("You didnt choose color");
                    break;
            }
            Console.ReadKey();
        }

        
    }
}
