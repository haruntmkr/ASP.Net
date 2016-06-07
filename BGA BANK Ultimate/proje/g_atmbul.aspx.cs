using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class g_atmbul : System.Web.UI.Page
{
    veritabani vt = new veritabani();

    public string arama = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Cookie cookie = new Cookie();

        if (cookie.cookie_durumu() == 0)
        {
            Response.Redirect("uyari.aspx");
        }



    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        arama = TextBox1.Text;
        string sql = "SELECT ad, adres, tip, durum FROM subeler WHERE (ad + adres) LIKE '%" + arama + "%'";
        subeRepeater.DataSource = vt.GetDataTable(sql);
        subeRepeater.DataBind();
        DataBind();

    }
}