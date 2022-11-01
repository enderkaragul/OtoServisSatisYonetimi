using OtoServisSatis.BL;
using System;
using System.Windows.Forms;

namespace OtoServisSatis.WindowsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        KullaniciManager kullaniciManager = new KullaniciManager();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici = kullaniciManager.Get(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.AktifMi == true); // Get, expression (lambda) istiyor
                if (kullanici != null)
                {
                    AnaMenu anaMenu = new AnaMenu();
                    anaMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Başarısız!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
