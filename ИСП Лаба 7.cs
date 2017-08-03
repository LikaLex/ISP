using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    internal enum Type { Long, Double, Decimal, String }

    internal class Rational // Этот класс должен содержать значение m / n, long m, n
    {
        // Поля и свойства
        private long _m;
        private long _n;
        long m { get { return _m; } }
        long n { get { return _n; } }


        // методы
        private static bool Cut(ref long a, ref long b)
        {
            bool flag = false;
            long divider = 2;

            while (divider <= a && divider <= b)
            {
                if (a % divider == 0 && b % divider == 0)
                {
                    a /= divider;
                    b /= divider;
                    flag = true;
                }
                else
                    divider++;
            }

            return flag;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return m.ToString() + "/" + n.ToString();
        }

        public string ToString(Type arg)
        {
            if (arg == Type.String)
                return arg.ToString();
            else if (arg == Type.Long)
                return ((long)m / n).ToString();
            else if (arg == Type.Double)
                return ((double)m / n).ToString();
            else
                return ((decimal)m / n).ToString();
        }

        // конструкторы
        public Rational()
        {
            _m = 0;
            _n = 1;
        }

        public Rational(long a, long b)
        {
            if (b <= 0)
            {
                Console.WriteLine("Inadequate data!");
                Console.ReadKey(true);
                Environment.Exit(1);
            }
            else
            {
                _m = a;
                _n = b;
            }
            Cut(ref _m, ref _n);
        }

        public Rational(string arg)
        {
            string[] s = arg.Split('/');
            _m = Convert.ToInt64(s[0]);
            _n = Convert.ToInt64(s[1]);
            Cut(ref _m, ref _n);
        }

        // Унарные операторы
        public static Rational operator +(Rational arg)
        {
            return new Rational(Math.Abs(arg.m), arg.n);
        }

        public static Rational operator -(Rational arg)
        {
            return new Rational(-arg.m, arg.n);
        }

        // Операторы сравнения
        public static bool operator ==(Rational arg1, Rational arg2)
        {
            if (arg1.m == arg2.m && arg1.n == arg2.n)
                return true;
            else
                return false;
        }

        public static bool operator !=(Rational arg1, Rational arg2)
        {
            if (arg1.m != arg2.m || arg1.n != arg2.n)
                return true;
            else
                return false;
        }

        public static bool operator <(Rational arg1, Rational arg2)
        {
            return (decimal)arg1.m / arg1.n < (decimal)arg2.m / arg2.n;
        }

        public static bool operator >(Rational arg1, Rational arg2)
        {
            return (decimal)arg1.m / arg1.n > (decimal)arg2.m / arg2.n;
        }

        // Арифметические операторы
        public static Rational operator +(Rational arg1, Rational arg2)
        {
            long divided, divider;
            checked
            {
                divided = arg1.m * arg2.n + arg2.m * arg1.n;
                divider = arg1.n * arg2.n;
            }
            return new Rational(divided, divider);
        }

        public static Rational operator -(Rational arg1, Rational arg2)
        {
            return (arg1 + (-arg2));
        }

        public static Rational operator *(Rational arg1, Rational arg2)
        {
            long divided, divider;
            checked
            {
                divided = arg1.m * arg2.m;
                divider = arg1.n * arg2.n;
            }
            return new Rational(divided, divider);
        }

        public static Rational operator /(Rational arg1, Rational arg2)
        {
            long divided, divider;
            checked
            {
                divided = arg1.m * arg2.n;
                divider = arg1.n * arg2.m;
                if (divided > 0 && divider > 0 || divided < 0 && divider < 0)
                {
                    divided = Math.Abs(divided);
                    divider = Math.Abs(divider);
                }
                else
                {
                    divided = -Math.Abs(divided);
                    divider = Math.Abs(divider);
                }
            }
            return new Rational(divided, divider);
        }

        // Операторы преобразования
        public static explicit operator long(Rational arg)
        {
            return arg.m / arg.n;
        }

        public static implicit operator double(Rational arg)
        {
            return (double)arg.m / arg.n;
        }

        public static implicit operator decimal(Rational arg)
        {
            return (decimal)arg.m / arg.n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rational Rational1 = new Rational(5, 6);
            Rational Rational2 = new Rational(1, 3);
            Console.WriteLine("5/6 + 1/3 = " + (Rational1 + Rational2).ToString());
            Console.WriteLine("5/6 - 1/3 = " + (Rational1 - Rational2).ToString());
            Console.WriteLine("5/6 * 1/3 = " + (Rational1 * Rational2).ToString());
            Console.WriteLine("5/6 / 1/3 = " + (Rational1 / Rational2).ToString());
            Console.WriteLine("Press any key . . .");
            Console.ReadKey(true);

            Rational1 = new Rational("230/240");
            Rational2 = new Rational("240/230");
            Console.WriteLine("230/240 + 240/230 = " + (Rational1 + Rational2).ToString());
            Console.WriteLine("230/240 - 240/230 = " + (Rational1 - Rational2).ToString());
            Console.WriteLine("230/240 * 240/230 = " + (Rational1 * Rational2).ToString());
            Console.WriteLine("230/240 / 240/230 = " + (Rational1 / Rational2).ToString());
            Console.WriteLine("Press any key . . .");
            Console.ReadKey(true);

            Rational1 = new Rational(5, 6);
            Rational2 = new Rational(1, 3);
            Console.WriteLine("5/6 + 1/3 = " + (Rational1 + Rational2).ToString(Type.Decimal));
            Console.WriteLine("5/6 - 1/3 = " + (Rational1 - Rational2).ToString(Type.Double));
            Console.WriteLine("5/6 * 1/3 = " + (Rational1 * Rational2).ToString(Type.Long));
            Console.WriteLine("5/6 / 1/3 = " + (Rational1 / Rational2).ToString(Type.String));
            Console.WriteLine("Press any key . . .");
            Console.ReadKey(true);

            Rational1 = new Rational("230/240");
            Rational2 = new Rational("240/230");
            Console.WriteLine("230/240 + 240/230 = " + (Rational1 + Rational2).ToString(Type.Decimal));
            Console.WriteLine("230/240 - 240/230 = " + (Rational1 - Rational2).ToString(Type.Double));
            Console.WriteLine("230/240 * 240/230 = " + (Rational1 * Rational2).ToString(Type.Long));
            Console.WriteLine("230/240 / 240/230 = " + (Rational1 / Rational2).ToString(Type.String));
            Console.ReadKey(true);
        }
    }
}
