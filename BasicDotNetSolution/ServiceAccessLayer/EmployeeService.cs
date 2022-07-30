using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace ServiceAccessLayer
{
    public class EmployeeService
    {
        DataManager Manager;

        public EmployeeService(DataManager Mgr)
        {
            Manager = Mgr;
        }

        public Employee GetById(int id)
        {
            return Manager.GetById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return Manager.GetAllEmployees();
        }

        public bool AddEmployee(Employee Emp)
        {
            return Manager.Insert(Emp);
        }

        public bool DeleteEmployee(int Id)
        {
            return Manager.Delete(Id);
        }

        public bool UpdateEmployee(Employee Emp)
        {
            return Manager.Update(Emp);
        }
    }
}
