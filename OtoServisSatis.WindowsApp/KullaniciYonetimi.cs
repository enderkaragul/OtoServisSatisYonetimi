using OtoServisSatis.BL;
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
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }


        KullaniciManager manager = new KullaniciManager();
        RoleManager roleManager = new RoleManager();

        void Yukle()
        {
            var ozelSorgu = (from k in manager.GetAllByInclude("Rol")
                select new
                {
                    Id = k.Id,
                    Adı = k.Adi,
                    Soyadı = k.Soyadi,
                    Email = k.Email,
                    Telefon = k.Telefon,
                    Kullanıcı_Adı = k.KullaniciAdi,
                    Durum = k.AktifMi,
                    Eklenme_Tarihi = k.EklenmeTarihi,
                    Rolü = k.Rol.Adi
                }).ToList();



            dgvKullanicilar.DataSource = ozelSorgu;
            //dgvKullanicilar.DataSource = manager.GetAll();
            cbKullaniciRolu.DataSource = roleManager.GetAll();
        }
        private void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtSoydi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;

        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = manager.Add(
                    new Kullanici
                    {
                        Adi = txtKullaniciAdi.Text,
                        Soyadi = txtSoydi.Text,
                        Email = txtEmail.Text,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Sifre = txtSifre.Text,
                        Telefon = txtTelefon.Text,
                        AktifMi = cbAktif.Checked,
                        EklenmeTarihi = DateTime.Now,
                        RolId = int.Parse(cbKullaniciRolu.SelectedValue.ToString())


                    }
                    );
                if (islemSonucu > 0)
                {
                    Yukle();
                    Temizle();
                    MessageBox.Show("Kullanıcı Eklendi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt Eklenemedi");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int kulId = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);
                if (kulId > 0)
                {
                    var kulanici =manager.Find(kulId);
                    txtAdi.Text = kulanici.Adi;
                    txtSoydi.Text = kulanici.Soyadi;
                    txtEmail.Text = kulanici.Email;
                    txtTelefon.Text = kulanici.Telefon;
                    txtKullaniciAdi.Text = kulanici.KullaniciAdi;
                    txtSifre.Text = kulanici.Sifre;
                    lblEklenmeTarihi.Text = kulanici.EklenmeTarihi.ToString();
                    cbAktif.Checked = kulanici.AktifMi;
                    cbKullaniciRolu.SelectedValue = kulanici.RolId;
                    lblId.Text = kulanici.Id.ToString();
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
                    int kulId = Convert.ToInt32(lblId.Text);
                    int islemSonucu = manager.Update(
                    new Kullanici
                    {
                        Id = kulId,
                        Adi = txtKullaniciAdi.Text,
                        Soyadi = txtSoydi.Text,
                        Email = txtEmail.Text,
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Sifre = txtSifre.Text,
                        Telefon = txtTelefon.Text,
                        AktifMi = cbAktif.Checked,
                        EklenmeTarihi = DateTime.Now,
                        RolId = int.Parse(cbKullaniciRolu.SelectedValue.ToString())
                    }
                    );
                    if (islemSonucu > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kullanıcı Güncellendi");
                    }
                }
                else MessageBox.Show("Listeden Güncellemek İstediğiniz Kaydı Seçiniz");

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
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz");
                }
                else
                {
                    int kulId = Convert.ToInt32(lblId.Text);
                    var sonuc = manager.Delete(kulId);
                    if (sonuc > 0)
                    {
                        Yukle();
                        Temizle();
                        MessageBox.Show("Kullanıcı Silindi");
                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu! Kayıt Silinemedi.");
            }
        }
    }
}
