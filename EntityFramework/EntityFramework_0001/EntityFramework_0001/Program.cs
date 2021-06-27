using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_0001
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbEntities myDbEntities = new MyDbEntities();
            List<Employee> employees = myDbEntities.Employee.ToList();
            List<EmpFamily> empFam = myDbEntities.EmpFamily.ToList();
            List<EmployeeInfo> empInfo = myDbEntities.EmployeeInfo.ToList();

            foreach (Employee emp in employees) 
            {
                Console.WriteLine("Name:       {0}", emp.FirstName);
                Console.WriteLine("Phone:      {0}", emp.PhoneNumber);
                Console.WriteLine("------------------------------------------------");
            }
            foreach (EmpFamily empFamily in empFam)
            {
                Console.WriteLine("Birth date: {0}", empFamily.Birthdate);
                Console.WriteLine("Married:    {0}", empFamily.Married);
                Console.WriteLine("Address:    {0}", empFamily.Address1);
                Console.WriteLine("------------------------------------------------");
            }
            foreach (EmployeeInfo empInf in empInfo)
            {
                Console.WriteLine("Salary:     {0}", empInf.Salary);
                Console.WriteLine("Position:   {0}", empInf.Position);
                Console.WriteLine("------------------------------------------------");
            }


            Console.ReadKey();

            
        }
    }
}
