using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using RSK_2_21_Lect1_Console;

namespace RSK_2_21_Lect1_UT
{
    [TestClass]
    public class UT_MyComplex
    {
        [TestMethod]
        public void Common_TM()
        {
                        
            var a = new MyComplex();
            a.x = 1;
            a.y = 2;
            var b = new MyComplex(3, 4);
            var c = MyComplex.Add(a, b);

            var d = a + b;

            //Add test
            Assert.AreEqual(4, c.x);
            Assert.AreEqual(6, c.y);

            //+ test
            Assert.AreEqual(4, d.x);
            Assert.AreEqual(6, d.y);

            //Abs Test
            var exp = 2.236;
            var act = a.Abs();
            Assert.AreEqual(exp, act, 0.001);

        }

        [TestMethod]
        public void Add_TM()
        {
            var a = new MyComplex() { y = 1, x = 2};
            
            var b = new MyComplex(3, 4);

            var c = a + b;

            //Add test
            Assert.AreEqual(5, c.x, "Error in real part");
            Assert.AreEqual(5, c.y, "Error in image part");
        }

        [TestMethod]
        public void Add_Real_TM()
        {
            var a = new MyComplex() { y = 1, x = 2 };
                       
            var c = MyComplex.Add(a, 2);

            //Add test
            Assert.AreEqual(4, c.x, "Error in real part");
            Assert.AreEqual(1, c.y, "Error in image part");
        }
    }
}
