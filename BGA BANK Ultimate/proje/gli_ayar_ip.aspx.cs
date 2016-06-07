using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gli_ayar_ip : System.Web.UI.Page
{
    BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hno"] == null)
        {
            Response.Redirect("gli_uyari.aspx");
        }
        else 
        {
            if(!IsPostBack)
            {

                var veriler = from veri in db.IPs where veri.hno == Session["hno"].ToString() select veri;

                Repeater1.DataSource = veriler;
                Repeater1.DataBind();

                var sorgu = (from veri in db.ayarlars where veri.hno == Session["hno"].ToString() select veri).First();

                    if (sorgu.ip_dogrula.ToString() == "1")
                    {
                        CheckBox1.Checked = true;
                    }
                    if (sorgu.mail_dogrula.ToString() == "1")
                    {
                        CheckBox2.Checked = true;
                    }


               






            }
        
        
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string _ip = TextBox1.Text;
        try
        {
            var ip_veri = (from veriler in db.IPs where veriler.hno == Session["hno"].ToString() select veriler).First();

            ip_veri.hno = Session["hno"].ToString();
            ip_veri.IP1 = _ip;
            db.SubmitChanges();



        }

        catch 
        {

            IP ipler = new IP();
            ipler.hno = Session["hno"].ToString();
            ipler.IP1 = _ip;
            db.IPs.InsertOnSubmit(ipler);
            db.SubmitChanges();
        
        }







        try
        {
            var veri = (from veriler in db.ayarlars where veriler.hno == Session["hno"].ToString() select veriler).First();

            int ip_dogrula = 0;
            if (CheckBox1.Checked == true)
            {
                ip_dogrula = 1;
            }
            else if (CheckBox1.Checked == false)
            {
                ip_dogrula = 0;
            }
            veri.hno = Session["hno"].ToString();
            veri.ip_dogrula = ip_dogrula;

            db.SubmitChanges();

        }
        catch 
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

            ayarlar ayar = new ayarlar();
            ayar.hno = Session["hno"].ToString();
            ayar.ip_dogrula = ip_dogrula;

            db.ayarlars.InsertOnSubmit(ayar);
            db.SubmitChanges();
        
        
        }

       
       


      
       


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int mail_dogrula = 0;
        try
        {
            var veri = (from veriler in db.ayarlars where veriler.hno == Session["hno"].ToString() select veriler).First();
        
            if (CheckBox2.Checked == true)
            {
                mail_dogrula = 1;
            }
            else if (CheckBox2.Checked == false)
            {
                mail_dogrula = 0;
            }

            veri.mail_dogrula = mail_dogrula;
            db.SubmitChanges();



        }
        catch 
        {
            ayarlar ayar = new ayarlar();


            if (CheckBox2.Checked == true)
            {
                mail_dogrula = 1;
            }
            else if (CheckBox2.Checked == false)
            {
                mail_dogrula = 0;
            }
            ayar.hno = Session["hno"].ToString();
            ayar.mail_dogrula = mail_dogrula;
            db.ayarlars.InsertOnSubmit(ayar);
            db.SubmitChanges();

        
        }
       
       



    }

}