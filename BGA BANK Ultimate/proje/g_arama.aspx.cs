using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class arama : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["kelime"] != null)
        {

            string aranan = Request.QueryString["kelime"];

        //    Label1.Text = aranan;

        }
        else
        {
            Label1.Text = "Aranacak kelimeyi giriniz..";

        }

        //HAberleri listeme satırları
        int QueryCount = Request.QueryString.Count;

        Label1.Text = Request.QueryString[0].ToString();
        var sorgu = "";
        if (QueryCount > 1)
        {
            for (int i = 1; i < QueryCount; i++)
            {
                sorgu += "haber_baslik LIKE '%" + Request.QueryString[i] + "%' or ";


            }
            sorgu = sorgu.Substring(0, sorgu.Length - 3);

            //Label1.Text = sorgu;
        }
        else
        {
            sorgu = "haber_baslik LIKE '%" + Request.QueryString[0] + "%'";

        }
        veritabani vt = new veritabani();
        sorgu = "select * from haberler where "+sorgu;
        SqlDataReader dr = vt.GetDataReader(sorgu);
        DataList1.DataSource = dr;
        DataList1.DataBind();
           
       
        
      
     





    }

    protected void ara(object sender, EventArgs e)
    {

        if (TextBox1.Text.Contains(' '))
        {
            string[] girilenkelime = TextBox1.Text.Split(' ');
            string yol = "";
            for (int i = 0; i < girilenkelime.Length; i++)
            {

                yol += "kelime" + i + "=" + girilenkelime[i] + "&";
            }
            yol = yol.Substring(0, yol.Length - 1);
            Response.Redirect("g_arama.aspx?" + yol);
        }
        else
        {
            Response.Redirect("g_arama.aspx?kelime=" + TextBox1.Text);
        }

    }



}