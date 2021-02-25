using System;
using NUnit.Framework;
using Calculator;

namespace Test {
    public class Tests {
        [SetUp]
        public void Setup() {
        }
        
        [Test]
        public void EqualsTest() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(10, 5);
            Assert.True(num1 == num2);
        }
        
        [Test]
        public void NotEqualsTest1() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(11, 5);
            Assert.True(num1 != num2);
        }
        
        [Test]
        public void NotEqualsTest2() {
            var num1 = new ComplexNumber(10, 0);
            var num2 = new ComplexNumber(11, 0);
            Assert.True(num1 != num2);
        }
        
        [Test]
        public void NotEqualsTest3() {
            var num1 = new ComplexNumber(0, 5);
            var num2 = new ComplexNumber(0, 6);
            Assert.True(num1 != num2);
        }
        
        [Test]
        public void NotEqualsTest4() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(10, 6);
            Assert.True(num1 != num2);
        }
        
        [Test]
        public void ParseTest1() {
            var num1 = new ExpressionPart("10+5i").toComplexNumber();
            Assert.True(num1 == new ComplexNumber(10, 5));
        }

        [Test]
        public void ParseTest2() {
            var num1 = new ExpressionPart("10").toComplexNumber();
            Assert.True(num1 == new ComplexNumber(10, 0));
        }

        [Test]
        public void ParseTest3() {
            var num1 = new ExpressionPart("5i").toComplexNumber();
            Assert.True(num1 == new ComplexNumber(0, 5));
        }

        [Test]
        public void ParseTest4() {
            var num1 = new ExpressionPart("10+5i+3i").toComplexNumber();
            Assert.True(num1 == new ComplexNumber(10, 8));
        }

        [Test]
        public void ParseTest5() {
            var num1 = new ExpressionPart("5i+3i").toComplexNumber();
            Assert.True(num1 == new ComplexNumber(0, 8));
        }

        [Test]
        public void ParseTest6() {
            var num1 = new ExpressionPart("5i-3i").toComplexNumber();
            Assert.True(num1 == new ComplexNumber(0, 2));
        }

        [Test]
        public void ParseTest7() {
            var num1 = new ExpressionPart("10-2").toComplexNumber();
            Assert.True(num1 == new ComplexNumber(8, 0));
        }

        [Test]
        public void PlusTest() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(10, 5);
            var num3 = new ComplexNumber(20, 10);
            Assert.True(num1 + num2 == num3);
        }
        
        [Test]
        public void MinusTest() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(10, 5);
            var num3 = new ComplexNumber(0, 0);
            Assert.True(num1 - num2 == num3);
        }
        
        [Test]
        public void DivisionTest1() {
            var num1 = new ComplexNumber(20, 10);
            var num2 = new ComplexNumber(2, 0);
            var num3 = new ComplexNumber(10, 5);
            Assert.True(num1 / num2 == num3);
        }
        
        [Test]
        public void DivisionTest2() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(2, 2);
            var num3 = new ComplexNumber(3.75, -1.25);
            Assert.True(num1 / num2 == num3);
        }
        
        [Test]
        public void MultiplicationTest1() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(2, 0);
            var num3 = new ComplexNumber(20, 10);
            Assert.True(num1 * num2 == num3);
        }
        
        [Test]
        public void MultiplicationTest2() {
            var num1 = new ComplexNumber(10, 5);
            var num2 = new ComplexNumber(2, 2);
            var num3 = new ComplexNumber(10, 30);
            Assert.True(num1 * num2 == num3);
        }
    }
}