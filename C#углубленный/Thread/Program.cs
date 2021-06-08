using System;
using System.IO;
using System.Threading;

namespace ReadWrite
{
    class Program
    {
        static readonly StreamReader str1 = File.OpenText("file1.txt");
        static readonly StreamReader str2 = File.OpenText("file2.txt");
        static readonly StreamWriter str3 = File.CreateText("file3.txt");
        public static object blok = new object();
        static void Read1()
        {
            string str = str1.ReadToEnd();
            str1.Close();
            Console.WriteLine("{0} - содержимое первого файла", str);
            lock (blok)
            {
                str3.WriteLine(str);
            }
        }
        static void Read2()
        {
            string str = str2.ReadToEnd();
            str1.Close();
            Console.WriteLine("{0} - содержимое второго файла", str);
            lock (blok)
            {
                str3.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            Thread[] array = new Thread[] { new Thread(Read2), new Thread(Read1) };

            for (int i = 0; i < array.Length; i++) {
                array[i].Start();
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Join();
            }
            Console.ReadKey();
            str3.Close();
        }
    }
}
