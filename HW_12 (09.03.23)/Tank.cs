using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12__09._03._23_
{
    internal class Tank : CombatVehicle
    {
        public int R; // час перезарядки
        public int A; // точність пострілу
        public int T; // товщина броні

        public Tank(string model)
        {
            type = "Танк";
            this.model = model;
            health = 100;
            Random rnd = new Random();
            R = rnd.Next(1, 11);
            A = rnd.Next(1, 11);
            T = rnd.Next(1, 11);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Час перезарядки: {R}");
            Console.WriteLine($"Точність пострілу: {A}");
            Console.WriteLine($"Товщина броні: {T}");
        }

        public override int Attack() => 100 * A / R;


        public override void Defense(int damage)
        {
            health -= (damage - T);
        }
    }
}
