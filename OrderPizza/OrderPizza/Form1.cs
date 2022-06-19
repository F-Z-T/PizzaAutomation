using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            #region ObjectEbat

            PizzaEbat Kucuk = new PizzaEbat { EbatAdı = "Küçük", EbatCarp = 1 };
            PizzaEbat Orta = new PizzaEbat { EbatAdı = "Orta", EbatCarp = 1.25 };
            PizzaEbat Buyuk = new PizzaEbat { EbatAdı = "Büyük", EbatCarp = 1.75 };
            PizzaEbat Maxi = new PizzaEbat { EbatAdı = "Maxi", EbatCarp = 2 };

            cmbEbat.Items.Add(Kucuk);
            cmbEbat.Items.Add(Orta);
            cmbEbat.Items.Add(Buyuk);
            cmbEbat.Items.Add(Maxi);


            #endregion

            #region ObjectPizza
            

            Pizzalar klasik = new Pizzalar { PizzaName = "KLASİK", PizzaFiyat = 14 };
            Pizzalar karısık = new Pizzalar { PizzaName = "KARIŞIK", PizzaFiyat = 17 };
            Pizzalar extravaganza = new Pizzalar { PizzaName = "EXTRAVAGANZA", PizzaFiyat = 21 };
            Pizzalar ıtalıano = new Pizzalar { PizzaName = "ITALIANO", PizzaFiyat = 20 };
            Pizzalar turkish = new Pizzalar { PizzaName = "TURKISH", PizzaFiyat = 23 };
            Pizzalar tuna = new Pizzalar { PizzaName = "TUNA", PizzaFiyat = 18 };
            Pizzalar seafeed = new Pizzalar { PizzaName = "SEAFEED", PizzaFiyat = 19 };
            Pizzalar kastamonu = new Pizzalar { PizzaName = "KASTAMONU", PizzaFiyat = 20 };
            Pizzalar calypso = new Pizzalar { PizzaName = "CALYPSO", PizzaFiyat = 24 };
            Pizzalar akdeniz = new Pizzalar { PizzaName = "AKDENİZ", PizzaFiyat = 21 };
            Pizzalar karadeniz = new Pizzalar { PizzaName = "KARADENİZ", PizzaFiyat = 21 };

            listPizza.Items.Add(klasik);
            listPizza.Items.Add(karısık);
            listPizza.Items.Add(extravaganza);
            listPizza.Items.Add(ıtalıano);
            listPizza.Items.Add(turkish);
            listPizza.Items.Add(tuna);
            listPizza.Items.Add(seafeed);
            listPizza.Items.Add(kastamonu);
            listPizza.Items.Add(calypso);
            listPizza.Items.Add(akdeniz);
            listPizza.Items.Add(karadeniz);



            #endregion

            #region ObjectKenar

            PizzaKenar ince = new PizzaKenar { KenarTip = " İnce Kenar", KenarFiyat = 0 };
            rdbInce.Tag = ince;   //İnce kenar nesnesini tutuyorum.Sonra butonda istiyicem
            PizzaKenar kalın = new PizzaKenar { KenarTip = "Kalın Kenar", KenarFiyat = 2 };
            rdbKalın.Tag = kalın;

            #endregion


        }
        Siparis s;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizzalar p = (Pizzalar)listPizza.SelectedItem;
            p.EbatAdı = (PizzaEbat)cmbEbat.SelectedItem;
            p.KenarTip = rdbInce.Checked ? (PizzaKenar)
                rdbInce.Tag : (PizzaKenar)rdbKalın.Tag;


            p.Malzemeler = new List<string>();
            foreach (CheckBox ctrl in gbMalzemeler.Controls)
            {
                if(ctrl.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);
                }

            }
            

            decimal hesap = Convert.ToInt32(tbAdet.Text) * p.Hesapla;
            tbTutar.Text = hesap.ToString();

            s = new Siparis();
            s.pizzalar = p;  
            s.PizzaAdet = Convert.ToInt32(tbAdet.Text);

        }

        
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (s!= null)
            {
                listSiparis.Items.Add(s);

            }

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            decimal ToplamTutar = 0;
            int adet = 0;
            foreach (Siparis siparis in listSiparis.Items)
            {
                    ToplamTutar += siparis.PizzaAdet * siparis.pizzalar.Hesapla;
                    adet++;
                


            }

            lblTutar.Text = ToplamTutar.ToString();
            MessageBox.Show(string.Format("Onaylanmış Sipariş Adediniz: {0} \n Toplam Hesabınız: {1} TL", adet, ToplamTutar));


        }


    }
}
