<%@ Page Title="" ValidateRequest="False" Language="C#" MasterPageFile="~/IndexMasterPage.master" AutoEventWireup="true" CodeFile="g_iletisim.aspx.cs" Inherits="g_iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
                <script type="text/javascript" >
                    function InitializeMap() {
                        ActiveMenuSelection();
                        document.getElementById("liIletisim").setAttribute(["class"], ["active"]);
                        var latlng = new google.maps.LatLng(40.9773, 29.0966);
                        var myOptions = {
                            zoom: 11,
                            center: latlng,
                            mapTypeId: google.maps.MapTypeId.ROADMAP
                        };
                    
                        var map = new google.maps.Map(document.getElementById("map"), myOptions);
                        var marker = new google.maps.Marker
                      (
                          {
                              position: new google.maps.LatLng(40.9773, 29.0966),
                              map: map,
                              title: '19 Mayıs Mah. İnönü Cad. Çetinkaya İş Merkezi No:92 Kat:4 KADIKÖY/İSTANBUL'
                          }
                      );
                    }
                    function ActiveMenuSelection() {
                        document.getElementById("liAnasayfa").removeAttribute(["class"]);
                        document.getElementById("liBasvuru").removeAttribute(["class"]);
                        document.getElementById("liBireysel").removeAttribute(["class"]);
                        document.getElementById("liTicari").removeAttribute(["class"]);
                        document.getElementById("liHakkimizda").removeAttribute(["class"]);
                        document.getElementById("liIletisim").setAttribute(["class"], ["active"]);
                    }
                    window.onload = InitializeMap;
                   
                </script>
    <script type="text/javascript">
        function iletisim_form_focus() {//Validasyon false olduğunda scrollu forma çekiyor.
            document.getElementById("iletisim_form_div").scrollIntoView();
        };
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row"><%--1.Satır-Başlangıç--%>
        <div class="span6"><%--Sol panel-Başlangıç--%>
             <div id="iletisim_form_div" class="well">
                         <h5 style="color:darkorange;text-align:center"><i class="icon-file"></i>İLETİŞİM FORMU</h5><hr />
                          <div class="row">              
                               <div class="span6 offset1" style="align-items:center">
                                     <form id="iletisim_form" name="iletisim_form" action="g_iletisim.aspx" method="post" class="form-inline" runat="server" >
                                     <fieldset>
                                        <div class="row">
                                            <div class="span2" style="text-align:left">
                                               <div class="control-group">
                                                   <asp:RequiredFieldValidator ID="RequiredFieldValidatorAd" CssClass="text-error" runat="server" ValidationGroup="iletisim"  ErrorMessage="Adınız boş bırakılamaz." ControlToValidate="adi" Display="Dynamic" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                                                   <label style="color:darkorange">Adınız : </label><br />
                                                   <asp:TextBox id="adi" name="adi" CssClass="input-xlarge" runat="server" />
                                               </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="span2" style="text-align:left">
                                                 <div class="control-group">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-error" runat="server" ValidationGroup="iletisim"  ErrorMessage="Soyadınız boş bırakılamaz." ControlToValidate="soyadi" Display="Dynamic" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                                                    <label style="color:darkorange" >Soyadınız : </label><br />
                                                    <asp:TextBox  id="soyadi" name="soyadi" CssClass="input-xlarge" runat="server"/>
                                                    
                                                 </div>
                                             </div>
                                        </div>
                                         <div class="row">
                                             <div class="span2" style="text-align:left">
                                                <div class="control-group">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="text-error" runat="server" ValidationGroup="iletisim"  ErrorMessage="E-Postanız boş bırakılamaz." ControlToValidate="eposta" Display="Dynamic" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                                                    <label style="color:darkorange">E-Posta Adresiniz : </label><br />
                                                    <asp:TextBox  id="eposta" name="eposta" CssClass="input-xlarge" runat="server" />
                                                    
                                                </div>
                                            </div>
                                         </div>
                                         <div class="row">
                                            <div class="span4" style="text-align:left">
                                                <div class="control-group">
                                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="text-error" runat="server" ValidationGroup="iletisim"  ErrorMessage="Mesajınız boş bırakılamaz." ControlToValidate="mesaj" Display="Dynamic" SetFocusOnError="true">*</asp:RequiredFieldValidator>
                                                    <label style="color:darkorange" >Mesajınız : </label><br />
                                                    <textarea id="mesaj" name="mesaj" class="input-xlarge"  runat="server"></textarea><br />    
                                                    <label id="mesaj_bilgi_label" name="mesaj_bilgi_label" class="text-success" visible="false" runat="server">Mesajınız alınmıştır.</label>
                                                </div>    
                                            </div>
                                        </div>
                                         <div class="row" onload="iletisim_form_focus()"> 
                                             <div class="span4" style="text-align:center">
                                               <div class="control-label"  style="text-align:center">
                                                    <asp:ValidationSummary ID="ValidationSummary2" ValidationGroup="iletisim" runat="server" DisplayMode="BulletList" CssClass="text-error" Visible="true"  />
                                               </div>
                                                 <a href="" onclick="iletisim_form_focus()"> <!--Butona tıklanınca bunada tıklanacak ve validasyon false ise sayfayı forma focus yapacak-->
                                                    <asp:Button class="btn btn-warning" ID="gönder" runat="server" Text="Mesajı Gönder"  ValidationGroup="iletisim" OnClick="gönder_Click"/>
                                                 </a>
                                             </div>
                                         </div>
                                    </fieldset>
                                    </form>
                             </div>
                         </div>   
                    </div>
        </div><%--Sol panel-Bitiş--%>
        <div class="span6"><%--Sağ panel-Başlangıç--%>
            <div class="well" style="text-align:left"><%--İletişim Bilgileri-Başlangıç--%>
                <h5 style="color:darkorange;text-align:center"><i class="icon-align-left"></i>İLETİŞİM BİLGİLERİ</h5><hr />
                <i class="icon-home" style="color:darkorange "></i><asp:Label ID="Adres" runat="server">19 Mayıs Mah. İnönü Cad. Çetinkaya İş Merkezi No:92 Kat:4 KADIKÖY/İSTANBUL</asp:Label><br/><hr/>
                <i class="icon-phone" style="color:darkorange"></i><asp:Label ID="Tel" runat="server">+90 (216) 474 0038</asp:Label><br/><hr/>
                <i class="icon-print" style="color:darkorange"></i><asp:Label ID="Label1" runat="server">(Fax) +90 (216) 474 0038</asp:Label><br/><hr/>
                <i class="icon-envelope-alt" style="color:darkorange"></i><asp:Label ID="Label2" runat="server">bilgi@bga.com.tr</asp:Label><br/><hr/>
                <i class="icon-map-marker" style="color:darkorange"></i><asp:Label ID="Label3" runat="server">Google Maps'te Bul</asp:Label><br/><hr/>
                <p style="text-align:left"> 
                    Eğitim ve danışmanlık hizmetleri hakkında sorularınız için <b>bilgi@bga.com.tr</b> 
                    adresine e-posta gönderebilir veya aşağıdaki formu doldurarak bizlere 
                    ulaştırabilirsiniz.</p>
            </div><%--İletişim Bilgileri-Bitiş--%>
        </div><%--Sağ panel-Bitiş--%>
    </div><%--1.Satır-Bitiş--%>
    <div class="row"><%--2.Satır-Başlangıç--%>
        <div class="span12 ">
            <div class="well"><%--Lokasyon GoogleHaritalar üzerinden-Başlangıç--%>
                <h5 style="color:darkorange"><i class="icon-map-marker"></i>HARİTA</h5><hr />
                <div id="map"  style="width:auto; height: 377px; margin:13px; border: double 5px orange"></div>
            </div><%--Lokasyon GoogleHaritalar üzerinden-Bitiş--%>
                   
        </div>
    </div><%--2.Satır-Bitiş--%>
</asp:Content>

