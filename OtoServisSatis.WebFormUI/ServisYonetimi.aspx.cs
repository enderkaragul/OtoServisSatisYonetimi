﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;

namespace OtoServisSatis.WebFormUI
{
    public partial class ServisYonetimi : System.Web.UI.Page
    {
        ServisManager manager = new ServisManager();

        

        void Yukle()
        {
            dgvServisler.DataSource = manager.GetAll();
            dgvServisler.DataBind();

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
                    new Servis
                    {
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu = txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.SelectedDate ,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.SelectedDate,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        Yapilanİslemler = txtYapilanİslemler.Text
                    });
                if (sonuc > 0)
                {
                    Response.Redirect("ServisYonetimi.aspx");
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
                    var sonuc = manager.Update(
                    new Servis
                    {
                        Id = Convert.ToInt32(lblId.Text),
                        AracPlaka = txtAracPlaka.Text,
                        AracSorunu = txtAracSorunu.Text,
                        GarantiKapsamindaMi = cbGaranti.Checked,
                        KasaTipi = txtKasaTipi.Text,
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        Notlar = txtNotlar.Text,
                        SaseNo = txtSaseNo.Text,
                        ServiseGelisTarihi = dtpServiseGelisTarihi.SelectedDate,
                        ServistenCikisTarihi = dtpServistenCikisTarihi.SelectedDate,
                        ServisUcreti = Convert.ToDecimal(txtServisUcreti.Text),
                        Yapilanİslemler = txtYapilanİslemler.Text
                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("ServisYonetimi.aspx");
                    }


                }
                else MessageBox("Lİsteden Güncellenecek Kaydı Seçiniz!");

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
                        Response.Redirect("ServisYonetimi.aspx");
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

        protected void dgvServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = dgvServisler.SelectedRow;
            try
            {
                var servis = manager.Find(Convert.ToInt32(row.Cells[1].Text));
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
                    dtpServiseGelisTarihi.SelectedDate = servis.ServiseGelisTarihi;
                    dtpServistenCikisTarihi.SelectedDate = servis.ServistenCikisTarihi;
                    txtServisUcreti.Text = servis.ServisUcreti.ToString();
                    txtYapilanİslemler.Text = servis.Yapilanİslemler;
                    lblId.Text = servis.Id.ToString();
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