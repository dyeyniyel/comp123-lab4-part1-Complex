using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_04_lab_12_Complex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);

            Console.WriteLine("Given numbers:");
            Console.WriteLine($"Let c0 be {c0}");
            Console.WriteLine($"Let c1 be {c1}");
            Console.WriteLine($"Let c2 be {c2}");


            Console.WriteLine("\nAdding c1 and c2:");
            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");

            Console.WriteLine("\nSubstracting c1 and c2:");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");

            Complex c3 = c1 + c2; 
            Complex c4 = c1 * c2; //declaring variable for multiplication
            Complex c5 = -c1; //declaring variable for unary


            Console.WriteLine($"\n{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");

            Console.WriteLine("\nShowing that c0 is equal to c1:");
            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");

            Console.WriteLine("\nShowing that c0 is not equal to c2:");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");


            //Display Multiplication of two complex numbers
            Console.WriteLine("\nMultiplying c1 and c2:");
            Console.WriteLine($"{c1} * {c2} = {c4}");

            //Display overloading of Unary operator
            Console.WriteLine("\nChanging the sign of the operand using unary (-) operator:");
            Console.WriteLine($"Negated complex number: -{c0} = {c5}");

            Console.ReadLine();
        }
    }
}
