using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Security.Cryptography;
public partial class g_mail_dogrulama : System.Web.UI.Page
{
   
    Cookie cookie = new Cookie();
    Mail mail = new Mail();
    veritabani vt = new veritabani();
    public string aktivasyon_kodu;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if(!IsPostBack)
        {

            Random rnd = new Random();
            aktivasyon_kodu = rnd.Next(10000000).ToString();
            Session["aktivasyon"] = aktivasyon_kodu;

            mail.mail_aktivasyon(cookie.oku("email"), aktivasyon_kodu);
            DataBind();

        }
     
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Session["aktivasyon"].ToString() == aktivasyon.Text)
        {

            string ip_kullanici = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (ip_kullanici == null)
            {
                ip_kullanici = Request.UserHostAddress;
                ip_kullanici = ip_kullanici.Replace("::1", "127.0.0.1");
            }
            string tarayici_bilgi = Request.UserAgent;
            string tarih = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");
            int boyut = tarayici_bilgi.Length;
            string sorgu = "INSERT INTO girisler(hno, tarih, tarayici_bilgisi, IP) VALUES(" + cookie.oku("hno") + ", '" + tarih + "', '" + tarayici_bilgi.Substring(0,50) + "', '" + ip_kullanici + "')";
            vt.Command(sorgu);
            Response.Redirect("g_giris.aspx");

            Session.Abandon();
        
        
        
        }
        else 
        {
            Label1.Text = "Hatalı aktivasyon kodu lütfen doğru kodu giriniz...";
        
        
        }
          
    
    
    
    }
}