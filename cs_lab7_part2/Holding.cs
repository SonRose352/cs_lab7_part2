using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab7_part2
{
    internal class Holding : IComparable
    {
        //Поля
        public Person Owner { get; set; }
        public double Cost { get; set; }

        //Метод CompareTo
        public int CompareTo(object obj)
        {
            Holding other = obj as Holding;
            if (other != null)
            {
                if (this.Cost > other.Cost) return 1;
                if (this.Cost < other.Cost) return -1;
                else return 0;
            }
            else
                return 1;
        }
    }
}