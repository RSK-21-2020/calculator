using System;
using System.Collections.Generic;

namespace Calculator {
    internal class Program {
        private static void Main(string[] args) {
            // string currentRawPart = "";
            println("Введите первое число:");
            var c1 = new ExpressionPart(Console.ReadLine().Replace(" ", "")).toComplexNumber();
            println("Введите второе число:");
            var c2 = new ExpressionPart(Console.ReadLine().Replace(" ", "")).toComplexNumber();
            println("Введите действие:");
            switch (Console.ReadLine()) {
                case "+": println("Результат: " + (c1 + c2)); break;
                case "-": println("Результат: " + (c1 - c2)); break;
                case "*": println("Результат: " + c1 * c2); break;
                case "/": println("Результат: " + c1 / c2); break;
            }

            // List<ExpressionPart> parts = new List<ExpressionPart>();
            // foreach (var i in rawInput1) {
            //     if (i == '(' || i == ')') {
            //         parts.Add(new ExpressionPart(currentRawPart));
            //         currentRawPart = "";
            //     } else {
            //         currentRawPart += i;
            //     }
            // }
            //
            //
            // foreach (var j in part.expression)
            //     println(j.isNotNegative
            //         ? j.isImagine ? j.value + "i" : j.value
            //         : "-" + (j.isImagine ? j.value + "i" : j.value));
        }

        public static void println(Object obj) => Console.WriteLine(obj.ToString());
        public static void print(Object obj) => Console.Write(obj.ToString());
    }
}