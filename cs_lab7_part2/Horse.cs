using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab7_part2
{
    internal class Horse : Transport
    {
        //Поля
        public int Age { get; set; }
        public double Weight { get; set; }

        //Конструкторы
        public Horse() : this(new Person(), 0, "noname", 0, 0, 0) { }
        public Horse(Person owner, double cost, string name, double cap, int age, double weight)
        {
            Owner = owner;
            Cost = cost;
            Name = name;
            Capacity = cap;
            Age = age;
            Weight = weight;
        }
    }
}