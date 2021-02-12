using System.Collections.Generic;

namespace Calculator {
    public class ExpressionPart {
        public string rawPart { get; private set; }
        public List<AddableItem> expression { get; private set; }

        public ExpressionPart(string rawPart) {
            this.rawPart = rawPart;
            this.parse();
        }

        public void parse() {
            var rawInput = rawPart.Split("+");
            var rawElemList = new List<AddableItem>();
            foreach (var elem in rawInput) {
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
            expression = rawElemList;
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

        public ComplexNumber toComplexNumber() {
            double x1 = 0;
            double y1 = 0;
            foreach (var i in this.expression) {
                if (i.isImagine) {
                    if (i.isNotNegative) {
                        y1 += i.value;
                    } else {
                        y1 -= i.value;
                    }
                } else {
                    if (i.isNotNegative) {
                        x1 += i.value;
                    } else {
                        x1 -= i.value;
                    }   
                }
            }

            return new ComplexNumber(x1, y1);
        }
    }
}