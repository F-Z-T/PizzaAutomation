using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza
{
    public class PizzaEbat
    {
        public string EbatAdı { get; set; }
        public double EbatCarp { get; set; }

        public override string ToString()
        {
            return EbatAdı;

        }

    }
}
