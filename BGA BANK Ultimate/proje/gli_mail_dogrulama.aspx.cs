using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gli_mail_dogrulama : System.Web.UI.Page
{
    public string aktivasyon_kodu="";
    Mail mail = new Mail();
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
    Gli_Metot metot = new Gli_Metot();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            Random rnd = new Random();
            aktivasyon_kodu = rnd.Next(10000000).ToString();
            Session["aktivasyon"] = aktivasyon_kodu;

            mail.mail_aktivasyon(Session["mail"].ToString(), aktivasyon_kodu);
            DataBind();

        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Session["aktivasyon"].ToString() == aktivasyon.Text)
        {

            string ip_kullanici = metot.filtre_ip(Request.ServerVariables["HTTP_X_FORWARDED_FOR"]);

            if (ip_kullanici == null)
            {
                ip_kullanici = metot.filtre_ip(Request.UserHostAddress);
                ip_kullanici = ip_kullanici.Replace("::1", "127.0.0.1");
            }
            string tarayici_bilgi = Request.UserAgent;
            string tarih = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");

            //string sorgu = "INSERT INTO girisler(hno, tarih, tarayici_bilgisi, IP) VALUES(" + Session["mail"].ToString() + ", '" + tarih + "', '" + tarayici_bilgi + "', '" + ip_kullanici + "')";
            //vt.Command(sorgu);
            girisler girisler = new girisler();
            girisler.hno = Session["hno"].ToString();
            girisler.IP = ip_kullanici;
            girisler.tarih = tarih;
            girisler.tarayici_bilgisi = tarayici_bilgi;


            db.girislers.InsertOnSubmit(girisler);
            db.SubmitChanges();


            Response.Redirect("gli_giris.aspx");

            Session.Abandon();



        }
        else
        {
            Label1.Text = "Hatalı aktivasyon kodu lütfen doğru kodu giriniz...";


        }




    }


}