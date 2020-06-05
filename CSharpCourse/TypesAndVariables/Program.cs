using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        enum Days
        {MONDAY,TUESDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY,SUNDAY

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadLine();
            char character = 'A';
            string city = "Ankara";

            bool condition = false;

            byte byteNumber = byte.MaxValue;
            short shortNumber = short.MaxValue;
            int intNumber = int.MaxValue;
            long longNumber = long.MaxValue;

            double doubleNumber = 10.4;
            decimal decimalNumber = 10.4m;
            float floatNumber = 10.4f;

            var varNumber = 10.4f;//ilk değeri ne verildiyse sonradan tip olarak değiştirilemez

            //Console.WriteLine("Numbers are: {0} {1} {2} {3}", byteNumber, shortNumber, intNumber, longNumber);
            Console.WriteLine("Character is: {0}", character);

            Console.WriteLine("Byte Number is: {0}", byteNumber);
            Console.WriteLine("Short Number is: {0}", shortNumber);
            Console.WriteLine("Integer Number is: {0}", intNumber);
            Console.WriteLine("Long Number is: {0}", longNumber);
            Console.WriteLine("Double Number is: {0}", doubleNumber);
            Console.WriteLine("Decimal Number is: {0}", decimalNumber);
            Console.WriteLine("Float Number is: {0}", floatNumber);

            Console.WriteLine(Days.FRIDAY);
            Console.WriteLine((int)Days.FRIDAY);

            Console.WriteLine("Character is: {0}", (int)character);
            Console.ReadLine();


        }
    }
}
