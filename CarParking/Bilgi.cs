using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParking
{
    public partial class Bilgi : Form
    {
        public Bilgi()
        {
            InitializeComponent();
 

        }
        Context context = new Context();
        Bilgiler bilgi = new Bilgiler();
        DateTime giriş;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
       
        private void btnKayıt_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPlaka.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) &&
        !string.IsNullOrEmpty(cmbAraçTipi.Text) && !string.IsNullOrEmpty(cmbAraçMarka.Text) && !string.IsNullOrEmpty(cmbAraçModel.Text))
            {
                bilgi.plaka = txtPlaka.Text;
                bilgi.ad = txtAd.Text;
                bilgi.soyad = txtSoyad.Text;
                bilgi.araçtipi = cmbAraçTipi.Text;
                bilgi.araçmarka = cmbAraçMarka.Text;
                bilgi.araçmodel = cmbAraçModel.Text;
                giriş = DateTime.Now;
                lblSaat.Text = "ARAÇ GİRİŞ SAATİ: " + giriş.ToString();
                bilgi.araçsaatgiriş = giriş.ToString();
                context.Araç.Add(bilgi);
                context.SaveChanges();
                MessageBox.Show("Veriler Başarı ile Kayıt Edildi");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            if (!string.IsNullOrEmpty(plaka))
            {
                var find = context.Araç.FirstOrDefault(x => x.plaka == plaka);
                if (find != null)
                {
                    find.plaka = txtPlaka.Text;
                    find.ad = txtAd.Text;
                    find.soyad = txtSoyad.Text;
                    find.araçtipi = cmbAraçTipi.Text;
                    find.araçmarka = cmbAraçMarka.Text;
                    find.araçmodel = cmbAraçModel.Text;
                    giriş = DateTime.Now;
                    find.araçsaatgiriş = giriş.ToString();
                    context.SaveChanges();
                    MessageBox.Show("Verileriniz Güncellenmiştir.");
                }
                else
                {
                    MessageBox.Show("Belirtilen plakaya sahip araç kaydı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir plaka giriniz.");
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            var find = context.Araç.FirstOrDefault(x => x.plaka == plaka);

            if (find != null)
            {
                txtAd.Text = find.ad;
                txtSoyad.Text = find.soyad;
                cmbAraçTipi.Text = find.araçtipi;
                cmbAraçMarka.Text = find.araçmarka;
                cmbAraçModel.Text = find.araçmodel;
                lblSaat.Text = "ARAÇ GİRİŞ SAATİ: " + find.araçsaatgiriş;
            }
            else
            {
                MessageBox.Show("Belirtilen plakaya sahip araç kaydı bulunamadı.");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            var find = context.Araç.FirstOrDefault(x => x.plaka == plaka);

            if (find != null)
            {
                context.Araç.Remove(find);
                context.SaveChanges();
                MessageBox.Show("Verileriniz Silinmiştir.");
            }
            else
            {
                MessageBox.Show("Belirtilen plakaya sahip araç kaydı bulunamadı.");
            }

            txtPlaka.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cmbAraçTipi.Text = "";
            cmbAraçMarka.Text = "";
            cmbAraçModel.Text = "";
            lblSaat.Text = "ARAÇ GİRİŞ SAATİ: gg/aa/yyyy 00:00:00";




        }

        private void Bilgi_Load(object sender, EventArgs e)
        {
          
        }

        private void cmbAraçMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
