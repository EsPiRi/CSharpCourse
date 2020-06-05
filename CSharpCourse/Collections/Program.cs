using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string,string> dictionary=new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");


            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                    Console.Write(item.Key+": ");
                    Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));
            //Console.WriteLine(cities.Contains("Adana"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Sami" });
            //customers.Add(new Customer { Id = 2, FirstName = "Sezgin" });

            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Sami"},
                new Customer {Id = 2, FirstName = "Sezgin"}
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Ahmet"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Ali"},
                new Customer {Id = 5, FirstName = "Veli"}
            });

            Console.WriteLine(customers.Contains(customer2));
            //customers.Clear();

            Console.WriteLine("Index: {0}", customers.IndexOf(customer2));
            customers.Add(customer2);
            Console.WriteLine("Last Index: {0}", customers.LastIndexOf(customer2));

            customers.Insert(0, customer2);

            customers.Remove(customer2);

            //RemoveAll'da predicate yollamak gereklidir.
            customers.RemoveAll(c => c.FirstName == "Ahmet");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');


            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
