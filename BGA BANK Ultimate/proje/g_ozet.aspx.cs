using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class g_ozet : System.Web.UI.Page
{
    Metotlar metot = new Metotlar();
    veritabani vt = new veritabani();
    Cookie cookie = new Cookie();

    protected void Page_Load(object sender, EventArgs e)
    {
    
        if (cookie.cookie_durumu() == 1)
        {

            string _id = Request.QueryString.Get("id");//id g_giris.aspx sayfasından geliyor. Eğer hataya düşerse bu sayfadan gelmediği içindir
            //çünkü g_giris.aspx sayfasında id tanımlı oradan alması gerekli
            string sorgu = "select hno,hesap,email,tel from musteri where hno=" + _id;
            
            SqlDataReader rd = vt.GetDataReader(sorgu);
            Label1.Text = cookie.oku("adsoyad");
            DataList1.DataSource = rd;
            DataList1.DataBind();
            Repeater1.DataSource =metot.hareket_oku(_id);
            Repeater1.DataBind();
            Label2.Text = _id;


           

        }
        else
        {

            Response.Redirect("uyari.aspx");

        }
    
    
    }

    public String detaylar(string aciklama,string miktar1,string miktar2,string hno2 ,string tarih) 
    {

        int son_miktar = Convert.ToInt32(miktar1) - Convert.ToInt32(miktar2);
        string tablo;
        tablo = "<th>" + aciklama + "</th>" + "<th>" + tarih + "</th>" +"<th>"+hno2+"</th>"+ "<th>" + son_miktar.ToString() + "</th>";// +"<th>" + "<th>";
        
        return tablo;
    
    }
}