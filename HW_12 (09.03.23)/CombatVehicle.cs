using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12__09._03._23_
{
    abstract class CombatVehicle
    {
        public string type;
        public string model;
        public int health;

        public bool IsDestroyed()
        {
            return health <= 0;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Тип: {0}", type);
            Console.WriteLine("Модель: {0}", model);
            Console.WriteLine("Здоровля: {0}", health);
        }

        public abstract int Attack();
        public abstract void Defense(int damage);


    }
}
