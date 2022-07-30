using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Last Name can not be blank");
                }
                else
                {
                    lastName = value;
                }
            }
        }
        public DateTime DateOfBirth { get; set; }

        //Constructor Chaining
        public Person() : this("Ram", "Varama", new DateTime(1965, 3, 6))
        {
            /*this.FirstName = "Ravi";
            this.LastName = "Tambade";
            this.DateOfBirth=new DateTime(1975,8,18);
            */
        }

        public Person(string fName, string lName, DateTime bDate)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.DateOfBirth = bDate;
        }

        //Finalize method is similiar like destructor
        ~Person()
        {
            //Destructor is always  called by Garbage Collector
            //DeInitialzation
        }

        public override string ToString()
        {
            string str = String.Empty;
            str = String.Format(" {0}   {1}  {2}", this.FirstName, this.LastName, this.DateOfBirth);
            // return base.ToString();
            return str;
        }

    }
}
