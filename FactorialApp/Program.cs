using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number to find it's factorial");
                var isNumeric = int.TryParse(Console.ReadLine(), out int num);
                if (isNumeric)
                {
                    int fact = Factorial(num);
                    Console.WriteLine("Factorial of " + num.ToString() + " is " + fact.ToString());
                    Console.WriteLine("Press any Key to exit");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter valid number");
                    Console.WriteLine("Press any Key to exit");
                    Console.ReadKey();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Message : " + Environment.NewLine + ex.Message);
                Console.WriteLine("Press any Key to exit");
                Console.ReadKey();
            }           
        }
        public static int Factorial(int num)
        {
            int fact = 0;
            if (num > 0)
            {
                fact = 1;
                for (int i = num; i > 0; i--)
                {
                    fact = fact * i;
                }
            }

            return fact;
        }
    }
}
