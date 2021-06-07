using System;
using System.IO;

namespace Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream1 = new FileStream("file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //var stream2 = new FileStream("file2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);    
            //var stream3 = new FileStream("file3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            var sw1 = new StreamWriter(stream1);
            sw1.WriteLine("SOME INFORMATION1");
            var sr1 = new StreamReader(stream1);
            Console.WriteLine(sr1.ReadToEnd());
            Console.ReadKey();


            





            stream1.Close();
            //stream2.Close();
            //stream3.Close();

        }
    }
}
