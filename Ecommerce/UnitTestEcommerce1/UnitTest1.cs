using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopingConsole;
using System;


namespace UnitTestEcommerce1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestPerson()
		{
			//arrange
			string FirstName = "John";
			string LastName = "Doe";
			DateTime BirthDate = new DateTime(1980, 1, 1);
			string Location = "London";

			string expectedOutput = "First Name :John Last Name :Doe Birth Date :01-01-1980 00:00:00 Location Area :London";

			// application uder test
			Person p = new Person(FirstName, LastName, BirthDate, Location);

			//act
			Console.WriteLine(p.ToString());
			string actualOutput = p.ToString();

			//assert
			Assert.AreEqual(expectedOutput, actualOutput);

		}

		[TestMethod]
		public void TestCustomer()
		{
			// arrange 
			string FirstName = "John";
			string LastName = "Doe";
			DateTime BirthDate = new DateTime(1980,1,1);
			string Location = "London";
			int CustomerId = 1;
			string ContactNumber = "123-456-7890";
			string Email = "john@gmail.com";
			/*
			string expectedOutout = "First Name :John Last Name:Doe Birth Date:01-01-1980 00:00:00 Location Area :London Customer Id :1 Contact Number :123-456-7890 Email :john@gmail.com";
			*/

			
			string expectedOutout = "First Name :John Last Name :Doe Birth Date :01-01-1980 00:00:00 Location Area :London Customer Id:1 Contact Number :123-456-7890 Email :john@gmail.com";

			//application under test
			Customer c1 = new Customer(FirstName, LastName, BirthDate, Location, CustomerId, ContactNumber, Email);

			//act
			Console.WriteLine(c1.ToString());
			string actualOutput = c1.ToString();

			//assert 
			Assert.AreEqual(expectedOutout, actualOutput);
		}


		[TestMethod]
		public void TestProduct()
		{
			Product p1 = new Product(10, "ABC", "Product 1 Description", 10.00, 50);
			Console.WriteLine(Product.count);
			Product p2 = new Product(20, "DEF", "Product 2 Description", 20.00, 100);
			Console.WriteLine(Product.count);
			Product p3 = new Product(30, "GHI", "Product 3 Description", 30.00, 150);
			Console.WriteLine(Product.count);

		}

	}
}
