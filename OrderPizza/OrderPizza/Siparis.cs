using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza
{
    public class Siparis
    {
        
        public Pizzalar pizzalar { get; set; }

        public int PizzaAdet { get; set; }

        public decimal Tutar { get; set; }

        public override string ToString()
        {
            string siparis = "";
            siparis += pizzalar.EbatAdı.EbatAdı + ",";
            siparis += pizzalar.PizzaName + ",";
            siparis += pizzalar.KenarTip.KenarTip + ",";

            foreach (string mlz in pizzalar.Malzemeler)
            {
                siparis += string.Format("{0},", mlz);

            }
            siparis = siparis.Remove(siparis.Length - 1, 1);  //Remove sondaki virgulü kaldır.
            siparis += string.Format(" {0} x {1} = {2}", PizzaAdet, pizzalar.Hesapla, PizzaAdet * pizzalar.Hesapla);
            return siparis;

        }

    }
}
