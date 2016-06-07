using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
/// <summary>
/// Summary description for Metotlar
/// </summary>
public class Metotlar
{
    public Metotlar()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string TirnaklariKaldir(string HamVeri)
    {
        
        string Tirnaksiz = string.Empty;

        //char[] dizi = HamVeri.ToCharArray();
        //for (int i = 0; i < dizi.Length; i++)
        //{
        //    if (dizi[i].Equals('\'') || dizi[i].Equals('\"'))
        //    {
        //        //dizi[i].ToString().Insert(0, " ");
        //        dizi[i] = Convert.ToChar(dizi[i].ToString().Replace('\'', ' '));
        //        dizi[i] = Convert.ToChar(dizi[i].ToString().Replace('\"', ' '));
        //        Tirnaksiz = Tirnaksiz + dizi[i].ToString();
        //    }
        //    Tirnaksiz = Tirnaksiz + dizi[i].ToString();

        //}
        HamVeri = HamVeri.Replace('\"', ' ');
        HamVeri = HamVeri.Replace('\'', ' ');
        Tirnaksiz = HamVeri;
        return Tirnaksiz;
    }
  


    public string BoslukKaldır(string HamVeri)
    {
        string Düzeltilmis1 = HamVeri.Substring(17);
        string Düzeltilmis2 = Düzeltilmis1.Substring(0,Düzeltilmis1.Length - 12);
        return Düzeltilmis2;
    }
    public string SifreUret()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
        var random = new Random();
        return new string(Enumerable.Repeat(chars, 9).Select(s => s[random.Next(s.Length)]).ToArray());
    }
  
    public SqlDataReader hareket_oku(string session) 
    {

        veritabani vt = new veritabani();
        string sorgu = "select  TOP 3 * from hareketler where hno=" +session+" ORDER BY h_id DESC";
        SqlDataReader rd = vt.GetDataReader(sorgu);
        return rd;
    
    }
    public SqlDataReader hesap_ozeti(string session)
    {

        veritabani vt = new veritabani();
        string sorgu = "select  TOP 3 * from hareketler where hno=" + session + " ORDER BY h_id DESC";
        SqlDataReader rd = vt.GetDataReader(sorgu);
        return rd;

    }

    public int hareket_olustur (string eski_hesap,string aciklama, string hesap_no,string giden_hesap)
    {
           //yeni hesap bilgisi 
            veritabani vt = new veritabani();
            int sonuc1;
            string sorgu = "Select hesap from musteri where hno=" + hesap_no;
            SqlDataReader dt = vt.GetDataReader(sorgu);
            string yeni_hesap="";
            if(dt.Read())
            {
                yeni_hesap = dt["hesap"].ToString();
            }
            //--yeni hesap bilgisi

            string tarih = Convert.ToString(DateTime.Now.Year) + "-" + Convert.ToString(DateTime.Now.Month) + "-" + Convert.ToString(DateTime.Now.Day);

            sorgu = "INSERT INTO hareketler (para1, para2,aciklama,tarih,hno,hno2) VALUES ('" + eski_hesap + "', '" + yeni_hesap + "', '" + aciklama + "', '" + tarih.ToString() + "', '" + hesap_no + "','"+giden_hesap+"'); ";
            sonuc1 = vt.Command(sorgu);
        
        return sonuc1;

    }
    public int hareket_olustur(string eski_hesap, string aciklama, string hesap_no)
    {
        //yeni hesap bilgisi 
        veritabani vt = new veritabani();
        int sonuc1;
        string sorgu = "Select hesap from musteri where hno=" + hesap_no;
        SqlDataReader dt = vt.GetDataReader(sorgu);
        string yeni_hesap = "";
        if (dt.Read())
        {
            yeni_hesap = dt["hesap"].ToString();
        }
        //--yeni hesap bilgisi

        string tarih = Convert.ToString(DateTime.Now.Year) + "-" + Convert.ToString(DateTime.Now.Month) + "-" + Convert.ToString(DateTime.Now.Day);
        sorgu = "INSERT INTO hareketler (para1, para2,aciklama,tarih,hno) VALUES ('" + eski_hesap + "', '" + yeni_hesap + "', '" + aciklama + "', '" + tarih + "', '" + hesap_no + "'); ";
        sonuc1 = vt.Command(sorgu);

        return sonuc1;

    }



}