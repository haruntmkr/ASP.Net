using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gli_atmbul : System.Web.UI.Page
{
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
    Gli_Metot metot = new Gli_Metot();
    public string arama="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["mid"] != null)
        {
          
        }
        else
        {
            Response.Redirect("gli_uyari.aspx");
        }

       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        arama = metot.filtre(TextBox1.Text);   

        var veriler = from veri in db.subelers where veri.ad.Contains(arama.ToString()) select veri;
        subeRepeater.DataSource = veriler;
        subeRepeater.DataBind();



      
    }
}