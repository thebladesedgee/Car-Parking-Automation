namespace CarParking
{
    partial class Bilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgi));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAraçModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAraçMarka = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAraçTipi = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAKA";
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıt.Location = new System.Drawing.Point(409, 46);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(106, 455);
            this.btnKayıt.TabIndex = 2;
            this.btnKayıt.Text = "KAYDET";
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbAraçModel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbAraçMarka);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAraçTipi);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(50, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Araç Model";
            // 
            // cmbAraçModel
            // 
            this.cmbAraçModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAraçModel.FormattingEnabled = true;
            this.cmbAraçModel.Items.AddRange(new object[] {
            "Corolla",
            "Camry",
            "RAV4",
            "Prius",
            "Highlander",
            "Tacoma",
            "Sienna",
            "4Runner",
            "Yaris",
            "Land Cruiser",
            "Civic",
            "Accord",
            "CR-V",
            "Pilot",
            "HR-V",
            "Odyssey",
            "Ridgeline",
            "Fit",
            "Passport",
            "Insight",
            "Mustang",
            "F-150",
            "Escape",
            "Focus",
            "Explorer",
            "Edge",
            "Fusion",
            "Ranger",
            "Expedition",
            "Fiesta",
            "Silverado",
            "Equinox",
            "Traverse",
            "Malibu",
            "Tahoe",
            "Suburban",
            "Camaro",
            "Corvette",
            "Impala",
            "Trax",
            "Altima",
            "Rogue",
            "Sentra",
            "Pathfinder",
            "Murano",
            "Maxima",
            "Frontier",
            "Titan",
            "Kicks",
            "Versa",
            "Golf",
            "Jetta",
            "Passat",
            "Tiguan",
            "Atlas",
            "Arteon",
            "Beetle",
            "Touareg",
            "Atlas Cross Sport",
            "Golf GTI",
            "3 Series",
            "5 Series",
            "X3",
            "X5",
            "X1",
            "7 Series",
            "2 Series",
            "4 Series",
            "X7",
            "i3",
            "C-Class",
            "E-Class",
            "GLC",
            "GLE",
            "A-Class",
            "S-Class",
            "GLA",
            "CLA",
            "GLB",
            "GLS",
            "A4",
            "Q5",
            "Q7",
            "A3",
            "Q3",
            "A6",
            "A5",
            "Q8",
            "A7",
            "RS 5",
            "Elantra",
            "Sonata",
            "Santa Fe",
            "Tucson",
            "Kona",
            "Palisade",
            "Accent",
            "Veloster",
            "Ioniq",
            "Venue",
            "Forte",
            "Optima",
            "Sorento",
            "Sportage",
            "Soul",
            "Telluride",
            "Rio",
            "Stinger",
            "Carnival/Sedona",
            "K5",
            "Picanto",
            "Outback",
            "Forester",
            "Impreza",
            "Crosstrek",
            "Legacy",
            "WRX",
            "Ascent",
            "BRZ",
            "Model S",
            "Model 3",
            "Model X",
            "Model Y",
            "Cybertruck",
            "Roadster",
            "Mazda3",
            "Mazda6",
            "CX-5",
            "CX-9",
            "CX-30",
            "MX-5 Miata",
            "Outlander",
            "Eclipse Cross",
            "Mirage",
            "ASX (RVR/Outlander Sport)",
            "Pajero (Montero/Shogun)",
            "Clio",
            "Megane",
            "Captur",
            "Koleos",
            "Zoe",
            "Fluence",
            "208",
            "308",
            "2008",
            "3008",
            "5008",
            "500",
            "Panda",
            "Tipo",
            "500X",
            "500L",
            "Egea",
            "Cross",
            "Corsa",
            "Astra",
            "Crossland",
            "Grandland",
            "Mokka",
            "Octavia",
            "Superb",
            "Kamiq",
            "Kodiaq",
            "Scala",
            "XC60",
            "XC90",
            "S60",
            "V60",
            "XC40",
            "911",
            "Cayenne",
            "Panamera",
            "Macan",
            "Taycan",
            "F-Type",
            "XE",
            "XF",
            "E-Pace",
            "F-Pace",
            "Range Rover",
            "Range Rover Sport",
            "Discovery",
            "Defender",
            "Range Rover Velar",
            "ES",
            "RX",
            "NX",
            "LS",
            "UX",
            "Escalade",
            "XT5",
            "CT4",
            "CT5",
            "XT6",
            "Giulia",
            "Stelvio",
            "Giulietta",
            "TLX",
            "MDX",
            "RDX",
            "DB11",
            "Vantage",
            "DBS Superleggera",
            "Continental GT",
            "Bentayga",
            "Flying Spur",
            "Chiron",
            "Divo",
            "Encore",
            "Enclave",
            "Regal",
            "300",
            "Pacifica",
            "Charger",
            "Challenger",
            "Durango",
            "488 GTB",
            "F8 Tributo",
            "Portofino",
            "G70",
            "G80",
            "G90",
            "Q50",
            "QX60",
            "QX80",
            "Grand Cherokee",
            "Wrangler",
            "Cherokee",
            "Aventador",
            "Huracan",
            "Urus",
            "Ghibli",
            "Quattroporte",
            "Levante",
            "Cooper",
            "Countryman",
            "Clubman",
            "370Z",
            "Armada",
            "Leaf",
            "Phantom",
            "Ghost",
            "Cullinan",
            "Fortwo",
            "Forfour",
            "Swift",
            "Vitara",
            "Jimny",
            "Tiago",
            "Nexon",
            "Harrier",
            "Supra",
            "Land Cruiser Prado",
            "Aygo",
            "Arteon Shooting Brake",
            "Passat Variant",
            "ID.4",
            "V90",
            "XC60 Recharge",
            "C40 Recharge"});
            this.cmbAraçModel.Location = new System.Drawing.Point(118, 268);
            this.cmbAraçModel.Name = "cmbAraçModel";
            this.cmbAraçModel.Size = new System.Drawing.Size(183, 28);
            this.cmbAraçModel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Araç Marka";
            // 
            // cmbAraçMarka
            // 
            this.cmbAraçMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAraçMarka.FormattingEnabled = true;
            this.cmbAraçMarka.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Dodge",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jaguar",
            "Jeep",
            "Kia",
            "Land Rover",
            "Lexus",
            "Mazda",
            "Mercedes-Benz",
            "Mitsubishi",
            "Nissan",
            "Opel",
            "Peugeot",
            "Porsche",
            "Renault",
            "Skoda",
            "Subaru",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cmbAraçMarka.Location = new System.Drawing.Point(118, 216);
            this.cmbAraçMarka.Name = "cmbAraçMarka";
            this.cmbAraçMarka.Size = new System.Drawing.Size(183, 28);
            this.cmbAraçMarka.Sorted = true;
            this.cmbAraçMarka.TabIndex = 6;
            this.cmbAraçMarka.SelectedIndexChanged += new System.EventHandler(this.cmbAraçMarka_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Araç Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // cmbAraçTipi
            // 
            this.cmbAraçTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAraçTipi.FormattingEnabled = true;
            this.cmbAraçTipi.Items.AddRange(new object[] {
            "Otomobil",
            "Kamyon",
            "Otobüs",
            "Motosiklet",
            "Arazi Araçları"});
            this.cmbAraçTipi.Location = new System.Drawing.Point(118, 162);
            this.cmbAraçTipi.Name = "cmbAraçTipi";
            this.cmbAraçTipi.Size = new System.Drawing.Size(183, 28);
            this.cmbAraçTipi.TabIndex = 2;
            this.cmbAraçTipi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(118, 115);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(183, 26);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(118, 61);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(183, 26);
            this.txtAd.TabIndex = 0;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(6, 25);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSaat.Size = new System.Drawing.Size(383, 24);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "ARAÇ GİRİŞ SAATİ: gg/aa/yyyy 00:00:00";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblSaat);
            this.groupBox2.Location = new System.Drawing.Point(58, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Gold;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(222, 613);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(129, 50);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(58, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(386, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(168, 46);
            this.txtPlaka.Multiline = true;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(208, 53);
            this.txtPlaka.TabIndex = 9;
            // 
            // Bilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(580, 724);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.Bilgi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAraçTipi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAraçModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAraçMarka;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPlaka;
    }
}

