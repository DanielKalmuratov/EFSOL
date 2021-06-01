using System;
using System.Collections;

namespace MonthCollection
{
    public class Months
    {
        public string Month { get; set; }
        public int Days { get; set; }
        public int Num { get; set; }

        public Months(string month, int days, int num)
        {
            Month = month;
            Days = days;
            Num = num;
        }
    }
    class MonthCollection : IEnumerable, IEnumerator
    {

        readonly Months[] months = new Months[12];

        public Months this[int index]
        {
            get { return months[index]; }
            set { months[index] = value; }
        }

        int position = -1;

        bool IEnumerator.MoveNext()
        {
            if (position < months.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get { return months[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
    class Program
    {
        static void Get(int days = 0, int num = 0, string month = "")
        {
            var collection = new MonthCollection();
            collection[0] = new Months("Январь", 31, 1);
            collection[1] = new Months("Февраль", 28, 2);
            collection[2] = new Months("Март", 31, 3);
            collection[3] = new Months("Апрель", 30, 4);
            collection[4] = new Months("Май", 31, 5);
            collection[5] = new Months("Июнь", 30, 6);
            collection[6] = new Months("Июль", 31, 7);
            collection[7] = new Months("Август", 31, 8);
            collection[8] = new Months("Сентябрь", 30, 9);
            collection[9] = new Months("Октябрь", 31, 10);
            collection[10] = new Months("Ноябрь", 30, 11);
            collection[11] = new Months("Декабрь", 31, 12);

            for (int i = 0; i < 12; i++)
            {
                if (collection[i].Days == days || collection[i].Month == month || collection[i].Num == num)
                {
                    Console.WriteLine($"Месяц: {collection[i].Month} , количество дней: {collection[i].Days} , порядковый номер: {collection[i].Num}.");
                }

            }
        }
        static void Main(string[] args)
        {
            Get(31, 0, "");
            Console.ReadKey();

        }
    }
}
