namespace OtoServisSatis.WindowsApp
{
    partial class MarkaYonetimi
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
            this.DgvMarkalar = new System.Windows.Forms.DataGridView();
            this.groupBoxMarka = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarkalar)).BeginInit();
            this.groupBoxMarka.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvMarkalar
            // 
            this.DgvMarkalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMarkalar.Location = new System.Drawing.Point(12, 12);
            this.DgvMarkalar.Name = "DgvMarkalar";
            this.DgvMarkalar.Size = new System.Drawing.Size(340, 339);
            this.DgvMarkalar.TabIndex = 0;
            this.DgvMarkalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarkalar_CellClick);
            // 
            // groupBoxMarka
            // 
            this.groupBoxMarka.Controls.Add(this.btnSil);
            this.groupBoxMarka.Controls.Add(this.btnGuncelle);
            this.groupBoxMarka.Controls.Add(this.btnEkle);
            this.groupBoxMarka.Controls.Add(this.txtMarkaAdi);
            this.groupBoxMarka.Controls.Add(this.lblId);
            this.groupBoxMarka.Controls.Add(this.label1);
            this.groupBoxMarka.Location = new System.Drawing.Point(394, 12);
            this.groupBoxMarka.Name = "groupBoxMarka";
            this.groupBoxMarka.Size = new System.Drawing.Size(394, 339);
            this.groupBoxMarka.TabIndex = 1;
            this.groupBoxMarka.TabStop = false;
            this.groupBoxMarka.Text = "Marka Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(244, 161);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(118, 161);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 161);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(93, 39);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaAdi.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(270, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // MarkaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxMarka);
            this.Controls.Add(this.DgvMarkalar);
            this.Name = "MarkaYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Yönetimi";
            this.Load += new System.EventHandler(this.MarkaYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarkalar)).EndInit();
            this.groupBoxMarka.ResumeLayout(false);
            this.groupBoxMarka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMarkalar;
        private System.Windows.Forms.GroupBox groupBoxMarka;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}