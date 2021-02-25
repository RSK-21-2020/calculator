using System;

namespace RSK_2_21_Lect1_ConsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "";

            var a = new MyComplex();
            a.x = 1;
            a.y = 2;

            txt += $"a = {a.x} + {a.y} i\n";

            var b = new MyComplex(3, 4);

            txt += $"b = {b.x} + {b.y} i\n";

            var c = MyComplex.Add(a, b);

            txt += $"(Add) c = {c.x} + {c.y} i\n";

            var d = a + b;

            txt += $"(+) d = {d.x} + {d.y} i\n";


            Console.WriteLine(txt);
        }
    }
}
