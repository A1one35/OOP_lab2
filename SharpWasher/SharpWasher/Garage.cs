using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    class Garage : Car
    {
        public Garage(string name_of_car, int level_of_Dirty, int place_in_queue) : base(name_of_car, level_of_Dirty, place_in_queue) { }

        public static void Nissan()
        {
            var nissan = new Garage("Nissan", 5, 1);

            Console.WriteLine($"Назва автомобіля: {nissan.Name_of_Car}, Рівень забруднення: {nissan.Level_of_Dirty}/5, Місце в гаражі: {nissan.Place_In_Queue}");
        }
        public static void Bmw()
        {
            var bmw = new Garage("BMW", 4, 2);

            Console.WriteLine($"Назва автомобіля: {bmw.Name_of_Car}, Рівень забруднення: {bmw.Level_of_Dirty}/5, Місце в гаражі: {bmw.Place_In_Queue}");
        }
        public static void Lada()
        {
            var lada = new Garage("Lada", 1, 3);

            Console.WriteLine($"Назва автомобіля: {lada.Name_of_Car}, Рівень забруднення: {lada.Level_of_Dirty}/5, Місце в гаражі: {lada.Place_In_Queue}");
        }

    }
}
