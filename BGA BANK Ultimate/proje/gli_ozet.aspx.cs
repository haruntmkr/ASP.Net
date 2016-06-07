using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class gli_ozet : System.Web.UI.Page
{
    

    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
    Gli_Metot metot = new Gli_Metot();
    string _id ;

    protected void Page_Load(object sender, EventArgs e)
    {
        _id = Request.QueryString.Get("id");
        if(!IsPostBack){
       
        if (Session["mid"] != null)
        {
            var veri = from veriler in db.musteris where veriler.hno == Session["hno"].ToString() select veriler;


            /*string sorgu = "select hno,hesap,email,tel from musteri where hno=" + _id;
            
            SqlDataReader rd = vt.GetDataReader(sorgu);*/
            Label1.Text = Session["AdSoyad"].ToString();
            DataList1.DataSource = veri;
            DataList1.DataBind();
            Repeater1.DataSource = metot.gli_hareket_oku(Session["hno"].ToString());
            Repeater1.DataBind();
            Label2.Text = Session["hno"].ToString();


           

        }
        else
        {

            Response.Redirect("gli_uyari.aspx");

        }
    
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