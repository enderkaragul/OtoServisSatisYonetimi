﻿using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }

        MarkaManager manager = new MarkaManager();
        void Yukle()
        {
            DgvMarkalar.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            lblId.Text = "0";
            txtMarkaAdi.Text = string.Empty;
        }

        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void DgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = DgvMarkalar.CurrentRow.Cells[0].Value.ToString();
                txtMarkaAdi.Text = DgvMarkalar.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = manager.Add(
                    new Marka
                    {
                        Adi = txtMarkaAdi.Text
                    }
                    );
                if (islemSonucu > 0)
                {
                    Yukle();
                    Temizle();
                    MessageBox.Show("Marka Eklendi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    int islemSonucu = manager.Update(
                    new Marka
                    {
                        Id = int.Parse(lblId.Text),
                        Adi = txtMarkaAdi.Text
                    }
                    );
                    if (islemSonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Marka Güncellendi");
                    }
                }
                else MessageBox.Show("Listeden Güncellemek İstediğiniz Kaydı Seçiniz");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try{
                if (lblId.Text != "0")
                {
                var marka = manager.Get(int.Parse(lblId.Text));
                    int islemSonucu = manager.Delete(marka);
                    if (islemSonucu > 0) 
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Marka Silindi");
                    }
                }
                else MessageBox.Show("Listeden Silmek İstediğiniz Kaydı Seçiniz");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi");
            }
        }
    }
}
