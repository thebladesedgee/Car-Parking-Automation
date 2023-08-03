﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParking
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilgi b = new Bilgi();
            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ücret u = new Ücret();
            u.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.ShowDialog();
        }

        private void Menü_Load(object sender, EventArgs e)
        {

        }
    }
}
