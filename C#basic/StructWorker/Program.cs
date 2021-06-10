using System;
using System.Collections;


namespace StructWorker
{
    class Program
    {
        struct Worker {
            string fullName;
            string position;
            int startYear;
            public string FullName {

                get 
                { 
                    return fullName; 
                }
            }
            public string Position
            {

                get
                {
                    return position;
                }
            }
            public int Year
            {

                get
                {
                    return startYear;
                }
                set 
                {
                    if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 50)
                    {
                        this.startYear = value;
                    }
                    else {
                        Console.WriteLine("Данные введены не правильно");
                    }
                }
            }
            public int Experience() 
            {
                return DateTime.Now.Year - startYear;
            }
           
            public Worker(string name, string post, int year) 
            {
                this.startYear = DateTime.Now.Year;
                this.fullName = name;
                this.position = post;
                this.Year = year;
            }
        }




        class Company 
        {
            Worker[] workers;
            
            public Company() {
                string name;
                string Position;
                int startYear;
                string getYear;

               

                

                workers = new Worker[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Введите ФИО Сотрудника: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Введите проффесию: ");
                    Position = Console.ReadLine();
                    Console.WriteLine("Введите год начала работы: ");
                    getYear = Console.ReadLine();

                    try
                    {
                        startYear = Convert.ToInt32(getYear);
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine("Данные введены не правильно!");
                        startYear = DateTime.Now.Year;
                    }
                    workers[i] = new Worker(name, Position, startYear);
                }
            }
            public string this[int index] 
            {
                get
                {
                    string answer = ""; 
                    for (int i = 0; i < workers.Length; i++)
                    {
                        if (workers[i].Experience() > index)
                        {
                            answer += "Фамилия работника " + workers[i].FullName + "\n";
                        }

                    }
                    if (answer.Length >= 0)
                    {
                        return answer;
                    }
                    return "Нет сотрудников с таким стажем работы";
                }
            }
        }





        static void Main(string[] args)
        {

            Company comp = new Company();

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(comp[i]);
            }


            
            Console.ReadKey();
        }
    }
}
