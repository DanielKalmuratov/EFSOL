using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {


            static void GetPayment(int credit, int count){

                
                Console.WriteLine("Введите платеж: ");
                int payment = Convert.ToInt32(Console.ReadLine());

                
                int overpay = 0;
                int debit = 0;
                


                if (payment > credit || payment == credit)
                {
                    overpay = payment - credit;
                    Console.WriteLine("Кредит погашен");
                    if (overpay > 0)
                    {
                        Console.WriteLine("Переплата составила " + overpay + "гривень");
                    }  
                }
                else
                {
                    if (count > 1)
                    {
                        count = count - 1;
                        debit = credit - payment;
                        Console.WriteLine("Задолженность составляет " + debit + "гривень." + "Кредит нужно закрыть за " + count + " раз.");

                        GetPayment(debit, count);
                    }
                    else {
                        Console.WriteLine("Задолженность составляет " + credit + "гривень." + "Вы не успели в срок закрыть долг!");
                    }
                   
                }
                
            }

            GetPayment(700, 7);
            Console.ReadKey();


        }
    }
}
