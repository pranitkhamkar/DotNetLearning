using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SalesEmployee : Employee
    {
        public double Incentive { get; set; }
        public SalesEmployee() : base()
        {

        }
        public SalesEmployee(int id, string fName, string lName,
                DateTime bDate, string email, string contactNumber, double incentive)
                : base(id, fName, lName, bDate, email, contactNumber)
        {
            this.Incentive = incentive;

        }
        public override double ComputePay()
        {
            return base.ComputePay() + Incentive;
        }

        public override string ToString()
        {
            return base.ToString() + " Incentive = " + Incentive;
        }
    }
}
