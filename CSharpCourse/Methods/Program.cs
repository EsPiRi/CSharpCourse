using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            int result = Add2();

            int number1 = 20;
            int number2 = 100;
            int result2 = Add3(ref number1, number2);
            int result3 = Add4(out number1, number2);

            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);

            Console.WriteLine(Add4(2, 3, 4, 5, 6, 1));
            Console.ReadLine();
        }

        private static void Add()
        {
            Console.WriteLine("Added");
        }

        private static int Add2(int number1 = 20, int number2 = 30)
        {
            return number1 + number2;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //out kullanıldığında method içerisinde
        //değişkene en az bir kere değer ataması yapılması gerekir
        //içeriye girerkenki değeri kullanılmaz.
        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        } 
        
    }
}
