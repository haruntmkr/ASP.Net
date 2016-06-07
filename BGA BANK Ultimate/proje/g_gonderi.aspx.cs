using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class g_gonderi : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    Cookie cookie = new Cookie();
    protected void Page_Load(object sender, EventArgs e)
    {   
        
        if(cookie.cookie_durumu()==0)
        {
            Response.Redirect("uyari.aspx");
        }
        
        if (!IsPostBack)
        { 
        string sorgu = " SELECT TOP 20 mesaj_id,adsoyad,mesaj FROM iletisim_formu_mesajlari ORDER BY mesaj_id DESC";
        SqlDataReader rd = vt.GetDataReader(sorgu);
        Repeater1.DataSource = rd;
        Repeater1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
     
        string adsoyad, mesaj, tarih;
        adsoyad = AdSoyad.Text;
        mesaj = Mesaj.Text;

        tarih =Convert.ToString(DateTime.Now.Year) + "-" + Convert.ToString(DateTime.Now.Month) + "-" + Convert.ToString(DateTime.Now.Day);
        string sorgu = "INSERT INTO iletisim_formu_mesajlari (adsoyad,mesaj,tarih) VALUES ('" + adsoyad + "','" + mesaj + "','" + tarih + "')";
        int query_result = vt.Command(sorgu);

            if (query_result != 0)
            {

                Literal1.Text = "<div class='alert alert-success'>Mesajınız başarıyla gönderildi... </div>";
                AdSoyad.Text = "";
                Mesaj.Text = "";

            }
            else
            {
                Literal1.Text = "<div class='alert alert-error'>Mesajınız başarıyla gönderilmedi... </div>";
           
        
            }


     }
  
}
   
   

