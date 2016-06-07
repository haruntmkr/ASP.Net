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

public partial class gli_paratrans : System.Web.UI.Page
{
    Gli_Metot metot = new Gli_Metot();
        
    protected void Page_Load(object sender, EventArgs e)
    {

        Literal1.Visible = false;
        if (Session["mid"] != null)
        {
            if (!IsPostBack)
            {


                Repeater1.DataSource = metot.gli_hareket_oku(Session["hno"].ToString());
                Repeater1.DataBind();

            }
        }

        else
        {

            Response.Redirect("gli_uyari.aspx");

        }
       
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //eski hesap bilgisi
        BGABANKUltimateDataContext bga = new BGABANKUltimateDataContext();
        var drop = (from kisiler in bga.musteris
                    where kisiler.hno == Session["hno"].ToString()
                   select kisiler).First();
        int eski_hesap = Int32.Parse(drop.hesap);

        //eski hesap bilgisi 

        string giden_hesap;
        int miktar;
        giden_hesap = TextBox1.Text;
        miktar = Int32.Parse(TextBox2.Text);

        try
        {
          var dus = (from kisiler in bga.musteris
                        where kisiler.hno == Session["hno"].ToString()
                        select kisiler).First();
        dus.hesap = Convert.ToString(eski_hesap - miktar);
        bga.SubmitChanges();
    
        var ekle = (from kisiler in bga.musteris
                    where kisiler.hno == giden_hesap
                    select kisiler).First();
        ekle.hesap = Convert.ToString(eski_hesap + miktar);
        bga.SubmitChanges();



        }
        catch(Exception)
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-important'>Havale yapılamadı.</span>";

        }
        finally
        {
            
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-success'>Havale başarılı şekilde gerçekleşmiştir.</span>";
        }

        
        int guncel_hesap = Convert.ToInt32(eski_hesap) - Convert.ToInt32(miktar);
            


      

        metot.gli_hareket_olustur(eski_hesap.ToString(), guncel_hesap.ToString(), "Havale", Session["hno"].ToString(),giden_hesap);

    }
}