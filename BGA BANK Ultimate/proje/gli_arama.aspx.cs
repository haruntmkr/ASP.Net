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

        BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
        Gli_Metot metot = new Gli_Metot();
       

        if (Request.QueryString["kelime"] != null)
        {

            string aranan = metot.filtre(Request.QueryString["kelime"]);

        //    Label1.Text = aranan;

        }
        else
        {
            Label1.Text = "Aranacak kelimeyi giriniz..";

        }

        //HAberleri listeme satırları
        int QueryCount = Request.QueryString.Count;

        Label1.Text = metot.filtre(Request.QueryString[0].ToString());
        var sorgu = "";
        if (QueryCount > 1)
        {
            for (int i = 1; i < QueryCount; i++)
            {
                sorgu += Request.QueryString[i] + " ";


            }
            sorgu = sorgu.Substring(0, sorgu.Length - 3);

            //Label1.Text = sorgu;
        }
        else
        {
            sorgu =Request.QueryString[0];

        }
       try
        {


           /*var sonuc = (from arama in db.haberlers where arama.haber_baslik.Contains(sorgu) select new { arama.haber_detay, arama.haber_baslik }).First();
            Label2.Text = sonuc.haber_baslik;
            Label3.Text = sonuc.haber_detay;*/
            var sonuc = from arama in db.haberlers where arama.haber_baslik.Contains(sorgu) select arama;
            Repeater1.DataSource = sonuc;
            Repeater1.DataBind();
            
        }
        catch (Exception)
        {
           
        }



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
            Response.Redirect("gli_arama.aspx?" + yol);
        }
        else
        {
            Response.Redirect("gli_arama.aspx?kelime=" + TextBox1.Text);
        }

    }



}