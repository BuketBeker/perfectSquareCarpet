using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                head:
                    Console.Write("Please enter the square meter of the field:");
                    int field = Convert.ToInt32(Console.ReadLine()); // We take the square meter of the field from the user
                    if (field < 0 || field == 0 )
                    {
                        Console.WriteLine("The field cannot be negative and zero !!"); // The field cannot be negative and zero
                        goto head;
                    }
                    Console.Write("Output: ");
                    calculate(field); // We assign the value we get from the user to the calculate method
                    Console.WriteLine();

                }
                catch (FormatException)
                {
                    Console.WriteLine("The field must be a number!!");
                }
            }

            //Console.ReadKey(); // We use it to keep the output on the screen
        }
        static void calculate(int field) // We find the largest possible perfect squares and print them 
        {
            if (field > 0)
            {
                int i = 0;
                i = (int)Math.Sqrt(field);
                field = field - (i * i);
                Console.Write("{0} ", i * i);
                calculate(field);
            }
        }
    }
}
