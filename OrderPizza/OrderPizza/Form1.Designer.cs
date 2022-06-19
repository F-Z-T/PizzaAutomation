
namespace OrderPizza
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbInce = new System.Windows.Forms.RadioButton();
            this.rdbKalın = new System.Windows.Forms.RadioButton();
            this.gbMalzemeler = new System.Windows.Forms.GroupBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdet = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.listSiparis = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listPizza = new System.Windows.Forms.ListBox();
            this.gbMalzemeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEbat
            // 
            this.cmbEbat.BackColor = System.Drawing.Color.OldLace;
            this.cmbEbat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEbat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEbat.ForeColor = System.Drawing.Color.Brown;
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(20, 86);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(530, 39);
            this.cmbEbat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Ebatları :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(27, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza Cesitleri :";
            // 
            // rdbInce
            // 
            this.rdbInce.BackColor = System.Drawing.Color.OldLace;
            this.rdbInce.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInce.ForeColor = System.Drawing.Color.Brown;
            this.rdbInce.Location = new System.Drawing.Point(350, 173);
            this.rdbInce.Name = "rdbInce";
            this.rdbInce.Size = new System.Drawing.Size(200, 40);
            this.rdbInce.TabIndex = 4;
            this.rdbInce.TabStop = true;
            this.rdbInce.Text = "Ince Kenar";
            this.rdbInce.UseVisualStyleBackColor = false;
            // 
            // rdbKalın
            // 
            this.rdbKalın.BackColor = System.Drawing.Color.OldLace;
            this.rdbKalın.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKalın.ForeColor = System.Drawing.Color.Brown;
            this.rdbKalın.Location = new System.Drawing.Point(350, 219);
            this.rdbKalın.Name = "rdbKalın";
            this.rdbKalın.Size = new System.Drawing.Size(200, 40);
            this.rdbKalın.TabIndex = 5;
            this.rdbKalın.TabStop = true;
            this.rdbKalın.Text = "Kalın Kenar";
            this.rdbKalın.UseVisualStyleBackColor = false;
            // 
            // gbMalzemeler
            // 
            this.gbMalzemeler.BackColor = System.Drawing.Color.OldLace;
            this.gbMalzemeler.Controls.Add(this.checkBox11);
            this.gbMalzemeler.Controls.Add(this.checkBox7);
            this.gbMalzemeler.Controls.Add(this.checkBox8);
            this.gbMalzemeler.Controls.Add(this.checkBox9);
            this.gbMalzemeler.Controls.Add(this.checkBox10);
            this.gbMalzemeler.Controls.Add(this.checkBox6);
            this.gbMalzemeler.Controls.Add(this.checkBox5);
            this.gbMalzemeler.Controls.Add(this.checkBox4);
            this.gbMalzemeler.Controls.Add(this.checkBox3);
            this.gbMalzemeler.Controls.Add(this.checkBox1);
            this.gbMalzemeler.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMalzemeler.ForeColor = System.Drawing.Color.Brown;
            this.gbMalzemeler.Location = new System.Drawing.Point(20, 327);
            this.gbMalzemeler.Name = "gbMalzemeler";
            this.gbMalzemeler.Size = new System.Drawing.Size(299, 254);
            this.gbMalzemeler.TabIndex = 6;
            this.gbMalzemeler.TabStop = false;
            this.gbMalzemeler.Text = "Malzemeler";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(159, 192);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(89, 24);
            this.checkBox11.TabIndex = 18;
            this.checkBox11.Text = "Peynir";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(159, 154);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(94, 24);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = "Mantar";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(159, 115);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(87, 24);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "Sucuk";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(159, 74);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(84, 24);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "Salam";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(159, 32);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(88, 24);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Text = "Zeytin";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(12, 192);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(95, 24);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "Ançuez";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 154);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(75, 24);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Mısır";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 116);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 24);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Sosis";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(118, 24);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Ton Balıgı";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Dana Jambon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(347, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAdet
            // 
            this.tbAdet.BackColor = System.Drawing.Color.OldLace;
            this.tbAdet.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdet.ForeColor = System.Drawing.Color.Brown;
            this.tbAdet.Location = new System.Drawing.Point(465, 282);
            this.tbAdet.Name = "tbAdet";
            this.tbAdet.Size = new System.Drawing.Size(85, 38);
            this.tbAdet.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.AutoSize = true;
            this.btnHesapla.BackColor = System.Drawing.Color.OldLace;
            this.btnHesapla.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Brown;
            this.btnHesapla.Location = new System.Drawing.Point(350, 361);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 50);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(351, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tutar :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTutar
            // 
            this.tbTutar.BackColor = System.Drawing.Color.OldLace;
            this.tbTutar.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTutar.ForeColor = System.Drawing.Color.Brown;
            this.tbTutar.Location = new System.Drawing.Point(466, 454);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(84, 38);
            this.tbTutar.TabIndex = 11;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.OldLace;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.Brown;
            this.btnSepeteEkle.Location = new System.Drawing.Point(356, 526);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(200, 50);
            this.btnSepeteEkle.TabIndex = 12;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // listSiparis
            // 
            this.listSiparis.BackColor = System.Drawing.Color.OldLace;
            this.listSiparis.ForeColor = System.Drawing.Color.Brown;
            this.listSiparis.FormattingEnabled = true;
            this.listSiparis.HorizontalScrollbar = true;
            this.listSiparis.ItemHeight = 16;
            this.listSiparis.Location = new System.Drawing.Point(589, 83);
            this.listSiparis.Name = "listSiparis";
            this.listSiparis.Size = new System.Drawing.Size(473, 324);
            this.listSiparis.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(604, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 50);
            this.label5.TabIndex = 14;
            this.label5.Text = "Toplam Tutar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTutar
            // 
            this.lblTutar.BackColor = System.Drawing.Color.OldLace;
            this.lblTutar.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutar.ForeColor = System.Drawing.Color.Brown;
            this.lblTutar.Location = new System.Drawing.Point(857, 442);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(200, 50);
            this.lblTutar.TabIndex = 15;
            this.lblTutar.Text = "0.0";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.OldLace;
            this.btnOnay.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnay.ForeColor = System.Drawing.Color.Brown;
            this.btnOnay.Location = new System.Drawing.Point(680, 523);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(297, 52);
            this.btnOnay.TabIndex = 16;
            this.btnOnay.Text = "Siparisi Onayla";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(584, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(473, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "Siparisler";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listPizza
            // 
            this.listPizza.BackColor = System.Drawing.Color.OldLace;
            this.listPizza.FormattingEnabled = true;
            this.listPizza.ItemHeight = 16;
            this.listPizza.Location = new System.Drawing.Point(21, 173);
            this.listPizza.Name = "listPizza";
            this.listPizza.Size = new System.Drawing.Size(287, 132);
            this.listPizza.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1108, 661);
            this.Controls.Add(this.listPizza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSiparis);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.tbTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbMalzemeler);
            this.Controls.Add(this.rdbKalın);
            this.Controls.Add(this.rdbInce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEbat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OrderPizza";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMalzemeler.ResumeLayout(false);
            this.gbMalzemeler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbInce;
        private System.Windows.Forms.RadioButton rdbKalın;
        private System.Windows.Forms.GroupBox gbMalzemeler;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox listSiparis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listPizza;
    }
}

