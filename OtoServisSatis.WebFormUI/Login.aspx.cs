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
    public partial class Login : System.Web.UI.Page
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var kullanici = kullaniciManager.Get(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text && k.AktifMi == true); // Get, expression (lambda) istiyor
                if (kullanici != null)
                {
                    Session["admin"] = kullanici;
                    Response.Redirect("AnaMenu.aspx");
                }
                else
                {
                    MessageBox("Kullanıcı Girişi Başarısız!");
                }
            }
            catch (Exception)
            {

                MessageBox("Hata Oluştu!");
            }
        }
        void MessageBox(string mesaj = "")
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "Uyarı", $"<script>alert('{mesaj}')</script>");
        }
    }
}