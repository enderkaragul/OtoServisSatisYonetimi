using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        AracManager aracManager = new AracManager();

        void Yukle()
        {
            cbAracId.DataSource = aracManager.GetAll();
            cbAracId.DisplayMember = "Modeli";
            cbAracId.ValueMember = "Id";

            dgvMusteriler.DataSource = manager.GetAll();
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

        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Musteri
                {
                    Adi = txtAdi.Text,
                    Soyadi = txtSoyadi.Text,
                    Email = txtEmail.Text,
                    Telefon = txtEmail.Text,
                    TcNo = txtTcNo.Text,
                    Adres = txtAdres.Text,
                    Notlar = txtNotlar.Text,
                    AracId = Convert.ToInt32(cbAracId.SelectedValue)
                    

                });
                if (sonuc > 0)
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

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var musteri = manager.Find(Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value));
                if (musteri != null)
                {
                    txtAdi.Text = musteri.Adi;
                    txtAdres.Text = musteri.Adres;
                    txtEmail.Text = musteri.Email;
                    txtNotlar.Text = musteri.Notlar;
                    txtSoyadi.Text = musteri.Soyadi;
                    txtTcNo.Text = musteri.TcNo;
                    txtTelefon.Text = musteri.Telefon;
                    cbAracId.SelectedValue = musteri.AracId;
                    lblId.Text = musteri.Id.ToString();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Bilgiler Yüklenemedi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(new Musteri
                    {
                        Id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value),
                        Adi = txtAdi.Text,
                        Soyadi = txtSoyadi.Text,
                        Email = txtEmail.Text,
                        Telefon = txtEmail.Text,
                        TcNo = txtTcNo.Text,
                        Adres = txtAdres.Text,
                        Notlar = txtNotlar.Text,
                        AracId = Convert.ToInt32(cbAracId.SelectedValue)


                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Güncellendi!");
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz!");
                }
                
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
                if (lblId.Text != "0" )
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
