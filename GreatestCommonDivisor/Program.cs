using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plese enter a second integer");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int number2 = int.Parse(Console.ReadLine());
            int gcd = 1;

            for (int i = 1; i <= number1 && i <= number2; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine("GCD of {0} and {1} is {2}", number1, number2, gcd);
        }
    }



    // GreatestCommonDivisor use recursive
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will ask you for two numbers. I will calculate the greatest common divisor");
            Console.WriteLine("Please enter a second integer");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            int number2 = int.Parse(Console.ReadLine());

            int answer = gcd(number1, number2);

            Console.WriteLine("The gcd of {0} and {1} is {2}", number1, number2, answer);
            Console.ReadLine();
        }
        static int gcd(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                Console.WriteLine("Not yet {0} / {1} has a reminder of {2}", n1, n2, n1 % n2);
                return gcd(n2, n1 % n2);
            }
        }
    }*/
}
//https://www.youtube.com/watch?v=jtWihq7jc58&ab_channel=ProgrammingProfessor GreatestCommonDivisor use recursive
