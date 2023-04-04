using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12__09._03._23_
{
    internal class ArmoredCar : CombatVehicle
    {
        public int C; // кількість зброї
        public int S; // швидкість

        public ArmoredCar(string model)
        {
            type = "Броньований автомобіль";
            this.model = model;
            health = 80;
            Random rnd = new Random();
            C = rnd.Next(1, 11);
            S = rnd.Next(1, 11);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кількість зброї: {C}");
            Console.WriteLine($"швидкість: {S}");
        }

        public override int Attack() => 50 * C;


        public override void Defense(int damage)
        {
            health -= (damage - S / 2);
        }
    }
}
