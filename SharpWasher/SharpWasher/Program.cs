using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Program
    {
        public delegate void CarsDelegate();

        public delegate void WashDelegate();
        static void Main(string[] args)
        {
            var cars = new CarsDelegate(Garage.Nissan);
            cars += Garage.Bmw;
            cars += Garage.Lada;

            Console.WriteLine("Автомобілі в списку:");
            cars?.Invoke();

            Console.WriteLine();

            Console.Write("Введіть будь-яку клавішу для миття всіх автомобілів");
            Console.ReadKey();

            var wash = new WashDelegate(Washer.Wash);
            wash?.Invoke();

            Console.ReadLine();
        }

    }
}
