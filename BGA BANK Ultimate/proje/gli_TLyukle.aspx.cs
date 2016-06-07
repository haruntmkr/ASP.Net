using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gli_TLyukle : System.Web.UI.Page
{
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();

    Gli_Metot metot = new Gli_Metot();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["hno"] != null)
        {
            if (IsPostBack)
            {

            }
            else
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

        var veri = (from veriler in db.musteris where veriler.hno==Session["hno"].ToString() select veriler).First();
        string eski_hesap = "";
        eski_hesap = veri.hesap;
        string giden_tel = TBoxGSM.Text;
        int miktar = Convert.ToInt32(TBoxTL.Text);
        int son_hesap = Convert.ToInt32(eski_hesap) - miktar;
        try 
        {
            veri.hesap = son_hesap.ToString();
            db.SubmitChanges();
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-success'>" + giden_tel.ToString() + " numaraya TL yüklemesi yapılmıştır...</span>";
        
        
        
        }
        catch(Exception)
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-important'>" + miktar.ToString() + " TL Yüklemesi başarısız olmuştur...</span>";
            
        
        }

        metot.gli_hareket_olustur(eski_hesap.ToString(), son_hesap.ToString(), "TL Yükleme",Session["hno"].ToString(), giden_tel);

    }



}