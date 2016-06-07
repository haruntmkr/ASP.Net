using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO; 
public partial class gli_ayar : System.Web.UI.Page
{
    
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["mid"] != null)
        {

            if (!IsPostBack)
            {
                var veri = (from veriler in db.musteris where veriler.hno == Session["hno"].ToString() select veriler).First();
    
                    TextBox1.Text = veri.ad.ToString();
                    soyad.Text = veri.soyad.ToString();
                    email.Text = veri.email.ToString();
                    tel.Text = veri.tel.ToString();
                    Adres.Text = veri.adres.ToString();
                    firma.Text = veri.firma.ToString();
                    plaka.Text = veri.plaka.ToString();
                
            }
        }
        else
        {
            Response.Redirect("gli_uyari.aspx");

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string dosyauzantisi = Path.GetExtension(FileUpload1.PostedFile.FileName);
        

        if (FileUpload1.HasFile != true)
        {
            Label1.Text = "<div class='alert alert-error'>Lütfen resim dosyası seçiniz...</div> ";

        }
        else
        {

            if (dosyauzantisi.ToLower() == ".png")
            {

                FileUpload1.SaveAs(Server.MapPath("img/users/") + Session["hno"].ToString() + dosyauzantisi);
                Label1.Text = "<div class='alert alert-success'>Profil resmi başarıyla yüklenmiştir...</div>";

            }
            else
            {
                Label1.Text = "<div class='alert alert-error'>Profil resmi güncellenemedi<br/>Lütfen PNG formatında dosya yükleyiniz.</div>";

            }


        }

      
         var veri = (from kisiler in db.musteris
                        where kisiler.hno == Session["hno"].ToString()
                        select kisiler).First();
        
       
        try
        {
           
            
            veri.ad = TextBox1.Text;
            veri.soyad = soyad.Text;
            veri.email = email.Text;
            veri.adres = Adres.Text;
            veri.plaka = plaka.Text;
            veri.tel = tel.Text;
            veri.firma = firma.Text;
            db.SubmitChanges();

           
        }
        catch (Exception )
        {
            Literal1.Text = "<div class='alert alert-error'> Güncelleme başarız...</div>";
        }
        finally
        {


            Literal1.Text = "<div class='alert alert-info'> Güncelleme başarılı bir şekilde gerçekleştirildi...</div>";

        }
        
        
      
    }















}