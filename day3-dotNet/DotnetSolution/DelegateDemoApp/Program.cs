using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoApp
{
    //Function Pointer
    //ISR : Interrupt Service Routine
    //IVT : Interrupt Vector Table

    //What do you mean by Delegate:
    // It a object oriented  managed typsafe function Pointer
    // it a .net object wrapper for function Pointer

    public delegate void TaxHandler(double amount);
    public delegate void dispatcher(string name, string body);


    internal class Program
    {
        // return type is common
        // input type is also common
        // signature input and output variable types are common
       
        static void Main(string[] args)
        {
            double amount = 5000;
            //address of the function will be resolved at compile time
            //Direct Call
           //payIncomeTax(amount);  //Static linking, early binding, compile binding
            //late binding, Dynamic linking, runtim binding
            //Address of function will be resolved at runtime

            //Register address of methods with Delegate instances
            //Callback function Mapping
            //Dispatcher registration with callback function

            //Boilar plate Code
            TaxHandler handler = new TaxHandler(Controller.PayIncomeTax);
            dispatcher emailDispatcher = new dispatcher(Controller.SendEmail);
            dispatcher smsDispatcher = new dispatcher(Controller.SendSMS);

            //handler object acting like Proxy
            //Substitute, agent, broker,
            //Indirect Call
           
            //Invoke Delegate instances

            //Flow of your application
            //process of your application

            handler.Invoke(amount);
            emailDispatcher.Invoke("ravi.tambade@transflower.in", "Hi Ravi");
            smsDispatcher.Invoke("9881735801", "Hi Ravi this imp. message");

            Console.ReadLine();
           
        }
    }
}
