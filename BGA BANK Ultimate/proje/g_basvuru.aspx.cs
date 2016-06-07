using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
public partial class g_basvuru : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

            veritabani vt = new veritabani();
            SqlConnection conn = new SqlConnection();


            conn = vt.Connection();
            String sorgu1 = "INSERT INTO musteri (hno, ad,soyad,sifre,hesap,email,adres,tel,musteri_tipi) VALUES (@hno, @ad, @soyad, @sifre,@hesap,@email,@adres,@tel,@musteri_tipi)";

            String sorgu2 = "SELECT hno FROM musteri ORDER BY hno DESC";

            SqlCommand cmd = new SqlCommand(sorgu1, conn);
            DataRow row = vt.GetDataRow(sorgu2);


            int yeni_hsno = Convert.ToInt32(row["hno"].ToString()) + 1;

            Random randoms = new Random();
            int sifre = randoms.Next(1000, 10000);



            try
            {
                cmd.Parameters.AddWithValue("hno", yeni_hsno);
                cmd.Parameters.AddWithValue("ad", UserName.Text);
                cmd.Parameters.AddWithValue("soyad", soyad.Text);
                cmd.Parameters.AddWithValue("sifre", sifre);
                cmd.Parameters.AddWithValue("hesap", 1000000);
                cmd.Parameters.AddWithValue("email", email.Text);
                cmd.Parameters.AddWithValue("tel", tel.Text);
                cmd.Parameters.AddWithValue("adres", Adres.Text);
                cmd.Parameters.AddWithValue("musteri_tipi", bireyselkurumsal.SelectedIndex);
                cmd.ExecuteNonQuery();




                //mail yollama


                string icerik = "BGABANK Ultimate Kullanıcı Bilgileriniz <br/><br/>" + "Ad Soyad:" + UserName.Text +
 " " + soyad.Text + "<br/>Müşteri numarası: " + yeni_hsno + "<br/>" + "Şifre: " + sifre;


                Mail mail = new Mail();

                mail.hesapbilgi_gonder(icerik, email.Text);

                Label1.Text = yeni_hsno.ToString();
                Metotlar metot = new Metotlar();
                int sonuc1 = 0;
                sonuc1 = metot.hareket_olustur("1000000", "Hesap Açma", yeni_hsno.ToString(), "1000000");




            }
            catch
            {

                Label1.Text = "Başvuru alınamadı..";

            }

            finally
            {

                Response.Redirect("kayitalindi.aspx");


            }


        }





    


}