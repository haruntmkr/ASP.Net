using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
/// <summary>
/// Summary description for Gli_Metot
/// </summary>
public class Gli_Metot
{
	public Gli_Metot()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void gli_hareket_olustur(string para1,string para2, string aciklama,string yeni_hsno) 
    {
       BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
       hareketler hareket = new hareketler();
       hareket.para1 = para1;
       hareket.para2 = para2;
       hareket.aciklama = aciklama;
       hareket.hno = yeni_hsno;
       hareket.hno2 = yeni_hsno;
       hareket.tarih = DateTime.Now;
       db.hareketlers.InsertOnSubmit(hareket);
       db.SubmitChanges();

    }
    public void gli_hareket_olustur(string para1,string para2, string aciklama, string hesap_no, string giden_hesap)
    {
        BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
        hareketler hareket = new hareketler();
        hareket.para1 = para1;
        hareket.para2 = para2;
        hareket.aciklama = aciklama;
        hareket.hno = hesap_no;
        hareket.hno2 = giden_hesap;
        hareket.tarih = DateTime.Now;
        db.hareketlers.InsertOnSubmit(hareket);
        db.SubmitChanges();

    }
    public List<object> gli_hareket_oku(string session) 
    {
       BGABANKUltimateDataContext db = new BGABANKUltimateDataContext();
       var hareketlerim = (from veri in db.hareketlers
                           where veri.hno == session
                  orderby veri.h_id descending
                  select veri).Take(3);

       List<object> sonuc = new List<object>(hareketlerim);

       return sonuc;
    }
    public string filtre(string str)
    {
        string pattern = @"[^a-zA-Z0-9öçğışÖÇĞİŞ ]+";
        Regex rgx = new Regex(pattern);
        if (!rgx.IsMatch(str))
        {
            return str;

        }
        else
        {
            return "İstenilen biçimde giriş yapınız..";

        }

    }
    public string filtre_ip(string str)
    {
        if(str!=null)
        {
            string pattern = @"[^0-9.: ]+";//[^ … ] 	Üç nokta yerine yazılan karakterler haricindeki karakterleri ifade eder
            Regex rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                return str;

            }
            else
            {
                return "0.0.0.0";

            }
        }
        return null;
        

    }


}