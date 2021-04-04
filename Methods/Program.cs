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
            //var result3 = Add(50);
            //var result2 = Add(20,30);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.ReadLine();

            //int number1 = 10;
            //int number2 = 20;
            //var result = Add2(ref number1, number2); //ref alternatifi out fark ref öncesi değer atama zorunlu.
            
            //Console.WriteLine(Multiply(2,4));
            //Console.WriteLine(Multiply(2, 4,5));

            Console.WriteLine(Add3(1,2,3,4,5));
            Console.ReadLine();
        }

        static int Add(int number1, int number2=10)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add2(ref int number1, int number2)
        {
            number1 = 20;
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

        static int Add3(int number1,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
