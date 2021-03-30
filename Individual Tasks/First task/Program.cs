using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_task
{
    class Program
    {
        private delegate double MyDelegate(double value);
        static void Main(string[] args)
        {
            MyDelegate[] mD =
            {
                num => Math.Sqrt(Math.Abs(num)),
                num => Math.Tan(num),
                num => Math.Pow(num, 4)
            };
            Dictionary<double, MyDelegate> switcher = new Dictionary<double, MyDelegate>
            {
                {0, mD[0]},
                {1, mD[1]},
                {2, mD[2]}
            };

            Console.WriteLine("Введiть данi, якщо вони мають тип 0 x або 1 x або 2 x.");
            Console.WriteLine("0 -- sqrt(abs(x))");
            Console.WriteLine("1 -- tg(x)");
            Console.WriteLine("2 -- x^4");
            Console.WriteLine("\nЯкщо ви введете некоректнi данi програма завершить роботу i виведе помилку.");

            while (true)
            {
                try
                {
                    var inputDataString = Console.ReadLine();
                    string[] stringArray = inputDataString.Split();
                    var key = int.Parse(stringArray[0]);
                    var value = double.Parse(stringArray[1]);
                    var a = switcher[key];
                    Console.WriteLine(a(value));
                }
                catch (Exception)
                {
                    Console.WriteLine($"Помилка! \nПрограма завершила свою роботу!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
