using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab7_part2
{
    internal class Worker : Person, INalog
    {
        //Поля
        public double Salary { get; set; }
        public int Bonus { get; set; }

        //Конструкторы
        public Worker() : this("noname", "", new DateTime(), 'м', 0, 0) { }
        public Worker(string fn, string sn, DateTime d, char s, double sal, int p) : base(fn, sn, d, s)
        {
            Salary = sal;
            Bonus = p;
        }

        //Метод, возвращающий полный заработок
        public double TotalPay()
        {
            return Salary * (1 + Bonus / 100.0);
        }

        //Метод, рассчитывающий величину налога
        public double nalog()
        {
            return 0.13 * TotalPay();
        }
    }
}