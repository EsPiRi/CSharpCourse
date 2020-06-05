using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            
            ProductManager productManager=new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer=new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Sami";
            customer.LastName = "Sezgin";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Selman", LastName = "Sezgin"
            };

            Console.WriteLine(customer2.FirstName);
            
            Console.ReadLine();
        }
    }

    
}
