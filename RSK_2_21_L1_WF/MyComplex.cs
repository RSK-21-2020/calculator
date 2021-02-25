using System;
using System.Collections.Generic;
using System.Text;

namespace RSK_2_21_Lect1_Console
{
    public class MyComplex
    {
        /*
         Сергеев+
        Брыгина+
        Долгоруков-
        Дружинин-
        Емельянов+
        Скопин+
        Зверев+
        Петров+
        Костицына+
        Ярандаев+
        Масликов+
        Потапов
        Репин
        Соколова

        //Пара2

        Сергеев+
        Брыгина+
        Долгоруков-
        
        Емельянов+
        Скопин+
        Зверев+
        Петров+
        Костицына+
        Ярандаев-
        Масликов+
        Потапов+
        Репин+
        Соколова-

         */

        #region Fields

        public double x = 0; //Real
        public double y = 0; //Image

        #endregion

        #region Constructors

        public MyComplex() { }

        public MyComplex(double re, double im)
        {
            x = re;
            y = im;
        }

        #endregion

        #region Methods non-static

        public double Abs()
        {
            double r = x * x + y * y;
            return Math.Sqrt(r);
        }

        public override string ToString()
        {
            //Добавить условие на отрицательную мнимую часть
            if(y < 0) return $"{x} -{-y} i";
            else return $"{x} +{y} i";
        }

        #endregion

        #region Methods static

        public static MyComplex Add(MyComplex a, MyComplex b)
        {
            MyComplex c = new MyComplex();
            c.x = a.x + b.x;
            c.y = a.y + b.y;
            return c;
        }

        public static MyComplex Add(MyComplex a, double d)
        {
            MyComplex c = new MyComplex();
            c.x = a.x + d;
            c.y = a.y;
            return c;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            var c = new MyComplex(a.x + b.x, a.y + b.y);
            return c;
        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            var c = new MyComplex(a.x - b.x, a.y - b.y);
            return c;
        }

        public static MyComplex ParseComplex(string str)
        {
            var s = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var tmpRe = Double.Parse(s[0]);
            var tmpIm = Double.Parse(s[1]);
            var a = new MyComplex(tmpRe, tmpIm);
            return a;
        }

        /*
        * + 
        * *
        * -
        * /
        * inverse 
        * scalar dot
         */

        #endregion
    }
}
