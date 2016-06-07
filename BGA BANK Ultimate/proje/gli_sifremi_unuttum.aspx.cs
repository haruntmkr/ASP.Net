using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gli_sifremi_unuttum : System.Web.UI.Page
{
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnbilgiGönder_Click(object sender, EventArgs e)
    {
        Mail mailCS = new Mail();
        Metotlar mts = new Metotlar();
       
        string yeniSifre=mts.SifreUret();

        try
        {
            var veri = (from kisiler in db.musteris
                        where kisiler.hno == btnMusteriNo.Text && kisiler.email == btnE_mail.Text
                        select kisiler).First();
          
                try
                {


                    veri.sifre = yeniSifre;
                    db.SubmitChanges();
                    string icerik = "Şifre değiştirme işleminiz başarıyla tamamlanmıştır."
                     + "<br/>Sizin için oluşturulan şifre:<br/>"
                     + yeniSifre
                     + "<br/><br/>Yeni şifreniz ile giriş yapabilirsiniz.<br/><br/>"
                     + "<p style=\"padding: 18px 0 44px\">&copy; 2016, BGA BANK </p>";
                    mailCS.SifremiUnuttumMailGönder(icerik, btnE_mail.Text, "ŞİFRE DEĞİŞİKLİĞİ");
                }
                catch (Exception)
                {
                    Literal1.Text = "<div class='alert alert-info'> Şifre değiştirilemedi...</div>";
                }
                finally
                {


                    Literal1.Text = "<div class='alert alert-success'> Şifreniz mail adresinize gönderilmiştir...</div>";

                }
          

          
           
        }
        catch 
        {

            Literal1.Text = "<div class='alert alert-error'> Bilgilerinizin doğru girildiğinden emin olunuz...</div>";
        }

           // string sqlString = "UPDATE musteri SET sifre='"+yeniSifre.ToString()+"' WHERE hno='"+btnMusteriNo.Text+"' AND email='"+btnE_mail.Text+"'";
           // int count = vt.Command(sqlString);
           // if (count == 1)
           // {
               
                // metotlardan bir metot oluştur sonra geri gelen değeri icerik değişkenine eşitle
             
           
           
      
      
        
    }
}