using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class g_TLyukle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    Metotlar metot = new Metotlar();
    Cookie cookie = new Cookie();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (cookie.cookie_durumu() == 1)
        {
            if (IsPostBack)
            {
            
            }
            else
            {
                Repeater1.DataSource = metot.hareket_oku(cookie.oku("hno"));
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
        string eski_hesap = "";
        if (dt.Read())
        {
            eski_hesap = dt["hesap"].ToString();
        }
        //--eski hesap bilgisi
        string giden_tel = TBoxGSM.Text;
        int miktar=Convert.ToInt32(TBoxTL.Text);

       
        int son_hesap = Convert.ToInt32(eski_hesap) - miktar;

        sorgu = "UPDATE musteri SET hesap=" + son_hesap.ToString() + " WHERE hno='" + cookie.oku("hno") + "'";
        int sonuc=vt.Command(sorgu);
       
        
        if (sonuc != 0)
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-success'>"+giden_tel.ToString()+" numaraya TL yüklemesi yapılmıştır...</span>";
        }
        else
        {
            Literal1.Visible = true;
            Literal1.Text = "<span class='alert alert-important'>"+miktar.ToString()+" TL Yüklemesi başarısız olmuştur...</span>";
        }
        




        Metotlar metot = new Metotlar();
        metot.hareket_olustur(eski_hesap.ToString(), "TL Yükleme", cookie.oku("hno"), giden_tel);

    }



}