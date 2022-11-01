using System;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System.Linq;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class ServisYonetimi : Form
    {
        public ServisYonetimi()
        {
            InitializeComponent();
        }
        ServisManager manager = new ServisManager();

        void Yukle()
        {
            dgvServisler.DataSource = manager.GetAll();
        }

        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>(); // Groupbox içindeki textboxları bir nesneler değişkenine atayıp, aşağıda foreach döngüsü ile siler
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            lblId.Text = "0";
        }

        private void ServisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
            Temizle();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Servis
                    {
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu= txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.Value,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.Value,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        Yapilanİslemler = txtYapilanİslemler.Text
                    });
                if (sonuc >0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Eklendi!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi!");
            }
        }

        private void dgvServisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var servis = manager.Find(Convert.ToInt32(dgvServisler.CurrentRow.Cells[0].Value));
                if (servis != null)
                {
                    txtAracPlaka.Text = servis.AracPlaka;
                    txtAracSorunu.Text = servis.AracSorunu;
                    cbGaranti.Checked = servis.GarantiKapsamindaMi;
                    txtKasaTipi.Text = servis.KasaTipi;
                    txtMarka.Text = servis.Marka;
                    txtModel.Text = servis.Model;
                    txtNotlar.Text = servis.Notlar;
                    txtSaseNo.Text = servis.SaseNo;
                    dtpServiseGelisTarihi.Value = servis.ServiseGelisTarihi;
                    dtpServistenCikisTarihi.Value = servis.ServistenCikisTarihi;
                    txtServisUcreti.Text = servis.ServisUcreti.ToString();
                    txtYapilanİslemler.Text = servis.Yapilanİslemler;
                    lblId.Text = servis.Id.ToString();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Seçilemedi!");
            }
        }

      
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(
                    new Servis
                    {
                        Id = Convert.ToInt32(dgvServisler.CurrentRow.Cells[0].Value),
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu = txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.Value,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.Value,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        Yapilanİslemler = txtYapilanİslemler.Text
                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Güncellendi!");
                    }
                    
                    
                }
                else MessageBox.Show("Lİsteden Güncellenecek Kaydı Seçiniz!");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Silinecek Kaydı Seçiniz!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

    }

        
}

