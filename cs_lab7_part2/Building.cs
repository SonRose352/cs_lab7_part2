using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab7_part2
{
    internal class Building : Holding, INalog
    {
        //Поле
        public string Address { get; set; }

        //Конструкторы
        public Building() : this(new Person(), 0, "") { }
        public Building(Person owner, double cost, string add)
        {
            Owner = owner;
            Cost = cost;
            Address = add;
        }

        //Метод, рассчитывающий величину налога
        public double nalog()
        {
            return 0.015 * Cost;
        }
    }
}