using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InfinitieSeries
{
    class Program
    {
        public delegate double SumDelegate(double a, double r, int n);
        static void Main(string[] args)
        {
            Console.Write("Введiть число для обчислення: ");
            var n = int.Parse(Console.ReadLine());
            var a = 1.0;
            var r = 1.0 / 2.0;

            Console.WriteLine("1) 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...");
            Console.WriteLine("2) 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...");
            Console.WriteLine("3) 1 + 1/2 - 1/4 + 1/8 - 1/16 + ...");
            Console.WriteLine("Виберiть бескiнечний ряд: ");
            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    SumDelegate first = FirstSum;
                    Console.WriteLine($"Результат: {first?.Invoke(a, r, n)}");
                    break;
                case 2:
                    SumDelegate second = SecondSum;
                    Console.WriteLine($"Результат: {second?.Invoke(a, r, n)}");
                    break;
                case 3:
                    SumDelegate third = ThirdSum;
                    Console.WriteLine($"Результат: {third?.Invoke(a, r, n)}");
                    break;
                default:
                    Console.WriteLine("Помилка!");
                    break;
            }

            Console.ReadLine();
        }

        private static double FirstSum(double a, double r, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += a;
                a *= r;
            }
            return Math.Round(sum, 2);
        }
        private static double SecondSum(double a, double r, int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return Math.Round(sum, 2);
        }
        private static double Factorial(double num)
        {
            double res = 1;
            for (double i = num; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }
        private static double ThirdSum(double a, double r, int n)
        {
            var sum = 0.0;
            var PlusOrMinus = true;
            var changingSignsCount = -1;
            double tmp = sum + a;

            for (int i = 1; i <= n; i++)
            {
                changingSignsCount++;

                if (PlusOrMinus)
                {
                    sum += tmp;
                }
                else
                {
                    sum -= tmp;
                }
                if (changingSignsCount == 1)
                {
                    PlusOrMinus = !PlusOrMinus;
                    changingSignsCount = 0;
                }

                tmp = a *= r;
            }
            return Math.Round(sum, 2);
        }
    }
}
