﻿using System;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtoServisSatis.WebFormUI
{
    public partial class AracYonetimi : System.Web.UI.Page
    {
        AracManager manager = new AracManager();
        MarkaManager markaManager = new MarkaManager();

        void Yukle()
        {
            dgvAraclar.DataSource = manager.GetAll();
            dgvAraclar.DataBind();
            ddlMarkalar.DataSource = markaManager.GetAll();
            ddlMarkalar.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) Yukle();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                    new Arac
                    {
                        Fiyati = Convert.ToDecimal(txtFiyati.Text),
                        KasaTipi = txtKasaTipi.Text,
                        MarkaId = Convert.ToInt32(ddlMarkalar.SelectedValue),
                        Modeli = txtModeli.Text,
                        ModelYili = Convert.ToInt32(txtModelYili.Text),
                        Notlar = txtNotlar.Text,
                        Renk = txtRenk.Text,
                        SatistaMi = cbSatistaMi.Checked

                    });
                if (sonuc > 0)
                {
                    Response.Redirect("AracYonetimi.aspx");
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
                if (lblId.Text == "0")
                {
                    MessageBox("Listeden Güncellenecek Kaydı Seçiniz");
                }
                else
                {
                    var sonuc = manager.Update(
                    new Arac
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        Fiyati = Convert.ToDecimal(txtFiyati.Text),
                        KasaTipi = txtKasaTipi.Text,
                        MarkaId = Convert.ToInt32(ddlMarkalar.SelectedValue),
                        Modeli = txtModeli.Text,
                        ModelYili = Convert.ToInt32(txtModelYili.Text),
                        Notlar = txtNotlar.Text,
                        Renk = txtRenk.Text,
                        SatistaMi = cbSatistaMi.Checked

                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("AracYonetimi.aspx");
                    }
                }

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
                    MessageBox("Listeden Silinecek Kaydı Seçiniz");
                }
                else
                {
                    var sonuc = manager.Delete(Convert.ToInt32(lblId.Text));
                    if (sonuc > 0)
                    {
                        Response.Redirect("AracYonetimi.aspx");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Silinemedi");
            }
        }

        protected void dgvAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = dgvAraclar.SelectedRow;

            try
            {
                lblId.Text = row.Cells[1].Text.ToString();
                int aracId = Convert.ToInt32(lblId.Text);
                var arac = manager.Find(aracId);
                txtFiyati.Text = arac.Fiyati.ToString();
                txtKasaTipi.Text = arac.KasaTipi;
                txtModeli.Text = arac.Modeli;
                txtModelYili.Text = arac.ModelYili.ToString();
                txtNotlar.Text = arac.Notlar;
                txtRenk.Text = arac.Renk;
                cbSatistaMi.Checked = arac.SatistaMi;
                ddlMarkalar.SelectedValue = arac.MarkaId.ToString();


            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu! Kayıt Seçilemedi ");
            }



        }

        void MessageBox(string mesaj ="")
        {
            ClientScript.RegisterStartupScript(Page.GetType(),"Uyarı",$"<script>alert('{mesaj}')</script>");
        }

        
    }
}