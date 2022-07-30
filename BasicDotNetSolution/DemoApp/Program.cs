using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InversionOfControl;
using Entities;
using ServiceAccessLayer;
using DAL;

namespace DemoApp
{
    internal class Program
    {
        static void DisplayMenu()
        {

            Console.WriteLine("Discord HR Management Application");
            Console.WriteLine("Enter Option :");
            Console.WriteLine("1: Insert new Employee");
            Console.WriteLine("2: Get  Employee Details");
            Console.WriteLine("3: Display All Employees");
            Console.WriteLine("5:Exit");
        }
        static Employee GetEmployeeFromUI()
        {
            Console.WriteLine("Id");
            
            int id = int.Parse(Console.ReadLine());
            //Console.ReadLine();
            Console.WriteLine("First Name:");
            string fName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lName = Console.ReadLine();
           
            Console.WriteLine("BirthDate");
            Console.WriteLine("Day");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Month");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Year");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter email Id");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Contact No.");
            string cono = Console.ReadLine();

            Employee Emp = new Employee(id,fName, lName, new DateTime(year, month, day),email,cono);
            return Emp;
        }
        static void DisplayAllPeople(List<Employee> employees)
        {
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("All Members");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {

            /*int result = MathEngine.Addition(76, 98);

            Console.WriteLine("Hello World App... Result=" + result);
            Person prn = new Person();
            prn.FirstName = "Manish";
            prn.LastName = "Sharma";
            prn.DateOfBirth = new DateTime(1992, 3, 5);
            Console.WriteLine(prn);*/




            EmployeeController ctr = new EmployeeController(new EmployeeService(new DataManager()));

          
            bool status = true;
            


            while (status)
            {
                DisplayMenu();

                int option = int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        {
                            Employee employee = GetEmployeeFromUI();
                            ctr.Post(employee);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Id");
                            Employee Emp = ctr.Get(int.Parse(Console.ReadLine()));

                            Console.WriteLine(Emp);
                        }
                        break;
                    case 3:
                        {
                            
                            DisplayAllPeople(ctr.Get());
                        }
                        break;
                    case 4:
                        break;
                    case 5:
                        status = false;
                        break;
                }
            }

            Console.WriteLine("Thank you for Visiting PBCreateR Channel......");
            
        }
    }
}
