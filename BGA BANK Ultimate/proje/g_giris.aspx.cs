using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class g_giris : System.Web.UI.Page
{
    public string _id;
    veritabani vt = new veritabani();
    Metotlar metot = new Metotlar();
    Cookie cookie = new Cookie();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (cookie.cookie_durumu() != 0)
        {



            Label1.Text = "Hoşgeldiniz, " + cookie.oku("adsoyad");
            Label2.Text = cookie.oku("hno");
            _id = cookie.oku("hno");//yönlendirme yapmak için id href atandı
            string sorgu = "select * from musteri where hno=" + cookie.oku("hno");
            SqlDataReader rd = vt.GetDataReader(sorgu);
            DataList1.DataSource = rd;
            DataList1.DataBind();
            sorgu = "select TOP 3 * from girisler where hno=" + cookie.oku("hno")+"order by id DESC";
            rd = vt.GetDataReader(sorgu);
            Repeater1.DataSource = rd;
            Repeater1.DataBind();
        }

        else 
        {

            Response.Redirect("uyari.aspx");
        
        }
    
           

    }

    

}