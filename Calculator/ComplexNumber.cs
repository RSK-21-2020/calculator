using System;
using System.Security.Cryptography;

namespace Calculator
{
    public class ComplexNumber
    {
        public Double real;
        public Double imagine;
        
        public ComplexNumber(Double re, Double im)
        {
            this.real = re;
            this.imagine = im;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real + b.real, a.imagine + b.imagine);
        }
        
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real - b.real, a.imagine - b.imagine);
        }
        
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real * b.real - a.imagine * b.imagine, a.real * b.imagine + a.imagine * b.real);
        }
        
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            var a1 = a.real;
            var b1 = a.imagine;
            var a2 = b.real;
            var b2 = b.imagine;
            return new ComplexNumber((a1 * a2 + b1 * b2)/(a2 * a2 + b2 * b2), (a2 * b1 - a1 * b2)/(a2 * a2 + b2 * b2));
        }

        public override string ToString() => real + "" + (imagine < 0 ? " - " + (-imagine) : " + " + imagine) + "i";

        // public static int power(int x, int y)
        // {
        //     if (y == 1)
        //     {
        //         return x;
        //     }
        //     else
        //     {
        //         return x * power(x, y - 1);
        //     }
        // }

    }
}