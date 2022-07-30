using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Person
    {
        public int EmpId { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        protected double BasicSaslary { get; set; }
        protected double DailyAllowance { get; set; }
        protected int Attendance { get; set; }
        public Employee() : base()
        {


        }
        public Employee(int id, string fName, string lName,
                DateTime bDate, string email, string contactNumber)
                : base(fName, lName, bDate)
        {
            EmpId = id;
            Email = email;
            ContactNumber = contactNumber;

        }

        public virtual double ComputePay()
        {
            double salary = BasicSaslary + DailyAllowance * Attendance;
            return salary;
        }
        public override string ToString()
        {
            return this.EmpId + " " + base.ToString() +" "+this.Email + " " + this.ContactNumber;
        }
    }
}
