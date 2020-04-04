using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
/// <summary>
/// Summary description for Mail
/// </summary>
public class Mail
{
    public Mail()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private SmtpClient SmtpClientOlustur()
    {
        SmtpClient sc = new SmtpClient();
        sc.Port = 587;
        sc.Host = "smtp.gmail.com";
        sc.EnableSsl = true;
        sc.Credentials = new NetworkCredential("", "");
        return sc;
    }
    private MailMessage MailMessageOlustur(string icerik, string eposta, string konu)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("", "");
        mail.To.Add(eposta);
        mail.Subject = konu;
        mail.IsBodyHtml = true;
        mail.Body = "<b>" + icerik + "</b>";
        return mail;
    }
    public void SifremiUnuttumMailGönder(string icerik, string eposta, string konu)
    {
        SmtpClient SClient = SmtpClientOlustur();
        SClient.Send(MailMessageOlustur(icerik, eposta, konu));
    }

    public int hesapbilgi_gonder(string icerik, string eposta)
    {
        SmtpClient sc = new SmtpClient();
        sc.Port = 587;
        sc.Host = "smtp.gmail.com";
        sc.EnableSsl = true;
        sc.Credentials = new NetworkCredential("", "");

        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("", "");

        mail.To.Add(eposta);


        mail.Subject = "BGABANK ULTIMATE";
        mail.IsBodyHtml = true;
        mail.Body = "<b>" + icerik + "</b>";


        sc.Send(mail);

        return 1;
    }
    public int mail_aktivasyon(string eposta,string icerik) 
    {
        SmtpClient sc = new SmtpClient();
        sc.Port = 587;
        sc.Host = "smtp.gmail.com";
        sc.EnableSsl = true;
        sc.Credentials = new NetworkCredential("", "");

        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("", "");

        mail.To.Add(eposta);


        mail.Subject = "BGABANK ULTIMATE Aktivasyon Kodu";
        mail.IsBodyHtml = true;
        mail.Body = "<b>Merhaba, <br/> BGA BANK Ultimate giriş aktivasyon kodunuz: "+"<b>" + icerik + "</b>"+"<br/><br/>2016 BGA BANK";


        sc.Send(mail);

        return 1;
    
    }



}
