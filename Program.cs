using System;

namespace _040802022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            var b = -5;
            var c = -6;
            var d = 10;

            var sum = 0;

            bool checkA = a > 0;
            if (checkA)
            {
                sum = sum + a;
            }


            if (b > 0)
            {
                sum = sum + b;
            }

            if (c > 0)
            {
                sum = sum + c;
            }

            if (d > 0)
            {
                sum = sum + d;
            }

            Console.WriteLine(sum);
            

            byte count = 255;
            sbyte sCount = -128;
            ushort ushortCount = 65000;
            int intCount = 2000000000;

            float floatPrice = 56.5f;
            decimal decPrice = 55.5m;
            double price = 55.4;

            char letter = 'A';
            string sentence = "Hello, P132!";

            bool check = -10 > 0;

            Console.WriteLine(check);


            int number;
            
            number = 10;

            number = 30;

            number = -10;
            sum = sum + number;

            Console.WriteLine(sum);

            int num1 = 10;
            int num2 = 35;

            int result = num2 % num1 ;
            ++result;  //result = result + 1;
            result++;
            result--; //result = result-1;

            var n = 3;
            result = 10 - 5 * ++n;

            result += 5; // result = result+5;
            result *= 5; // result = result*5;

            Console.WriteLine(result);
            Console.WriteLine(n);

            result = 20;
            //camel case:
            bool isResultEven = result % 2 == 0;
            //pascal case: bool IsResultPositive = result > 0;
            //skace case: bool is_result_positive = result > 0;
            //kebab case: bool is-result-positive = result > 0;
            Console.WriteLine(!isResultEven);

            bool checkResult = result % 2 == 0 && result > 0;
            result = -21;
            checkResult = result > 0 || result % 2 == 0;

            Console.WriteLine(checkResult);

            checkResult = (result < 0 && result % 2 == 0) || (result > 0 && result % 2 == 1);

            Console.WriteLine(!checkResult);



        }
    }
}
