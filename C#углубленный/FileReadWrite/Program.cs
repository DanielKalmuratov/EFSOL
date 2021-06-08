using System;
using System.IO;

namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            try
            {
                using (StreamWriter sr = new StreamWriter(stream))
                {
                    string str = "ahjkghajsdhf";
                    sr.WriteLine(str);
                    sr.Dispose();
                }
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
            }
            
            
            Console.WriteLine("файл создан и записана информация");
            Console.ReadKey();
            try
            {
                
                using (StreamReader sr = new StreamReader(stream))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("информация в файле: {0}",line);
                    }
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            stream.Close();
        }
    }
}
