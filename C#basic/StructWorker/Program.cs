using System;

namespace StructWorker
{
    class Program
    {
        struct Worker {
            string fullName;
            string position;
            int startYear;
        }
        static void Main(string[] args)
        {
            Worker[,] arrOfWorker = new Worker[5,3];
            Console.WriteLine("Please enter StudentId, StudentName, CourseName, Date-Of-Birth");
            string fullname = Console.ReadLine();
            string position = Console.ReadLine();
            c_name = Console.ReadLine();
            
        }
    }
}
