using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarParking
{
    public partial class ÜcretGüncelleme : Form
    {
        public ÜcretGüncelleme()
        {
            InitializeComponent();
         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                var existingRecord = context.Ücret.FirstOrDefault(item => item.id == 1);

                if (existingRecord == null)
                {
                    ArabaÜcretler aü = new ArabaÜcretler();
                    aü.id = 1;
                    context.Ücret.Add(aü);
                    context.SaveChanges();

                }
                else
                {

                }

                var find = context.Ücret.FirstOrDefault(item => item.id > 1);

                if (find != null)
                {
                    context.Ücret.Remove(find);
                    context.SaveChanges();

                }
                else
                {

                }

            }

            if (cmbAraçlar.SelectedItem != null)
            {
                ArabaÜcretler aü = new ArabaÜcretler();
                Context context = new Context();
                string araçTürü = cmbAraçlar.SelectedItem.ToString();

                if (int.TryParse(txtÜcret.Text, out int ücret))
                {
                    var find = context.Ücret.Find(1);

                    switch (araçTürü)
                    {
                        case "Otomobil":
                            find.OtomobilÜcret = ücret;
                            break;
                        case "Kamyon":
                            find.KamyonÜcret = ücret;
                            break;
                        case "Otobüs":
                            find.OtobüsÜcret = ücret;
                            break;
                        case "Motosiklet":
                            find.MotosikletÜcret = ücret;
                            break;
                        case "Arazi Araçları":
                            find.AraziAraçlarıÜcret = ücret;
                            break;
                        default:
                            MessageBox.Show("Geçersiz araç türü seçildi.");
                            return;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Fiyat başarı ile eklenmiştir...");
                }
                else
                {
                    MessageBox.Show("Ücret alanına geçerli bir sayı giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Araç türü seçilmedi.");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtÜcret.Clear();
            cmbAraçlar.Text = "";
        }

        private void ÜcretGüncelleme_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
