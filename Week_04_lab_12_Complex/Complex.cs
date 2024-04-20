using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_04_lab_12_Complex
{
    public class Complex
    {
        //properties of Complex class
        public int Real { get; }
        public int Imaginary { get; }
        public double Argument => Math.Atan2(Imaginary, Real); //calculated property. equivalent to tan^(-1)⁡〖(Imaginary⁄Real)〗]. 
        public double Modulus => Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2)); //calculated property. Equivalent to √(〖Real〗^2+〖Imaginary〗^2 )]. 
        public static Complex Zero { get; } = new Complex(0, 0); //factory property to create a complex number with both real and imaginary parts set to 0.

        //constructor
        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        //returns the object as ordered pairs
        public override string ToString()
        {
            return $"({Real},{Imaginary})";
        }

        //Operator Overloading for adding the two numbers
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        //Operator Overloading for subtracting the two numbers
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        //Operator Overloading for equal equal operator
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            bool realEqualTo = lhs.Real == rhs.Real;
            bool imaginaryEqualTo = lhs.Imaginary == rhs.Imaginary;
            return realEqualTo && imaginaryEqualTo;
        }
        //Operator Overloading for not equal operator
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            bool isEqual = lhs == rhs;
            return !isEqual;
        }

        //additional tasks

        //operator overloading for multiplication.  <a, b> * <c, d> = <ac-bd, ad+bc>. 
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            int real = (lhs.Real * rhs.Real) - (lhs.Imaginary * rhs.Imaginary); //ac-bd
            int imaginary = (lhs.Real * rhs.Imaginary) + (lhs.Imaginary * rhs.Real); //ad+bc
            return new Complex(real, imaginary);
        }
        //Operator Overloading for unary - operator.  -<a, b> = <-a, -b>
        public static Complex operator -(Complex complexUnary)
        {
            return new Complex(-complexUnary.Real, -complexUnary.Imaginary);
        }
    }
}
