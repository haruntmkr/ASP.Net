using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class gli_log_in : System.Web.UI.Page
{
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        LabelBilgi.Visible = false;
        
    }

    protected void Submit_Click(object sender, EventArgs e)
    {

        //IP Kontrolü   LINQ 
       string _ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
       if (_ip == null)
       {
           _ip = Request.UserHostAddress;
           _ip = _ip.Replace("::1", "127.0.0.1");
       }

       try
       {
               var qry = (from m in db.musteris where m.hno == login_id.Text && m.sifre == login_password.Text select m).First();
               Session.Add("mail",qry.email.ToString());
               Session.Add("hno", qry.hno.ToString());
               Session.Add("mid", qry.mid.ToString());
               Session.Add("AdSoyad", qry.ad.ToString() + " " + qry.soyad.ToString());
               string kontrol="0";
                               try
                               {
                                  /* var q1 = (from c in db.IPs
                                             join o in db.ayarlars
                                             on c.hno equals o.hno
                                             where c.hno == login_id.Text && o.hno == login_id.Text
                                             select new { c.hno, c.IP1, o.ip_dogrula, o.mail_dogrula }).Where(c => c.hno != null);*/
                                       var sorgu = (from c in  db.ayarlars  where c.hno == login_id.Text select c).First();
                                       if (sorgu.ip_dogrula.ToString() == "1" && sorgu.mail_dogrula.ToString()=="1")
                                       {
                                           var ipler = from veri in db.IPs where veri.hno == login_id.Text select veri;
                                           foreach(var veri in ipler)
                                           {
                                               if (veri.IP1 == _ip)
                                               {
                                                   kontrol = "1";
                                                   Server.Transfer("gli_mail_dogrulama.aspx");
                                               }
                                               else
                                               {
                                                   kontrol = "1";

                                               }                          
                                           }
                       
                                       }
                                       else if(sorgu.ip_dogrula.ToString()=="0" && sorgu.mail_dogrula.ToString()=="1")
                                       {
                                               kontrol = "1";    
                                               Server.Transfer("gli_mail_dogrulama.aspx");     
                                       }
                                       else if(sorgu.ip_dogrula.ToString()=="0" && sorgu.mail_dogrula.ToString()=="0")
                                       {  
                                       }
                                       else if (sorgu.ip_dogrula.ToString() == "1" && sorgu.mail_dogrula.ToString() == "0")
                                       {
                                           var ipler = from veri in db.IPs where veri.hno == login_id.Text select veri;


                                           foreach (var veri in ipler)
                                           {
                                               if (veri.IP1 == _ip)
                                               {
                                                   string tarayici_bilgi = Request.UserAgent;
                                                   string tarih = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");
                                                   girisler girisler = new girisler();
                                                   girisler.hno = Session["hno"].ToString();
                                                   girisler.IP = _ip;
                                                   girisler.tarih = tarih;
                                                   girisler.tarayici_bilgisi = tarayici_bilgi.Substring(0,50);


                                                   db.girislers.InsertOnSubmit(girisler);
                                                   db.SubmitChanges();
                                                   Server.Transfer("gli_giris.aspx");
                                               }
                                               else
                                               {
                                                   kontrol = "1";

                                               }
                                           }
                                       }

                               }
                               catch 
                               {
                               }
             if(kontrol !="1")
             {
                 string tarayici_bilgi = Request.UserAgent;
                 string tarih = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");
                 girisler girisler = new girisler();
                 girisler.hno = Session["hno"].ToString();
                 girisler.IP = _ip;
                 girisler.tarih = tarih;
                 girisler.tarayici_bilgisi = tarayici_bilgi.Substring(0, 50);
                 db.girislers.InsertOnSubmit(girisler);
                 db.SubmitChanges();


               Response.Redirect("gli_giris.aspx"); 
             }
             

       }
       catch (Exception ex)
       {
                  LabelBilgi.Visible = true;
                  LabelBilgi.Text = "Müsteri Numaranız ya da şifreniz yanlış. Lütfen tekrar deneyin.";
       }







         


        

     


         
     
     
        //IP Kontrolü sonu



      


    }



    protected void LabelE_posta_DataBinding(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, typeof(Page), "focus",
                 "document.getElementById('login_id').focus();", true);
    }
}