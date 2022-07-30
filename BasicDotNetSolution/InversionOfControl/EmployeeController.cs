using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAccessLayer;
using Entities;

namespace InversionOfControl
{
    public class EmployeeController
    {
        private EmployeeService Empservice;

        public EmployeeController(EmployeeService Ser)
        {
            Empservice = Ser;
        }

        public Employee Get(int Id)
        {
            return Empservice.GetById(Id);
        }

        public List<Employee> Get()
        {
            return Empservice.GetAllEmployees();
        }

        public bool Post(Employee Emp)
        {
            return Empservice.AddEmployee(Emp);
        }

        public bool Put(Employee Emp)
        {
            return Empservice.UpdateEmployee(Emp);
        }

        public bool Delete(int Id)
        {
            return Empservice.DeleteEmployee(Id);
        }


    }
}
