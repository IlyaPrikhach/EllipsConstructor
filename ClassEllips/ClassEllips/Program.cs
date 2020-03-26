using System;

namespace ClassEllips
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            input(out a, out b);
            cheсk(a, b);
            output(a,b);
            Console.ReadLine();
        }

        static void input( out double a, out double b)
        {
            a = 0;
            b = 0;
            try
            {
                Console.WriteLine("Введите размеры большой оси a и малой оси b");
                string argsLine = Console.ReadLine();
                string[] args = new string[2];
                args = argsLine.Replace('.', ',').Split(' ');
                a = Convert.ToDouble(args[0]);
                b = Convert.ToDouble(args[1]);
                
            }
            catch
            {
                Console.WriteLine("Возможно вы ввели данные неверно");
                input(out a, out b);
            }

        }

        static void cheсk(double a, double b)
        {

            // double e = Math.Sqrt(1 - (Math.Pow(b, 2) / Math.Pow(a, 2)));
            //Console.WriteLine(e);
            //if (e > 1)
            //{
            //    Console.WriteLine("вы ввели данные для гиперболы");
            //}
            //if (e == 1)
            //{
            //    Console.WriteLine("вы ввели данные для параболы");
            //}
            if (a < b)
            {
                Console.WriteLine("a не может быть больше b");
                input(out a, out b);
            }
            if (a < 0 || b < 0)
            {
                Console.WriteLine("а и в не могут быть отрицательными");
            }
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Вы ввели данные для точки");
            }
            else if (a == 0 || b == 0)
            {
                Console.WriteLine("вы ввели данные для прямой");
            }
           
            

        }
        static void output(double a, double b)
        {
            string ch = null;
            double res = 0;
            Ellips el1 = new Ellips(a, b);
            try
            {
                Console.WriteLine("Что вы хотите посчитать? Площадь s или периметр p (s/p)");
                 ch = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Попробуйте снова");
                output(a, b);
            }
            if (ch == "s" )
            {
                res = el1.s();
            }
            if (ch == "p")
            {
               res = el1.p();
            }
            Console.WriteLine(res);
        }
    }

    class Ellips
    { double a, b;
        public Ellips(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double s()
        {
            return Math.PI * a * b;
        }
        public double p()
        {
            return (4 * (Math.PI * a * b) + Math.Pow(a - b, 2)) / a + b ;
        }
    }
}
