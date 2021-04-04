using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello Word!");
            bool condition = true; // boolean value is true/false
            char character = 'A'; 
            int number1 = 2147483647; // int max value
            long number2 = 9223372036854775807; // long max value
            int number3 = -2147483648;  // int min value
            long number4 = -9223372036854775808; // long min value
            short number5 = 32767; // short max value
            short number6 = -32768; // short min value
            byte number7 = 255; // byte range 0-255
            double number8 = 10.4;
            decimal number9 = 10.4m;
            var number10 = 181;
            number10 = 'A';

            Console.WriteLine("Interger max value is {0}", number1);
            Console.WriteLine("Interger min value is {0}", number3);
            Console.WriteLine("Long max value is {0}", number2);
            Console.WriteLine("Long min value is {0}", number4);
            Console.WriteLine("Short max value is {0}", number5);
            Console.WriteLine("Short min value is {0}", number6);
            Console.WriteLine("Byte max value is {0}", number7);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine("Double number is {0}", number8);
            Console.WriteLine("Decimal number is {0}", number9);
            Console.WriteLine("Number10 is {0}", number10);
            Console.WriteLine((int)Days.carsamba);
            Console.ReadLine();
        }
    }
    enum Days
    {
        pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar
    }
}
