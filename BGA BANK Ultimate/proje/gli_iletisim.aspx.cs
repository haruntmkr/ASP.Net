using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gli_iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void gönder_Click(object sender, EventArgs e)
    {
        
        if (Page.IsValid)
        {
                try
                {
                    Mail Mail = new Mail();
                    mesaj_bilgi_label.Visible = true;
                    adi.Text = string.Empty;
                    soyadi.Text = string.Empty;
                    eposta.Text = string.Empty;
                    mesaj.InnerText = string.Empty;
                }
                catch (Exception)
                {
                    throw;
                }


        }
    }

   
}