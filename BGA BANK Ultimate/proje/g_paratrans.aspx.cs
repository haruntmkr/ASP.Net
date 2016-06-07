using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class g_paratrans : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    Cookie cookie = new Cookie();

    protected void Page_Load(object sender, EventArgs e)
    {

        Literal1.Visible = false;
        if (cookie.cookie_durumu() == 1)
        {
            if (!IsPostBack)
            {
                Metotlar mt = new Metotlar();

                Repeater1.DataSource = mt.hareket_oku(cookie.oku("hno"));
                Repeater1.DataBind();

            }
        }

        else
        {

            Response.Redirect("uyari.aspx");

        }
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        //eski hesap bilgisi 
        string sorgu;
        sorgu = "Select hesap from musteri where hno=" + cookie.oku("hno");
        SqlDataReader dt = vt.GetDataReader(sorgu);
        string eski_hesap="";
        if(dt.Read())
        {
             eski_hesap = dt["hesap"].ToString();
        }
        //--eski hesap bilgisi
        string giden_hesap, miktar;
        giden_hesap = TextBox1.Text;
        miktar = TextBox2.Text;
        sorgu = "UPDATE musteri SET hesap=hesap-" + miktar + " WHERE hno='" + cookie.oku("hno") + "'";
        int sonuc1,sonuc2;
        sonuc1=vt.Command(sorgu);
    
        sorgu = "UPDATE musteri SET hesap=hesap+" + Convert.ToInt32(miktar) +" WHERE hno='" + giden_hesap + "'";
        sonuc2 = vt.Command(sorgu);
        
        if (sonuc1 != 0 && sonuc2!=0)
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-success'>Havale başarılı şekilde gerçekleşmiştir.</span>";
        }
        else if(sonuc1!=0 && sonuc2==0)
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-important'>para düşüldü eklenmedi.</span>";
        }
        else if (sonuc1 == 0 && sonuc2 != 0)
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-important'>para eklendi düşülmedi.</span>";
        }
        else
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-important'>Havale yapılamadı.</span>";
        }



      

        Metotlar metot = new Metotlar();
        metot.hareket_olustur(eski_hesap, "Havale", cookie.oku("hno"), giden_hesap);

    }
}