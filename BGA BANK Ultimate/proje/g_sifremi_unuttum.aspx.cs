using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class g_sifremi_unuttum : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnbilgiGönder_Click(object sender, EventArgs e)
    {
        Mail mailCS = new Mail();
        Metotlar mts = new Metotlar();
        veritabani vt = new veritabani();
        string yeniSifre=mts.SifreUret();
        try
        {
            string sqlString = "UPDATE musteri SET sifre='"+yeniSifre.ToString()+"' WHERE hno='"+btnMusteriNo.Text+"' AND email='"+btnE_mail.Text+"'";
            int count = vt.Command(sqlString);
            if (count == 1)
            {
                string icerik = "Şifre değiştirme işleminiz başarıyla tamamlanmıştır."
                 + "<br/>Sizin için oluşturulan şifre:<br/>"
                 + yeniSifre
                 + "<br/><br/>Yeni şifreniz ile giriş yapabilirsiniz.<br/><br/>"
                 + "<p style=\"padding: 18px 0 44px\">&copy; 2016, BGA BANK </p>";

                // metotlardan bir metot oluştur sonra geri gelen değeri icerik değişkenine eşitle
                mailCS.SifremiUnuttumMailGönder(icerik, btnE_mail.Text, "ŞİFRE DEĞİŞİKLİĞİ");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Girilen bilgiler geçerlidir. Mail gönderildi.",
                 "window.opener.document.getElementById('LabelE_posta').innerText = 'Yeni şifre ' + document.getElementById('btnE_mail').value + ' adresine gönderilmiştir.';"
                 + "this.close();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Sayfa yenileme",
                 "document.getElementById('btnE_mail').value='';"
                 + "document.getElementById('btnMusteriNo').value='';"
                 + "document.getElementById('bilgi').innerText = 'Lütfen bilgilerinizi doğru bir şekilde tekrar giriniz!';"
                 + "document.getElementById('bilgi').removeAttribute(['class']);"
                 + "document.getElementById('bilgi').setAttribute(['class'], ['label btn-danger']);", true);
                
            }
           
        }
        catch
        {

        }
        
    }
}