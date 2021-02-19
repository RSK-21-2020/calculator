using System;

namespace Calculator {
    public class ComplexNumber {
        public double imagine;
        public double real;

        public ComplexNumber(double re, double im) {
            real = re;
            imagine = im;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) =>
            new(a.real + b.real, a.imagine + b.imagine);

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) =>
            new(a.real - b.real, a.imagine - b.imagine);

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) =>
            new(a.real * b.real - a.imagine * b.imagine, a.real * b.imagine + a.imagine * b.real);

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b) {
            var a1 = a.real;
            var b1 = a.imagine;
            var a2 = b.real;
            var b2 = b.imagine;
            return new ComplexNumber((a1 * a2 + b1 * b2) / (a2 * a2 + b2 * b2),
                (a2 * b1 - a1 * b2) / (a2 * a2 + b2 * b2));
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b) => a.imagine == b.imagine && a.real == b.real;

        public static bool operator !=(ComplexNumber a, ComplexNumber b) => !(a == b);

        public override string ToString() => real + "" + (imagine < 0 ? " - " + -imagine : " + " + imagine) + "i";

        public double abs(ComplexNumber a) => Math.Sqrt(a.real * a.real + a.imagine * a.imagine);
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