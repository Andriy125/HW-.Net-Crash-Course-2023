using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12__09._03._23_
{
    internal class AirDefenseVehicle : CombatVehicle
    {
        public int L; // дальність дії
        public int R; // швидкість стрільби
        public int M; // мобільність

        public AirDefenseVehicle(string model)
        {
            type = "Зенітна установка";
            this.model = model;
            health = 120;
            Random rnd = new Random();
            L = rnd.Next(1, 11);
            R = rnd.Next(1, 11);
            M = rnd.Next(1, 11);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Дальність дії: {L}") ;
            Console.WriteLine($"Швидкість стрільби: {R}");
            Console.WriteLine($"Мобільність: {M}");
        }

        public override int Attack() => 150 + L * (R / 10);


        public override void Defense(int damage)
        {
            health -= damage / M;
        }
    }
}
