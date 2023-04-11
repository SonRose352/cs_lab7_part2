using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab7_part2
{
    internal class Stead : Holding, INalog
    {
        //Поле
        public double Area { get; set; }

        //Конструкторы
        public Stead() : this(new Person(), 0, 0) { }

        public Stead(Person owner, double cost, double area)
        {
            Owner = owner;
            Cost = cost;
            Area = area;
        }

        //Метод, рассчитывающий величину налога
        public double nalog()
        {
            return 0.003 * Cost;
        }
    }
}