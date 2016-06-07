using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class g_ayar_ip : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    Cookie cookie = new Cookie();
    public string mail_kontrol="",ip_kontrol="";
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (cookie.cookie_durumu() == 0)
        {
            Response.Redirect("uyari.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                string sorgu = "SELECT * FROM IP where hno =" + cookie.oku("hno");
                try 
                {
                    SqlDataReader rd = vt.GetDataReader(sorgu);
                    Repeater1.DataSource = rd;
                    Repeater1.DataBind();
                    sorgu = "select * from ayarlar where hno='"+cookie.oku("hno")+"'";
                    SqlDataReader dr = vt.GetDataReader(sorgu);
                    if (dr.Read())
                    {
                        if (dr["mail_dogrula"].ToString() == "1")
                        {
                            CheckBox2.Checked = true;
                        }
                        if (dr["ip_dogrula"].ToString() == "1")
                        {
                            CheckBox1.Checked = true;
                        }
               
                    
                    }
                
                }
                catch(Exception)
                
                {
                
                
                }
               

                



            }


        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
            string _ip = TextBox1.Text;

            try 
            {
                string genel_sorgu = "Select * from IP where hno=" + cookie.oku("hno") + "AND IP='" + _ip + "'";
                DataRow genl_sonuc = vt.GetDataRow(genel_sorgu);
                if(genl_sonuc["IP"] != null)
                {
                    Literal2.Text = "Bu IP sistemde kayıtlıdır....";
                }
               
            }
            catch (Exception)
            {
                string sorgu = "INSERT INTO IP (hno,IP) VALUES ('" + cookie.oku("hno") + "','" + _ip + "');";
                int sonuc = vt.Command(sorgu);

                if (sonuc != 0)
                {
                    Literal2.Text = "Kayıt başarı ile tamamlandı.";

                }
            }


            try
            {
                string genel_ip = "Select * from ayarlar where hno=" + cookie.oku("hno");
                DataRow sonuc_ip = vt.GetDataRow(genel_ip);
                 if (sonuc_ip["hno"] != null)
                {
                int ip_dogrula = 0;
                if (CheckBox1.Checked == true)
                {
                    ip_dogrula = 1;
                }
                else if (CheckBox1.Checked == false)
                {
                    ip_dogrula = 0;
                }


                genel_ip = "UPDATE ayarlar SET ip_dogrula=" + ip_dogrula + "where hno=" + cookie.oku("hno") + ";";
                int sonuc=vt.Command(genel_ip);
                if(sonuc != 0)
                {
                    Literal2.Text = "Güncelleme başarılı.";
                
                }
            }
            }
            catch(Exception) 
            {
                int ip_dogrula = 0;
                if (CheckBox1.Checked == true)
                {
                    ip_dogrula = 1;
                }
                else if (CheckBox1.Checked == false)
                {
                    ip_dogrula = 0;
                }

                string genel_ip = "INSERT INTO ayarlar (hno,ip_dogrula) VALUES (" + cookie.oku("hno") + "," + ip_dogrula + ");";
               int sonuc = vt.Command(genel_ip);
               if (sonuc != 0)
               {
                   Literal2.Text = "Kayıt başarı ile tamamlandı.";

               }

            }

        
      






    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int mail_dogrula = 0;
    try
        {
            string genel_ip = "Select * from ayarlar where hno=" + cookie.oku("hno");
                DataRow sonuc_ip = vt.GetDataRow(genel_ip);
                if (sonuc_ip["hno"] != null)
                {
                    if (CheckBox2.Checked == true)
                    {
                        mail_dogrula = 1;
                    }
                    else if (CheckBox2.Checked == false)
                    {
                        mail_dogrula = 0;
                    }
                    genel_ip = "UPDATE ayarlar SET mail_dogrula=" + mail_dogrula + "where hno=" + cookie.oku("hno") + ";";
                    int sonuc = vt.Command(genel_ip);
                    if (sonuc != 0)
                    {
                        Literal1.Text = "Kayıt başarı ile tamamlandı.";

                    }
                
                }
                
    

        }
        catch
        {
              
                if (CheckBox1.Checked == true)
                {
                    mail_dogrula = 1;
                }
                else if (CheckBox1.Checked == false)
                {
                    mail_dogrula = 0;
                }

                string genel_ip = "INSERT INTO ayarlar (hno,mail_dogrula) VALUES (" + cookie.oku("hno") + "," + mail_dogrula + ");";
               int sonuc = vt.Command(genel_ip);
               if (sonuc != 0)
               {
                   Literal1.Text = "Kayıt başarı ile tamamlandı.";

               }

          


        }
    




    }

}