using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data.Linq;

public partial class g_ayar : System.Web.UI.Page
{

    Cookie cookie = new Cookie();
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (cookie.cookie_durumu() != 0)
        {
            Label1.Text = "<div class='alert alert-success'>Lütfen PNG uzantılı bir dosya yükleyiniz...</div>";
            if (!IsPostBack)
            {
                string sorgu = "Select * from musteri where hno='" + cookie.oku("hno") + "'";
                SqlDataReader rd = vt.GetDataReader(sorgu);
                if (rd.Read())
                {
                    TextBox1.Text = rd["ad"].ToString();
                    soyad.Text = rd["soyad"].ToString();
                    email.Text = rd["email"].ToString();
                    tel.Text = rd["tel"].ToString();
                    Adres.Text = rd["adres"].ToString();
                    firma.Text = rd["firma"].ToString();
                    plaka.Text = rd["plaka"].ToString();
                }
            }
        }
        else
        {
            Response.Redirect("uyari.aspx");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string dosyauzantisi = Path.GetExtension(FileUpload1.PostedFile.FileName);


        if (FileUpload1.HasFile != true)
        {
            Label1.Text = "<div class='alert alert-error'>Lütfen dosya seçiniz...</div> ";

        }
        else
        {

            FileUpload1.SaveAs(Server.MapPath("img/users/") + cookie.oku("hno") + dosyauzantisi);
            Label1.Text = "<div class='alert alert-success'>Profil resmi başarıyla yüklenmiştir...</div>";
        }


        string sorgu;
        sorgu = "UPDATE musteri SET ad='" + TextBox1.Text + "',soyad='" + soyad.Text + "',email='" + email.Text + "',adres='" + Adres.Text + "',tel='" + tel.Text + "',plaka='" + plaka.Text + "',firma='" + firma.Text + "' WHERE hno='" + cookie.oku("hno") + "'";
        int sonuc = vt.Command(sorgu);
        if (sonuc != 0)
        {
            Literal1.Text = "<div class='alert alert-info'> Güncelleme başarılı bir şekilde gerçekleştirildi...</div>";
        }
        else
        {
            Literal1.Text = "<div class='alert alert-error'> Güncelleme başarız...</div>";
        }
    }
}