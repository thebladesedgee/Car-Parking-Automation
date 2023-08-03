using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CarParking
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                string kullaniciAdi = txtKullanıcı.Text;
                string sifre = HashPassword(txtŞifre.Text);

                var existingUser = context.Admin.FirstOrDefault(a => a.kullanıcıadı == kullaniciAdi);
                if (existingUser != null)
                {
                    MessageBox.Show("Bu kullanıcı zaten kayıtlı.");
                    return;
                }

                AdminBilgiler admin = new AdminBilgiler();
                admin.kullanıcıadı = kullaniciAdi;
                admin.şifre = sifre;
                if (!string.IsNullOrEmpty(admin.kullanıcıadı) && !string.IsNullOrEmpty(admin.şifre))
                {
                    context.Admin.Add(admin);
                    context.SaveChanges();
                    MessageBox.Show("Başarı ile kayıt oldunuz");
                    txtKullanıcı.Clear();
                    txtŞifre.Clear();
                }
                else
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız...");
                }
            }


        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2")); 
                }
                return builder.ToString();
            }

        }
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                string kullaniciAdi = txtKullanıcı.Text;
                string sifre = HashPassword(txtŞifre.Text);

                if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
                {
                    var kullanici = context.Admin.FirstOrDefault(k => k.kullanıcıadı == kullaniciAdi && k.şifre == sifre);

                    if (kullanici != null)
                    {
                        
                        MessageBox.Show("Giriş başarılı!");
                        ÜcretGüncelleme üg = new ÜcretGüncelleme();
                        this.Close();
                        üg.ShowDialog();
                        
                   
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız...");
                }
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtŞifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtŞifre.UseSystemPasswordChar = true;
            }
        }

    
      
        private void txtKullanıcı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtŞifre_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
