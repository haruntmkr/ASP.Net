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
public partial class gli_basvuru : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {



        BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();

        var veri = ((from gelen in db.musteris
                     select new
                     {
                         gelen.hno

                     }
                ).Distinct().OrderByDescending(gelen => gelen.hno).ToList()).First();
        string yeni_hsno = veri.hno.ToString();
        yeni_hsno = Convert.ToString(Convert.ToInt32(yeni_hsno) + 1);
        Random randoms = new Random();
        int sifre = randoms.Next(1000, 10000);
        try
        {
            musteri musteri = new musteri();
            musteri.hno = yeni_hsno;
            musteri.ad = UserName.Text;
            musteri.soyad = soyad.Text;
            musteri.email = email.Text;
            musteri.adres = Adres.Text;
            musteri.plaka = plaka.Text;
            musteri.sifre = sifre.ToString();
            musteri.musteri_tipi = bireyselkurumsal.SelectedValue;
            musteri.tel = tel.Text;
            musteri.firma = firma.Text;
            musteri.hesap = "1000000";
            db.musteris.InsertOnSubmit(musteri);
            db.SubmitChanges();

            string icerik = "BGABANK Ultimate Kullanıcı Bilgileriniz <br/><br/>" + "Ad Soyad:" + UserName.Text +
" " + soyad.Text + "<br/>Müşteri numarası: " + yeni_hsno + "<br/>" + "Şifre: " + sifre;

            Mail mail = new Mail();
            mail.hesapbilgi_gonder(icerik, email.Text);
            Label1.Text = yeni_hsno.ToString();
            /*Hareket oluştur*/
            Gli_Metot metot = new Gli_Metot();
            metot.gli_hareket_olustur("1000000","1000000","Hesap Açma", yeni_hsno.ToString());
            /*hareket oluştur son*/
        }
        catch (Exception ex)
        {
            Label1.Text = "Başvuru alınamadı... " + ex.Message;
        }
        finally
        {

            Response.Redirect("gli_kayitalindi.aspx");


        }







    }

}