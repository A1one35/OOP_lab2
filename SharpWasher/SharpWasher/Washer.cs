using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Washer
    {
        public static void Wash()
        {
            Console.WriteLine("Дякую! Всі автомобілі вимиті!");

            var nissan = new Garage("Nissan", 5, 1);
            Console.WriteLine($"Назва автомобіля: {nissan.Name_of_Car}, Рівень забруднення: {nissan.Level_of_Dirty * 0}/5, Місце в гаражі: {0}");

            var bmw = new Garage("BMW", 4, 2);
            Console.WriteLine($"Назва автомобіля: {bmw.Name_of_Car}, Рівень забруднення: {bmw.Level_of_Dirty * 0}/5, Місце в гаражі: {0}");

            var lada = new Garage("Lada", 1, 3);
            Console.WriteLine($"Назва автомобіля: {lada.Name_of_Car}, Рівень забруднення: {lada.Level_of_Dirty * 0}/5, Місце в гаражі: {0}");
        }

    }
}
