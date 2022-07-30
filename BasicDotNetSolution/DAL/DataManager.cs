using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataManager
    {
        private List<Employee> employees;
        
        public DataManager()
        {
            employees = new List<Employee>();
        }

        public Employee GetById(int Id)
        {
            Employee emp = employees.Find(employee => (employee.EmpId == Id));
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public bool Insert(Employee Emp)
        {
            try
            {
                employees.Add(Emp);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine( e.StackTrace);
                return false;
            }
        }

        public bool Delete(int Id)
        {
           return employees.Remove(GetById(Id));
        }

        public bool Update(Employee Emp)
        {
            Delete(Emp.EmpId);
            return Insert(Emp);
            
        }
    }
}
