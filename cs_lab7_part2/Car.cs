using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab7_part2
{
    internal class Car : Transport, INalog
    {
        //Поле
        public double Power { get; set; }

        //Конструкторы
        public Car() : this(new Person(), 0, "noname", 0, 0) { }
        public Car(Person owner, double cost, string name, double cap, double power)
        {
            Owner = owner;
            Cost = cost;
            Name = name;
            Capacity = cap;
            Power = power;
        }

        //Метод, рассчитывающий величину налога
        public double nalog()
        {
            if (Owner.Gender == 'м' && Owner.Age() >= 63 || Owner.Gender == 'ж' && Owner.Age() >= 58)
                return 0;
            else
            {
                if (Capacity > 3000)
                {
                    if (Power <= 100)
                        return 2.5 * Power;
                    if (Power > 100 && Power <= 150)
                        return 4 * Power;
                    if (Power > 150 && Power <= 200)
                        return 5 * Power;
                    if (Power > 200 && Power <= 250)
                        return 6.5 * Power;
                    else
                        return 8.5 * Power;
                }
                else
                {
                    if (Power <= 100)
                        return 2.5 * Power;
                    if (Power > 100 && Power <= 150)
                        return 3.5 * Power;
                    if (Power > 150 && Power <= 200)
                        return 5 * Power;
                    if (Power > 200 && Power <= 250)
                        return 7.5 * Power;
                    if (Power > 250 && Power <= 410)
                        return 15 * Power;
                    else
                        return 300 * Power;
                }
            }
        }
    }
}