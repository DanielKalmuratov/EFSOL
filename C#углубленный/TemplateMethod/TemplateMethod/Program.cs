using System;

namespace TemplateMethod
{
    abstract class Education {

        public void TemplateMethod() {
            Enter();
            Study();
            Exams();
            Graduation();
        }

        public abstract void Enter();
        public abstract void Study();
        public abstract void Exams();
        public abstract void Graduation();
    }
    class School : Education {
        public override void Enter()
        {
            Console.WriteLine("Поступление в Школу");
        }
        public override void Study()
        {
            Console.WriteLine("Обучение в Школе");
        }
        public override void Exams()
        {
            Console.WriteLine("Сдача экзаменов.");
        }
        public override void Graduation()
        {
            Console.WriteLine("Выпускной");
        }
    }
    class University : Education {
        public override void Enter()
        {
            Console.WriteLine("Поступление в Универ");
        }
        public override void Study()
        {
            Console.WriteLine("Обучение в Универе");
        }
        public override void Exams()
        {
            Console.WriteLine("Сдача экзаменов.");
        }
        public override void Graduation()
        {
            Console.WriteLine("Выпускной");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            University univer = new University();
            School school = new School();


            school.TemplateMethod();
            Console.WriteLine(new string('-', 20));
            univer.TemplateMethod();
            
            Console.ReadKey();

        }
    }
}
