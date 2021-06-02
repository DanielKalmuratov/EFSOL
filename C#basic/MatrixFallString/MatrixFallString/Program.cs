using System;

namespace MatrixFallString
{
    class Program
    {
        class FallenString {
            private char[,] str { get; }
            private int posX { get; }
            private int posY { get; }

            public FallenString(int xpos, int ypos, char[,] arr) {
                posX = xpos;
                posY = ypos;
                str = arr;
            }

            public void Fall() {
                
                Random rnd = new Random();
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        str[i, j] = (char)rnd.Next(0x0410, 0x44F);
                    }
                }

                for (int i = 0; i < posY ; i++) {
                    for (int j = 0; j < posY; j++) { 
                        str[j,i] = (char)rnd.Next(0x0410, 0x44F);
                    }
                }

            }

        }
        static void Main(string[] args)
        {
            //char[,] str = new char[15, 15];
            //int posY = 15;
            //int posX = 15;


            //Random rnd = new Random();

            //for (int i = 0; i < posY; i++)
            //{
            //    for (int j = 0; j < posY; j++)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        str[j, i] = (char)rnd.Next(0x0410, 0x44F);
            //        Console.Write(str[j,j]);
            //    }
            //}


            //Console.ReadKey();








            Random rnd = new Random();
            for (; ; )
            {

                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 8; j++)
                    {

                        if (rnd.Next(10) > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        int n = rnd.Next(2);
                        Console.Write(n);
                        if (j != 7)
                        {
                            Console.Write("");
                        }
                    }
                }
            }




        }
    }
}
