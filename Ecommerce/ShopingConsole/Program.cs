using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingConsole
{
    public class Person
    {
        //firstname (string), lastname(string) , birthdate(DateTime), location(string)
        private String FirstName;
        private String LastName;
        private DateTime BirthDate;
        private String Location;

        public string getFirstName()
        {
            return FirstName;
        }

        public void setFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }

        public string getLastName()
        {
            return LastName;
        }

        public void setLastName(string LastName)
        {
            this.LastName = LastName;
        }

        public DateTime getBirthDate()
        {
            return this.BirthDate;
        }

        public void setBirthDate(DateTime BirthDate)
        {
            this.BirthDate = BirthDate;
        }

        public string getLocation()
        {
            return Location;
        }

        public void setLocation(string Location)
        {
            this.Location = Location;
        }

        public Person()
        {

        }


        //firstname (string), lastname(string) , birthdate(DateTime), location(string)
        public Person(string FirstName, string LastName, DateTime BirthDate, string Location)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Location = Location;
        }

        public override string ToString()
        {
            return "First Name :" + FirstName + " Last Name :" + LastName + " Birth Date :" + BirthDate + " Location Area :" + Location;
        }

        ~Person()
        {
            Console.WriteLine("in destructor");
        }
    }

        public class Customer : Person
        {
            //customerId (int), contactNumber(string), email(string)
            private int CustomerId { get; set; }
            private string ContactNumber { get; set; }
            private string Email { get; set; }

            public Customer(string FirstName, String LastName, DateTime BirthDate, string Location, int CustomerId, string ContactNumber, string Email)
            {
                setFirstName(FirstName);
                setLastName(LastName);
                setBirthDate(BirthDate);
                setLocation(Location);

                this.CustomerId = CustomerId;
                this.ContactNumber = ContactNumber;
                this.Email = Email;
            }

            public override string ToString()
            {
                return base.ToString() + " Customer Id:" + CustomerId + " Contact Number :" + ContactNumber + " Email :" + Email;
            }
        }

        public class Product
        {
            //Add auto properites to Product class for ID, Title, Description, UnitPrice (double), Quantity(int)
            public int ProductId { get; set; }
            public string ProductTitle { get; set; }
            public string ProductDescription { get; set; }
            public double UnitPrice { get; set; }
            public int Quantity { get; set; }
            public static int count;


            public Product(int ProductId, string ProductTitle, string ProductDescription, double UnitPrice, int Quantity)
            {
                this.ProductId = ProductId;
                this.ProductTitle = ProductTitle;
                this.ProductDescription = ProductDescription;
                this.UnitPrice = UnitPrice;
                this.Quantity = Quantity;
                count += 1;
            }

            public override string ToString()
            {
                return "Product Id : " + ProductId + " Product Title : " + ProductTitle + " Product Description : " + ProductDescription + " Unit Price : " + UnitPrice + " Quantity : " + Quantity;
            }

        }

        internal class Program
        {
            public static void Main(string[] args)
            {
                Product p1 = new Product(10, "ABC", "Product 1 Description", 10.00, 50);
                Console.WriteLine(Product.count);
                Product p2 = new Product(20, "DEF", "Product 2 Description", 20.00, 100);
                Console.WriteLine(Product.count);
                Product p3 = new Product(30, "GHI", "Product 3 Description", 30.00, 150);
                Console.WriteLine(Product.count);

                Person p4 = new Person();
                Person p5 = new Person("John", "Doe", DateTime.Now, "New York");
				Console.WriteLine(p5.ToString());

				Customer c1 = new Customer("John", "Doe", DateTime.Now, "New York", 1, "123-456-7890", "john@gmail.com");
				Console.WriteLine(c1.ToString());
			}
		}
}
 