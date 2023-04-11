using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab7_part2
{
    internal class SmallShip : Transport, INalog
    {
        //Поля
        public int Paddle { get; set; }
        public double Power { get; set; }

        //Конструкторы
        public SmallShip() : this(new Person(), 0, "noname", 0, 0, 0) { }
        public SmallShip(Person owner, double cost, string name, double cap, int pad, double power)
        {
            Owner = owner;
            Cost = cost;
            Name = name;
            Capacity = cap;
            Paddle = pad;
            Power = power;
        }

        //Метод, рассчитывающий величину налога
        public double nalog()
        {
            if (Owner.Gender == 'м' && Owner.Age() >= 63 || Owner.Gender == 'ж' && Owner.Age() >= 58)
                return 0;
            else
            {
                if (Power <= 100)
                    return 10 * Power;
                else if (Power > 100 && Power <= 300)
                    return 20 * Power;
                else
                    return 200 * Power;
            }
        }
    }
}