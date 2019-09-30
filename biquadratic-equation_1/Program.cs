using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biquadratic_equation_1
{
    class Program
    {
        static double validation_of_the_discriminant(double a, double b, double c)//вычисление дискриминанта
        {
            double dis;
            dis = Math.Pow(b, 2) - 4 * a * c;
            if (dis >= 0)
            {
                return dis;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Решений нет");
                Console.ReadKey();
                return 0;
            }
        }

        static void the_computation_of_the_roots(double t1, double t2)//нахождение корней
        {
            double x1, x2, x3, x4;
            Console.ForegroundColor = ConsoleColor.Green;
            if(t1==0 && t2==0)
            {
                x1 = 0;
                x2 = 0;
                x3 = 0;
                x4 = 0;
                Console.WriteLine("Единственное возможное решение 0");
                Console.WriteLine("x1:{0}", x1);
                Console.WriteLine("x2: {0}", x2);
                Console.WriteLine("x3:{0}", x3);
                Console.WriteLine("x4: {0}", x4);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1>0 && t2==0)
            {
                x1 = Math.Sqrt(t1);
                x2= (-1)*Math.Sqrt(t1);
                x3 = 0;
                x4 = 0;
                Console.WriteLine("x1:{0}", x1);
                Console.WriteLine("x2: {0}", x2);
                Console.WriteLine("x3:{0}", x3);
                Console.WriteLine("x4: {0}", x4);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1<0 && t2==0)
            {
                x3 = 0;
                x4 = 0;
                Console.WriteLine("x1, x2 не существует");
                Console.WriteLine("x3:{0}", x3);
                Console.WriteLine("x4: {0}", x4);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1==0 && t2>0)
            {
                x1 = 0;
                x2 = 0;
                x3 = Math.Sqrt(t2);
                x4 = (-1) * Math.Sqrt(t2);
                Console.WriteLine("x1:{0}", x1);
                Console.WriteLine("x2: {0}", x2);
                Console.WriteLine("x3:{0}", x3);
                Console.WriteLine("x4: {0}", x4);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1==0 && t2<0)
            {
                x1 = 0;
                x2 = 0;
                Console.WriteLine("x3, x4 не существует");
                Console.WriteLine("x1:{0}", x1);
                Console.WriteLine("x2: {0}", x2);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1<0 && t2<0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Решений нет");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1>0 && t2>0)
            {
                x1 = Math.Sqrt(t1);
                x2 = (-1) * Math.Sqrt(t1);
                x3 = Math.Sqrt(t2);
                x4 = (-1) * Math.Sqrt(t2);
                Console.WriteLine("x1:{0}", x1);
                Console.WriteLine("x2: {0}", x2);
                Console.WriteLine("x3:{0}", x3);
                Console.WriteLine("x4: {0}", x4);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1>0 && t2<0)
            {
                x1 = Math.Sqrt(t1);
                x2 = (-1) * Math.Sqrt(t1);
                Console.WriteLine("x3, x4 не существует");
                Console.WriteLine("x1:{0}", x1);
                Console.WriteLine("x2: {0}", x2);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if(t1<0 && t2>0)
            {
                x3 = Math.Sqrt(t2);
                x4 = (-1) * Math.Sqrt(t2);
                Console.WriteLine("x1, x2 не существует");
                Console.WriteLine("x3:{0}", x3);
                Console.WriteLine("x4: {0}", x4);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {

            try//обработка исключений, 
            {
                Console.Title = "Бочарова Маргарита РТ5-31Б";
                Console.WriteLine("Введите коэффициент а: ");//введение коэффициентов с клавиатуры
                string num = Console.ReadLine();
                double a = Convert.ToDouble(num);
                Console.WriteLine("Введите коэффициент b: ");
                num = Console.ReadLine();
                double b = Convert.ToDouble(num);
                Console.WriteLine("Введите коэффициент c: ");
                num = Console.ReadLine();
                double c = Convert.ToDouble(num);
             
                double t1 = 0;
                double t2 = 0;
                double dis;

                if (a == 0 && b != 0 && c != 0)//обработка первостепенных корней
                {
                    t1 = ((-1) * c) / b;
                    t2 = -10;
                    if (t1 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Решений нет");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    the_computation_of_the_roots(t1, t2);
                }
                if (a == 0 && b == 0 && c != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Решений нет");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (a == 0 && b == 0 && c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Решений нет");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (a != 0 && b == 0 && c == 0)
                {
                    t1 = 0;
                    t2 = 0;
                    the_computation_of_the_roots(t1, t2);
                }
                if (a != 0 && b == 0 && c != 0)
                {
                    t1 = Math.Sqrt(((-1) * c) / a);
                    t1 = (-1) * Math.Sqrt(((-1) * c) / a);
                    if (((((-1) * c) / a)) < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Решений нет");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                if (a != 0 && b != 0 && c != 0)
                {
                    dis = validation_of_the_discriminant(a, b, c);
                    t1 = (((-1) * b) + Math.Sqrt(dis)) / (2 * a);
                    t2 = (((-1) * b) - Math.Sqrt(dis)) / (2 * a);
                    the_computation_of_the_roots(t1, t2);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            Console.ReadKey();

        } 
    }
}
