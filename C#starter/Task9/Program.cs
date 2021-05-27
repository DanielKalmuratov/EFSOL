using System;

namespace Task9
{
    class Program
    {
        

        static void MyReverse(int[] array0)
        {
            int j = 0;
            int[] array = new int[3];

            for (int i = array0.Length - 1; i >= 0; i--)
            {
                array[j] = array0[i];
                j++;
            }

            for (int i = 0; i < array0.Length; i++)
            {
                array0[i] = array[i];
                Console.Write("{0} ", array0[i]);
            }

        }
        static void Main(string[] args)
        {
            int[] array0 = new int[3] { 1, 2, 3 };
            //MyReverse(array0);

            int[] SubArray(int[] array, int index, int count)
            {

                int num = index + count;
                int j = 0;
                int[] array0 = new int[count];


                for (int i = index; i < num; i++)
                {
                    if (i >= array.Length)
                    {
                        array0[j] = 1;
                        j++;
                    }
                    else
                    {
                        array0[j] = array[i];
                        j++;
                    };
                };



                for (int i = 0; i < array0.Length; i++)
                {
                    Console.Write(array0[i] + " ");
                }
                return array0;

            }

            SubArray(array0, 0, 9);


            Console.ReadKey();
        }
    }
}
