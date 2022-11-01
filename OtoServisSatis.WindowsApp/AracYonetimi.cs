using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class AracYonetimi : Form
    {
        public AracYonetimi()
        {
            InitializeComponent();
        }

        AracManager manager = new AracManager();
        MarkaManager markaManager = new MarkaManager();

        void Yukle()
        {
            dgvAraclar.DataSource = manager.GetAll();
            cbMarka.DataSource = markaManager.GetAll();
            cbMarka.DisplayMember = "Adi";
            cbMarka.ValueMember = "Id";
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
        private void AracYonetimi_Load(object sender, EventArgs e)
        {

            Yukle();
        }

        private void dgvAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvAraclar.CurrentRow.Cells[0].Value.ToString();
                int aracId = Convert.ToInt32(lblId.Text);
                var arac = manager.Find(aracId);
                txtFiyati.Text = arac.Fiyati.ToString();
                txtKasaTip.Text = arac.KasaTipi;
                txtModeli.Text = arac.Modeli;
                txtModelYili.Text = arac.ModelYili.ToString();
                txtNotlar.Text = arac.Notlar;
                txtRenk.Text = arac.Renk;
                cbSatistaMi.Checked = arac.SatistaMi;
                cbMarka.SelectedValue = arac.MarkaId;


            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Seçilemedi ");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Arac
                    {
                        Fiyati = Convert.ToDecimal(txtFiyati.Text),
                        KasaTipi = txtKasaTip.Text,
                        MarkaId = Convert.ToInt32(cbMarka.SelectedValue),
                        Modeli = txtModeli.Text,
                        ModelYili = Convert.ToInt32(txtModelYili.Text),
                        Notlar = txtNotlar.Text,
                        Renk = txtRenk.Text,
                        SatistaMi = cbSatistaMi.Checked

                    });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Eklendi");
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
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz");
                }
                else
                {
                    var sonuc = manager.Update(
                    new Arac
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        Fiyati = Convert.ToDecimal(txtFiyati.Text),
                        KasaTipi = txtKasaTip.Text,
                        MarkaId = Convert.ToInt32(cbMarka.SelectedValue),
                        Modeli = txtModeli.Text,
                        ModelYili = Convert.ToInt32(txtModelYili.Text),
                        Notlar = txtNotlar.Text,
                        Renk = txtRenk.Text,
                        SatistaMi = cbSatistaMi.Checked

                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Güncellendi");
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Güncellenemedi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text ==  "0")
                {
                    MessageBox.Show("Listeden Silinecek Kaydı Seçiniz");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Silinemedi");
            }
        }
    }
}
