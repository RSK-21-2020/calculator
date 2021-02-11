using System;
using System.Collections.Generic;

namespace Calculator {
    internal class Program {
        private static void Main(string[] args) {
            // var c1 = new ComplexNumber(10, 5);
            // var c2 = new ComplexNumber(2, -4);
            // var c3 = c1 / c2;
            //
            // Console.WriteLine(c3.real + " " + c3.imagine + "i");
            var rawInput1 = Console.ReadLine().Replace(" ", "").Split("+");
            var rawElemList = new List<AddableItem>();
            foreach (var elem in rawInput1) {
                if (elem.Contains("-")) {
                    var firstSecondaryElem = true;
                    foreach (var elem2 in elem.Split("-")) {
                        if (firstSecondaryElem) {
                            addToList(rawElemList, elem2, true);
                            firstSecondaryElem = false;
                        } else {
                            addToList(rawElemList, elem2, false);
                        }
                    }
                } else {
                    addToList(rawElemList, elem, true);
                }
            }

            foreach (var elem in rawElemList)
                println(elem.isNotNegative
                    ? elem.isImagine ? elem.value + "i" : elem.value
                    : "-" + (elem.isImagine ? elem.value + "i" : elem.value));
        }

        private static void addToList(List<AddableItem> list, string elem, bool isNotNegative) {
            if(elem == "") return;
            if (elem.Contains("i") || elem.Contains("I")) {
                var i = elem.Replace("i", "").Replace("I", "");
                list.Add(new AddableItem(double.Parse(i), true, isNotNegative));
            } else {
                list.Add(new AddableItem(double.Parse(elem), false, isNotNegative));
            }
        }

        private static void println(Object obj) => Console.WriteLine(obj.ToString());
    }
}