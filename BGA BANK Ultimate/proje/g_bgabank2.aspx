<%@ Page Title="" ValidateRequest="False" Language="C#" MasterPageFile="~/BireyselMasterPage.master" AutoEventWireup="true" CodeFile="g_bgabank2.aspx.cs" Inherits="g_bgabank2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <script type="text/javascript">
          function ActiveMenuSelection() {
              document.getElementById("liAnasayfa").removeAttribute(["class"]);
              document.getElementById("liBasvuru").removeAttribute(["class"]);
              document.getElementById("liBireysel").removeAttribute(["class"]);
              document.getElementById("liTicari").removeAttribute(["class"]);
              document.getElementById("liHakkimizda").setAttribute(["class"], ["active"]);
              document.getElementById("liIletisim").removeAttribute(["class"]);
          }
          window.onload = ActiveMenuSelection;
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
       

          <div class="span9" style="margin-right:30px"><!--Sol taraftaki panel***başlangıç-->
               <div class="well well-small">
                     <h4>BGA BANK</h4>
                   <p><a href="http://www.bga.com.tr">BGA-Bilgi Güvenlği AKADEMİSİ</a><br />

                       eğitimlerinde kullanılmak üzere geliştirilmiş çeşitli zafiyetler içeren internet bankacılığı uygulamasıdır. Benzeri uygulamalardan en temel farkı internet bankacılığı sistemlerinde varolan/olabilecek güvenlik zafiyetlerini içermesidir. Doğrudan hangi açıklığın hangi menüde olduğu yazmaz, kullanıcının sistemi kullanırken bulmasını bekler.

Sistem düzenli olarak sıfırlanmaktadır.

BGA BANk hakkında önerileriniz ve geri bildirimleriniz için bgabank@bga.com.tr adresine e-posta gönderebilirsiniz. 
  
ASP.Net platformunda C# yazılım diliyle yazılmış olan projede bir çok güvenlik zafiyeti bulunmaktadır. 




                       <ul style="list-style-type:none">
                        <li>SQL Injection</li>
                        <li>HPP - HTTP Parametre Pollution</li>
                        <li>Login Bypass</li>
                        <li>Cross Site Scripting - Stored</li>
                        <li>Cross Site Scripting - Reflected</li>
                        <li>File Upload</li>
                        <li>Admin yetkilerine sahip veritabanı kullanıcısı</li>
                        <li>Robots.txt dosyası hassas veri ifşası</li>
                        <li>Tahmin edilebilir kullanıcı ve parola bilgisi</li>
                        <li>X-Forwarded-For</li>
                        <li>Çerez değerleriyle oynayarak hak yükseltme</li>
                        <li>Versiyon ifşası</li>
                        <li>Hassas veri ifşası</li>
                        <li>Insecure Direct Object Reference</li>
                    </ul>
                    </p>
                </div>
          </div><!--Sol taraftaki panel***bitiş-->
        
    </div>

</asp:Content>

