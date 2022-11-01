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
    public partial class MusteriYonetimi : System.Web.UI.Page
    {
        MusteriManager manager = new MusteriManager();
        AracManager aracManager = new AracManager();
        void Yukle()
        {
            cbAracId.DataSource = aracManager.GetAll();
            cbAracId.DataTextField = "Modeli";
            cbAracId.DataValueField = "Id";
            cbAracId.DataBind();

            dgvMusteriler.DataSource = manager.GetAll();
            dgvMusteriler.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Yukle();

        }

        protected void btnEkle_Click(object sender, EventArgs e)
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
                    Response.Redirect("MusteriYonetimi.aspx");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Eklenemedi!");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Update(new Musteri
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        Adi = txtAdi.Text,
                        Soyadi = txtSoyadi.Text,
                        Email = txtEmail.Text,
                        Telefon = txtEmail.Text,
                        TcNo = txtTcNo.Text,
                        Adres = txtAdres.Text,
                        Notlar = txtNotlar.Text,
                        AracId = Convert.ToInt32(cbAracId.Text)


                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("MusteriYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Listeden Güncellenecek Kaydı Seçiniz!");
                }

            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Güncellenemedi!");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Response.Redirect("MusteriYonetimi.aspx");
                    }
                }
                else
                {
                    MessageBox("Listeden Silinecek Kaydı Seçiniz!");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Silinemedi!");
            }
        }

        protected void dgvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                GridViewRow row = dgvMusteriler.SelectedRow;
                var musteri = manager.Find(Convert.ToInt32(row.Cells[1].Text));
                if (musteri != null)
                {
                    txtAdi.Text = musteri.Adi;
                    txtAdres.Text = musteri.Adres;
                    txtEmail.Text = musteri.Email;
                    txtNotlar.Text = musteri.Notlar;
                    txtSoyadi.Text = musteri.Soyadi;
                    txtTcNo.Text = musteri.TcNo;
                    txtTelefon.Text = musteri.Telefon;
                    cbAracId.SelectedValue = musteri.AracId.ToString();
                    lblId.Text = row.Cells[1].Text.ToString();
                }

            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Bilgiler Yüklenemedi!");
            }
        }

        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"<script>alert('{mesaj}')</script>");
        }
    }
}