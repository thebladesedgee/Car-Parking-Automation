using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarParking
{
    public partial class Ücret : Form
    {
        public Ücret()
        {
            InitializeComponent();
        }
     



        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            ArabaÜcretler arabaÜcretler = new ArabaÜcretler();
            string plaka = txtPlaka.Text;
            var find = context.Araç.FirstOrDefault(x => x.plaka == plaka);

            if (find != null)
            {
                DateTime çıkış = DateTime.Now;
                lblÇıkışSaati.Text = "ARAÇ ÇIKIŞ SAATİ: " + çıkış.ToString();
                DateTime giriş = DateTime.Parse(find.araçsaatgiriş);
                TimeSpan ts = çıkış - giriş;
                var ücretler =context.Ücret.Find(1);

                int saat = ts.Hours == 0 ? 1 : ts.Hours;
                double ücret = 0;

                switch (find.araçtipi)
                {
                    case "Otomobil":
                        ücret = saat * ücretler.OtomobilÜcret;
                        break;
                    case "Kamyon":
                        ücret = saat * ücretler.KamyonÜcret;
                        break;
                    case "Motosiklet":
                        ücret = saat * ücretler.MotosikletÜcret;
                        break;
                    case "Otobüs":
                        ücret = saat * ücretler.OtobüsÜcret;
                        break;
                    case "Arazi Araçları":
                        ücret = saat * ücretler.AraziAraçlarıÜcret;
                        break;
                    default:
                        break;
                }
             

                find.araçsaatçıkış = çıkış.ToString();
                find.araçucret = ücret.ToString();
                context.SaveChanges();

                lblSaat.Text = ts.Hours.ToString();
                lblÜcret.Text = ücret.ToString("C");
                MessageBox.Show("Ücret Hesaplanmıştır.");






            }
            else
            {
                MessageBox.Show("Lütfen plakayı boş bırakmayınız...");
            }
        }

        private void Ücret_Load(object sender, EventArgs e)
        {

        }

    }
}
