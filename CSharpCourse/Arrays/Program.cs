using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = new String[3];
            students[0] = "Sami";
            students[1] = "Gülsüm";
            students[2] = "Salih";


            string[] students2 = { "Engin", "Derin", "Salih" };
            

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            string[,] regions=new string[5,3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("********");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
