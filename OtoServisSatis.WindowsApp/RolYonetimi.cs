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
    public partial class RolYonetimi : Form
    {
        public RolYonetimi()
        {
            InitializeComponent();
        }
        RoleManager manager = new RoleManager();

        void Yukle()
        {
            dgvRoller.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtRolAdi.Text = string.Empty;
            lblId.Text = "0";
        }


        private void RolYonenitimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Rol
                    {
                        Adi = txtRolAdi.Text
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

        private void dgvRoller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // int rolId = Convert.ToInt32(dgvRoller.CurrentRow.Cells[0].Value); Sadece ID ve Rol adı içi olduğu için 

                lblId.Text = dgvRoller.CurrentRow.Cells[0].Value.ToString();
                txtRolAdi.Text = dgvRoller.CurrentRow.Cells[1].Value.ToString();
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
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Listeden Güncellenecek Kaydı Seçiniz");
                }
                else
                {
                    int rolId = Convert.ToInt32(dgvRoller.CurrentRow.Cells[0].Value);
                    var sonuc = manager.Update(
                        new Rol
                        {
                            Id = rolId,
                            Adi = txtRolAdi.Text
                        });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Güncellendi!");
                    }
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
                if (lblId.Text == "0")
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

                MessageBox.Show("Kayıt Silinemedi!");
            }
        }
    }
}
