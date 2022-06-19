using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza
{
    public class Pizzalar
    {
        public string PizzaName { get; set; }
        public decimal PizzaFiyat { get; set; }
        public PizzaEbat EbatAdı { get; set; }
        public PizzaKenar KenarTip { get; set; }
        public List<string> Malzemeler { get; set; } //Pizza Malzemleri Listenin içinde tutulacak.

        public decimal Hesapla
        {
            get
            {
                decimal hesap = 0;
                hesap = PizzaFiyat * (decimal)EbatAdı.EbatCarp;
                hesap += KenarTip.KenarFiyat;
                return hesap;

            }
        }


        public override string ToString()
        {
            return PizzaName;

            // return string.Format("{0}-{1}", PizzaName, PizzaFiyat);
        }

    }
}
