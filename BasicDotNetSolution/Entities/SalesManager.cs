using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class SalesManager : SalesEmployee
    {
        public double Bonus { get; set; }
        public SalesManager() : base()
        {

        }

        public SalesManager(int id, string fName, string lName,
                DateTime bDate, string email, string contactNumber, double incentive, double bonus)
                : base(id, fName, lName, bDate, email, contactNumber, incentive)
        {
            this.Bonus = bonus;
        }
        public override double ComputePay()
        {
            return base.ComputePay() + Bonus;

        }

        public override string ToString()
        {
            return base.ToString() + "Bonus =" + Bonus;
        }
    }
}
