using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;

public partial class gli_gonderi : System.Web.UI.Page
{
    //veritabani vt = new veritabani();
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        var veri = ((from mesajlar in db.iletisim_formu_mesajlaris select mesajlar).Distinct().OrderByDescending(mesajlar => mesajlar.mesaj_id).ToList()).Take(20);

        if (Session["mid"] != null)
        {
           
            Repeater1.DataSource = veri;
            Repeater1.DataBind();
        }
        else
        {
            Response.Redirect("gli_uyari.aspx");
        
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        var yeni_mesaj = from mesajlar in db.iletisim_formu_mesajlaris select mesajlar;
        try
        {
            iletisim_formu_mesajlari iletisim_formu_mesajlari = new iletisim_formu_mesajlari();
            iletisim_formu_mesajlari.adsoyad = AdSoyad.Text;
            iletisim_formu_mesajlari.mesaj = Mesaj.Text;
            iletisim_formu_mesajlari.tarih = DateTime.Now;
            db.iletisim_formu_mesajlaris.InsertOnSubmit(iletisim_formu_mesajlari);
            db.SubmitChanges();

        }
        catch (Exception)
        {
            Literal1.Text = "<div class='alert alert-error'>Mesajınız gönderilmedi... </div>";

        }
        finally
        {
            Literal1.Text = "<div class='alert alert-success'>Mesajınız başarıyla gönderildi... </div>";
            AdSoyad.Text = "";
            Mesaj.Text = "";
        }



      


        }
    }
   
   

