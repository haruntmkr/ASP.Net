using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


public partial class g_index : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {


        /*   SqlConnection baglanti = new SqlConnection("Data Source=LENOVO;Initial Catalog=BGABANKUltimate;Integrated Security=True");
           SqlCommand sorgu = new SqlCommand("select * from site_ayar", baglanti);

           SqlDataAdapter da = new SqlDataAdapter(sorgu);
           DataTable dt = new DataTable();
           baglanti.Open();
           da.Fill(dt);
           GridView1.DataSource = dt;
           GridView1.DataBind();
           */
        Metotlar methods = new Metotlar();
        veritabani vt = new veritabani();
        #region The code-piece inserting the news to the database

        string sqlQuery;
        try
        {

            string rssUrl = "http://www.trthaber.com/sondakika.rss";
            XmlDocument xmlVerisi = new XmlDocument();
            for (int i = 0; i < 3; i++)
            {
                xmlVerisi.Load(rssUrl);
            }
            Newsitem News = new Newsitem();
            for (int i = 0; i < 3; i++)
            {
                News.Title = xmlVerisi.SelectNodes("rss/channel/item/title")[i].InnerText;
                News.Description = xmlVerisi.SelectNodes("rss/channel/item/description")[i].InnerText;
                News.ImageURL = xmlVerisi.SelectNodes("rss/channel/item/imageUrl")[i].InnerText;
                News.Link = xmlVerisi.SelectNodes("rss/channel/item/link")[i].InnerText;
                News.Title = methods.TirnaklariKaldir(News.Title);
                News.Description = methods.TirnaklariKaldir(News.Description);
                News.Description = methods.BoslukKaldır(News.Description);
                if (i == 0 && News.Title != null && News.Link != null && News.Description != null && News.ImageURL != null)
                {
                    vt.Connection();
                    sqlQuery = "select * from haberler";
                    int count = vt.Command(sqlQuery);
                    if (count == -1)
                    {
                        vt.Connection();
                        vt.Command("DELETE FROM haberler");
                        for (int k = 0; k < 3; k++)
                        {
                            File.Delete(Server.MapPath("~/img/YeniHaber" + k.ToString() + ".jpg"));
                        }
                    }
                }
                WebClient webClient = new WebClient();
                News.FotoYol = "/img/YeniHaber" + i.ToString() + ".jpg";
                webClient.DownloadFile(News.ImageURL, Server.MapPath("~" + News.FotoYol));
                sqlQuery = "INSERT INTO haberler (haber_baslik, haber_detay, haber_foto_link, haber_link, haber_foto_yol) VALUES('" + News.Title + "','" + News.Description + "','" + News.ImageURL + "','" + News.Link + "','" + News.FotoYol + "')";
                vt.Connection();
                vt.Command(sqlQuery);

            }
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
        #endregion
        #region The code-piece showing the news on the page
        vt.Connection();
        SqlDataReader dr = vt.GetDataReader("SELECT * FROM haberler");
        int j = 0;
        while (dr.Read())
        {
            if (j == 0)
            {
                NewsTitle1.Text = dr["haber_baslik"].ToString();
                NewsDescription1.Text = dr["haber_detay"].ToString();
                NewsImage1.ImageUrl = dr["haber_foto_yol"].ToString();
                NewsLink1.NavigateUrl = dr["haber_link"].ToString();
            }
            else if (j == 1)
            {
                NewsTitle2.Text = dr["haber_baslik"].ToString();
                NewsDescription2.Text = dr["haber_detay"].ToString();
                NewsImage2.ImageUrl = dr["haber_foto_yol"].ToString();
                NewsLink2.NavigateUrl = dr["haber_link"].ToString();
            }
            else
            {
                NewsTitle3.Text = dr["haber_baslik"].ToString();
                NewsDescription3.Text = dr["haber_detay"].ToString();
                NewsImage3.ImageUrl = dr["haber_foto_yol"].ToString();
                NewsLink3.NavigateUrl = dr["haber_link"].ToString();
            }
            j++;
        }
        dr.Close();
        #endregion
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
    public class Newsitem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Link { get; set; }
        public string FotoYol { get; set; }
    }
}