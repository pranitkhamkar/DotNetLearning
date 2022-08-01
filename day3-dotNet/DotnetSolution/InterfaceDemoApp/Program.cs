using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoApp
{
    public interface IDetails
    {
        void show();
    }
    public interface ICustomerDetails:IDetails
    {
        void ShowCustomerProfile();
    }

    public interface IOrderDetails
    {
        void ShowOrderHistory();
        void Display();
       
    }

    public interface IPaymentDetails
    {
        void Display();

    }

    public class CustomerDashBoard:ICustomerDetails,IOrderDetails,IPaymentDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }


        //Explicit Interface Inheritance
        void IOrderDetails.Display()
        {
            Console.WriteLine("Showing Customer  Order Details Details");

        }

        void IPaymentDetails.Display()
        {
            Console.WriteLine("Showing Customer  Payment Details");
           
        }

        public void show()
        {
            Console.WriteLine("Customer Personal Information");
        }

        public void ShowCustomerProfile()
        {
            Console.WriteLine("Customer Profile Details Information");
        }

        public void ShowOrderHistory()
        {
            Console.WriteLine("Customer existing orders  Information");
        }
    }


    public class Stack:ICloneable
    {
        int size;
        int[] sArr;


        public Stack(int size)
        {
            this.sArr = new int[size];
            for(int i = 0; i < size; i++)
            {
                this.sArr[i] = i+9;
            }
            this.size = this.sArr.Length;
        }

        public object Clone()
        {
            //Deep Copy
            Stack newCopyStack = new Stack(this.size);
            // newCopyStack.sArr = this.sArr;  //Shallow Copy
            this.sArr.CopyTo(newCopyStack.sArr, 0);
            return newCopyStack;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDashBoard dashboard = new CustomerDashBoard();

            dashboard.show();
            dashboard.ShowCustomerProfile();
            dashboard.ShowOrderHistory();
           
            IPaymentDetails details = dashboard;
            details.Display();

            IOrderDetails orderDeatils = dashboard;
            orderDeatils.Display();




            Stack stack1 = new Stack(4);
            Stack stack2 = (Stack)stack1.Clone();  //referce Copy


            Stack stack3 = (Stack)stack2.Clone();
           

        }
    }
}
