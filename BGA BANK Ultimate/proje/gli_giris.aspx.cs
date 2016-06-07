using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class gli_giris : System.Web.UI.Page
{
    public string _id;

    Gli_Metot metot = new Gli_Metot();
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
         

        if (Session["hno"] != null)
        {
            var id_veri = (from idveri in db.musteris where idveri.hno == Session["hno"].ToString() select idveri).First();
            _id = id_veri.hno;//profil resmine yönlendirme yapmak için id hrefe atandı
         
            Label1.Text = "Hoşgeldiniz, " + Session["AdSoyad"];
            Label2.Text = Session["hno"].ToString();
            
            var veri = from veriler in db.musteris where veriler.hno==Session["hno"].ToString() select veriler;
            DataList1.DataSource = veri;
            DataList1.DataBind();

            var veri_ = (from veriler in db.girislers where veriler.hno == Session["hno"].ToString() orderby veriler.id descending select veriler).Take(3);


            Repeater1.DataSource = veri_;
            Repeater1.DataBind();
        }

        else 
        {

            Response.Redirect("gli_uyari.aspx");
        
        }
    
           

    }

    

}