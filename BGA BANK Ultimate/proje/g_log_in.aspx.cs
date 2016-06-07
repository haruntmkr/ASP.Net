using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class g_log_in : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelBilgi.Visible = false;
       
        
    }

    protected void Submit_Click(object sender, EventArgs e)
    {



        //IP Kontrolü
        string _ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (_ip == null)
        {
            _ip = Request.UserHostAddress;
            _ip = _ip.Replace("::1", "127.0.0.1");
        }



        try
        {


            var sqlString = "SELECT * FROM musteri WHERE hno = '" + login_id.Text + "' and sifre='" + login_password.Text + "'";
            veritabani vt = new veritabani();
            SqlDataReader rd = vt.GetDataReader(sqlString);
            Cookie cookie = new Cookie();
            if (rd.Read())
            {
                /*Session.Add("mid", rd["mid"].ToString());
                Session.Add("hno", rd["hno"].ToString());
                Session.Add("AdSoyad", rd["ad"].ToString() + " " + rd["soyad"].ToString());*/
                cookie.cookie_olustur("email", rd["email"].ToString());
                cookie.cookie_olustur("hno", rd["hno"].ToString());
                cookie.cookie_olustur("adsoyad", rd["ad"].ToString() + " " + rd["soyad"].ToString());


           
            
            }
            else
            {
                throw new Exception("Hatalı giriş"); 
            }

            //Bu kontrol yapısı linqn try catch yoksa hata döndermesi üzerine güvenli sayfaların güvensizlerle benzer kod yapısını içermesi için tasarlandı.
            string kontrol = "0";//Veri tabanındaki ayarlar tablosunda kullanıcının IP kontrolü ya da mail kontrolü yoksa sisteme giriş yapması için eklendi
                        try
                        {
                            
                            //string sorgu = "SELECT * from IP as c inner join ayarlar as o on o.hno=c.hno where c.hno=" + login_id.Text + " and o.hno=" + login_id.Text;
                            string sorgu = "Select * from IP where hno=" + login_id.Text;
                            SqlDataReader veri_IP = vt.GetDataReader(sorgu);
                            sorgu = "Select * from ayarlar where hno=" + login_id.Text;
                            DataRow veri_ayar = vt.GetDataRow(sorgu);
                            while(veri_IP.Read())
                            {
                                if (veri_ayar["ip_dogrula"].ToString() == "1")
                                {
                                        if (_ip == veri_IP["IP"].ToString())
                                        {
                                            if (veri_ayar["mail_dogrula"].ToString() == "1")
                                            {
                                              
                                                Server.Transfer("g_mail_dogrulama.aspx");
                                                throw new Exception("Mail doğrulama");

                                            }
                                            string tarayici_bilgi = Request.UserAgent;
                                            string tarih = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");
                                        
                                            sorgu = "INSERT INTO girisler(hno, tarih, tarayici_bilgisi, IP) VALUES(" + cookie.oku("hno") + ", '" + tarih + "', '" + tarayici_bilgi.Substring(0,50) + "', '" + _ip + "')";
                                            vt.Command(sorgu);
                
                                            Server.Transfer("g_giris.aspx");
                                        }
                                        else
                                        {
                                            kontrol = "1";//kullanıcının IP ve ayarlar tablosunda verisi var fakat ordaki veri şuanki IP adresiyle uyuşmuyor. Bu durumda 
                                            //Kullanıcının sisteme girişi engellenmesi için kontrol 1 yapılır

                                        }
                                }
                                else 
                                {
                                    if (veri_ayar["mail_dogrula"].ToString() == "1")
                                    {
                                        Server.Transfer("g_mail_dogrulama.aspx");
                                        throw new Exception("Mail doğrulama");
                                    }
                                
                                }
                            }
                          
                          
                        }

                        catch
                        {
                          
                        }
                            if(kontrol!="1")//Kullanıcının IP değeri yanlış ise yukarıdada açıklandığı gibi girişi engellenir.
                            {
                                string tarayici_bilgi = Request.UserAgent;
                                string tarih = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");
                                int boyut = tarayici_bilgi.Length;
                                string sorgu = "INSERT INTO girisler(hno, tarih, tarayici_bilgisi, IP) VALUES(" + cookie.oku("hno") + ", '" + tarih + "', '" + tarayici_bilgi.Substring(0, 50) + "', '" + _ip + "')";
                                vt.Command(sorgu);
                                Response.Redirect("g_giris.aspx");
                                Response.Redirect("g_giris.aspx");
                            }
                        
                      


        }
        catch (Exception ex)
        {
            LabelBilgi.Visible = true;
            LabelBilgi.Text = "Müsteri Numaranız ya da şifreniz yanlış. Lütfen tekrar deneyin.";
        }
        finally
        {
        }


  
    }



    protected void LabelE_posta_DataBinding(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, typeof(Page), "focus",
                 "document.getElementById('login_id').focus();", true);
    }
}