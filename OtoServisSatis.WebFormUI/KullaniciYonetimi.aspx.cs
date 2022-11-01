using System;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtoServisSatis.WebFormUI
{
    public partial class KullaniciYonetimi : System.Web.UI.Page
    {

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
            dgvKullanicilar.DataBind();
            cbKullaniciRolu.DataSource = roleManager.GetAll();
            cbKullaniciRolu.DataBind(); // ilk yazıldığında clientside da bilgiler otoservis.entities olarak gelmekte. DataTextField:Adi, DataValueField:Id olarak düzeltildi

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Yukle();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = manager.Add(
                    new Kullanici
                    {
                        Adi = txtKullaniciAdi.Text,
                        Soyadi = txtSoyadi.Text,
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
                    Response.Redirect("KullaniciYonetimi.aspx");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Eklenemedi");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
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
                        Soyadi = txtSoyadi.Text,
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
                        Response.Redirect("KullaniciYonetimi.aspx");
                    }
                }
                else MessageBox("Listeden Güncellemek İstediğiniz Kaydı Seçiniz");

            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Güncellenemedi");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox("Listeden silinecek kaydı seçiniz");
                }
                else
                {
                    int kulId = Convert.ToInt32(lblId.Text);
                    var sonuc = manager.Delete(kulId);
                    if (sonuc > 0)
                    {
                        Response.Redirect("KullaniciYonetimi.aspx");
                    }


                }
            }
            catch (Exception)
            {

                MessageBox("Hata oluştu! Kayıt Silinemedi.");
            }
        }

        protected void dgvKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = dgvKullanicilar.SelectedRow;
                int kulId = Convert.ToInt32(row.Cells[1].Text);
                if (kulId > 0)
                {
                    var kulanici = manager.Find(kulId);
                    txtAdi.Text = kulanici.Adi;
                    txtSoyadi.Text = kulanici.Soyadi;
                    txtEmail.Text = kulanici.Email;
                    txtTelefon.Text = kulanici.Telefon;
                    txtKullaniciAdi.Text = kulanici.KullaniciAdi;
                    txtSifre.Text = kulanici.Sifre;
                    lblEklenmeTarihi.Text = kulanici.EklenmeTarihi.ToString();
                    cbAktif.Checked = kulanici.AktifMi;
                    cbKullaniciRolu.SelectedValue = kulanici.RolId.ToString();
                    lblId.Text = kulanici.Id.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Seçilemedi!");
            }
        }
        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"<script>alert('{mesaj}')</script>");
        }
    }
}