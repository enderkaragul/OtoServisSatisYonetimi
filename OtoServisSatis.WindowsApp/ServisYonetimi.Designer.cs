namespace OtoServisSatis.WindowsApp
{
    partial class ServisYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvServisler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.txtSaseNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGaranti = new System.Windows.Forms.CheckBox();
            this.dtpServistenCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServisUcreti = new System.Windows.Forms.TextBox();
            this.txtAracSorunu = new System.Windows.Forms.TextBox();
            this.dtpServiseGelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYapilanİslemler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServisler
            // 
            this.dgvServisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisler.Location = new System.Drawing.Point(12, 12);
            this.dgvServisler.Name = "dgvServisler";
            this.dgvServisler.Size = new System.Drawing.Size(1124, 272);
            this.dgvServisler.TabIndex = 1;
            this.dgvServisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServisler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNotlar);
            this.groupBox1.Controls.Add(this.txtSaseNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKasaTipi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAracPlaka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbGaranti);
            this.groupBox1.Controls.Add(this.dtpServistenCikisTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtServisUcreti);
            this.groupBox1.Controls.Add(this.txtAracSorunu);
            this.groupBox1.Controls.Add(this.dtpServiseGelisTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYapilanİslemler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 348);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(821, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Notlar";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(935, 162);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(159, 54);
            this.txtNotlar.TabIndex = 48;
            // 
            // txtSaseNo
            // 
            this.txtSaseNo.Location = new System.Drawing.Point(935, 120);
            this.txtSaseNo.Name = "txtSaseNo";
            this.txtSaseNo.Size = new System.Drawing.Size(159, 20);
            this.txtSaseNo.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(821, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Şase No";
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Location = new System.Drawing.Point(935, 70);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(159, 20);
            this.txtKasaTipi.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(818, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Kasa Tipi";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(935, 29);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(159, 20);
            this.txtModel.TabIndex = 43;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(504, 197);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(184, 20);
            this.txtMarka.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(818, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Marka";
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(504, 150);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(184, 20);
            this.txtAracPlaka.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Araç Plaka";
            // 
            // cbGaranti
            // 
            this.cbGaranti.AutoSize = true;
            this.cbGaranti.Location = new System.Drawing.Point(504, 32);
            this.cbGaranti.Name = "cbGaranti";
            this.cbGaranti.Size = new System.Drawing.Size(140, 17);
            this.cbGaranti.TabIndex = 37;
            this.cbGaranti.Text = "Garanti Kapsamında mi?";
            this.cbGaranti.UseVisualStyleBackColor = true;
            // 
            // dtpServistenCikisTarihi
            // 
            this.dtpServistenCikisTarihi.Location = new System.Drawing.Point(92, 197);
            this.dtpServistenCikisTarihi.Name = "dtpServistenCikisTarihi";
            this.dtpServistenCikisTarihi.Size = new System.Drawing.Size(188, 20);
            this.dtpServistenCikisTarihi.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Çıkış Tarihi";
            // 
            // txtServisUcreti
            // 
            this.txtServisUcreti.Location = new System.Drawing.Point(92, 140);
            this.txtServisUcreti.Name = "txtServisUcreti";
            this.txtServisUcreti.Size = new System.Drawing.Size(188, 20);
            this.txtServisUcreti.TabIndex = 34;
            // 
            // txtAracSorunu
            // 
            this.txtAracSorunu.Location = new System.Drawing.Point(92, 68);
            this.txtAracSorunu.Multiline = true;
            this.txtAracSorunu.Name = "txtAracSorunu";
            this.txtAracSorunu.Size = new System.Drawing.Size(188, 54);
            this.txtAracSorunu.TabIndex = 33;
            // 
            // dtpServiseGelisTarihi
            // 
            this.dtpServiseGelisTarihi.Location = new System.Drawing.Point(92, 29);
            this.dtpServiseGelisTarihi.Name = "dtpServiseGelisTarihi";
            this.dtpServiseGelisTarihi.Size = new System.Drawing.Size(188, 20);
            this.dtpServiseGelisTarihi.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Giriş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Yapılan İşlemler";
            // 
            // txtYapilanİslemler
            // 
            this.txtYapilanİslemler.Location = new System.Drawing.Point(504, 71);
            this.txtYapilanİslemler.Multiline = true;
            this.txtYapilanİslemler.Name = "txtYapilanİslemler";
            this.txtYapilanİslemler.Size = new System.Drawing.Size(184, 54);
            this.txtYapilanİslemler.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Servis Ücreti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Aracın Sorunu";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(635, 274);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(537, 274);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(433, 274);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(814, 274);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "0";
            // 
            // ServisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvServisler);
            this.Name = "ServisYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Yönetimi";
            this.Load += new System.EventHandler(this.ServisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpServiseGelisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYapilanİslemler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtServisUcreti;
        private System.Windows.Forms.TextBox txtAracSorunu;
        private System.Windows.Forms.DateTimePicker dtpServistenCikisTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbGaranti;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.TextBox txtSaseNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKasaTipi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModel;
    }
}