<%@ Page Title="" ValidateRequest="False" Language="C#" MasterPageFile="~/IndexMasterPage.master" AutoEventWireup="true" CodeFile="g_index.aspx.cs" Inherits="g_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <script type="text/javascript">
       function ChangeColour() {
           document.getElementById('AraButton').setAttribute('class', 'btn btn-primary');
       }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    
           <div class="row" > <%--1. ana satır--%>
                <div class="span9" style="margin-right:20px"> <%--sol taraftaki panel başlangıcı--%>
                    <div class="row" ><%--1.1. Satır başlangıcı--%>
                       
                              <div class="span9">  
                                  <div class="well well-small" style="text-align:left""> 
                                      <h3> BGA BANK'a Hoşgeldiniz </h3>
                                         BGA BANK İstismar Edilebilir Bankacılık Uygulaması BGA Bilgi Güvenliği Akademisi firmasının web güvenlik zafiyetlerinin anlaşılması ve daha iyi kavranabilmesi için başlatılmıştır. Firmanın verdiği eğitimlerde web uygulamaları güvenlik zafiyetlerine ait örneklerin daha anlaşılır olabilmesi ve bir bankacılık uygulaması üzerinde olası bir zafiyetin ne derece tehlikeli boyutlara ulaşacağı daha net anlaşılmaktadır. 
<br />BGA BANK Ultimate sürümünde önceki sürümlerden farklı olarak ASP.NET platformu ve üç aşamalı bir güvenlik anlayışı kazandırılmıştır. Proje bir çok bankanın sunduğu hizmetleri içinde barındırarak gerçek bir çevrim içi bankacılık uygulaması görünümüne kavuşturulmuştur. Bu sayede firmanın verdiği eğitimlerde ya da çevrim içi uygulamayı kullanacak kişiler web güvenlik zafiyetleri konusunu daha iyi kavrayabilecek ve tehlikelerin somut etkilerini görebilecekler. 
<br />BGA BANK Ultimate, BGA Bilgi Güvenliği firmasıyla üniversite sanayi iş birliği kapsamında yapılmış bir projedir. <br /><b>TÜBİTAK 2209/B - Sanayi Odaklı Lisans Bitirme Tezi Destekleme Programı ile desteklenmiştir.</b>
<br />BGA BANK Ultimate üç aşamalı güvenlik katmanına sahiptir. İlk aşamada kullanıcılar sistemi güvenlik önlemi olmadan analiz edebilecektir. İkinci aşamada sunucu ile kullanıcıların arasındaki trafiği denetleyen bir web uygulaması güvenlik duvarı olan modsecurity bulunmaktadır. Üçüncü aşamada ise birinci aşamada sistemde bırakılan açıklar kapatılarak oluşturulmuş güvenli bir çevrim içi bankacılık  uygulaması sunulmaktadır.

                                 </div>

                              </div>
   
                    </div><%--1.1. Satır bitişi--%>
                    <br /><hr /><br />
                    <div class="row"><%--1.2. Satır başlangıcı--%>
		                    <div class="span3">
		                       	    <a href="http://www.bga.com.tr/" style="text-decoration:none;">
						                <div class="thumbnail">
							                <br/>
							                <img alt="300x200" src="img/bga_thumb.png" />
									                <h3>
										                BGA
									                </h3>
									                <p>
										                BGA Resmi Sitesi
									                </p>
						                </div>
					                </a>
	                        </div>
                            <div class="span3">
		                           <a href="http://blog.bga.com.tr/" style="text-decoration:none;">
						                <div class="thumbnail">
							                <br/>
							                <img alt="300x200" src="img/blog_thumb.png" />
									                <h3>
										                BGA - Blog
									                </h3>
									                <p>
										                BGA Blog Sitesi
									                </p>
						                </div>
					                </a>
	                        </div>
                            <div class="span3">
		                              <a href="http://www.bga.com.tr/egitimler.html" style="text-decoration:none;">	
						                <div class="thumbnail">
							                <br/>
							                <img alt="300x200" src="img/egitim_thumb.png" />
							               <br />
								               
									                <h3 >
										                Eğitimler
									                </h3>
									                <p>
										                Eğitimlere ait özet bilgiler
									                </p>
								                
							               
						                </div>
					                </a>

	                         </div>
                    </div><%--1.2. Satır bitişi--%>
                    <br /><hr /><br />
                    <br />
                     <div class="row"><%--1.3. ana Satır başlangıcı--%>
                        
                         <asp:Label CssClass="pull-left" runat="server"></asp:Label>
                            <div class="span2">
				                                 <asp:HyperLink ID="HyperLink5" NavigateUrl="g_paratrans.aspx" Font-Underline="false" runat="server">
				                                 
                                                    <div class="well well-small">
					                                   <h4 style="margin:-9px -9px -10px">
					                                    <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-magic"></i>
					                                    <span><br/>EFT <br /> Havale</span>
					                                    </a>
					                                    </h4>
					                           
				                                    </div>
                                               </asp:HyperLink>
			                                 </div>
                             <div class="span2">
				                                 <asp:HyperLink ID="HyperLink1" NavigateUrl="g_ayar_ip.aspx" Font-Underline="false" runat="server">
				                                 
                                                    <div class="well well-small">
					                                   <h4 style="margin:-9px -9px -10px">
					                                    <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-magic"></i>
					                                    <span><br/>IP <br /> Adreslerim </span>
					                                    </a>
					                                    </h4>
					                           
				                                    </div>
                                               </asp:HyperLink>
			                                 </div>
                           <div class="span2">
				                                 <asp:HyperLink ID="HyperLink2" NavigateUrl="g_atmbul.aspx" Font-Underline="false" runat="server">
				                                 
                                                    <div class="well well-small">
					                                   <h4 style="margin:-9px -9px -10px">
					                                    <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-magic"></i>
					                                    <span><br/>Şube/ATM <br /> Bulucu</span>
					                                    </a>
					                                    </h4>
					                           
				                                    </div>
                                               </asp:HyperLink>
			                                 </div>
                           <div class="span2">
				                                 <asp:HyperLink ID="HyperLink3" NavigateUrl="g_TLyukle.aspx" Font-Underline="false" runat="server">
				                                 
                                                    <div class="well well-small">
					                                   <h4 style="margin:-9px -9px -10px">
					                                    <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-magic"></i>
					                                    <span><br/>Lira <br /> Yükleme </span>
					                                    </a>
					                                    </h4>
					                           
				                                    </div>
                                               </asp:HyperLink>
			                                 </div>
                     
                    </div><%--1.3. ana Satır bitişi--%>
           		</div>	<%--sol taraftaki panel bitişi--%>

				<div class="span3"> <%--Sağ taraftaki panel başlangıcı--%>
                    <div class="row">
                  
                          <div class="well well-small"><%--arama kısmı başlangıcı--%>
                              <div class="form-search">
                                 <h5>Arama Yap</h5>
                                      <div class="col-sm-10">
                                    <form action="" method="get" runat="server">    

                                          <asp:TextBox ID="TextBox1" CssClass="form-control"  runat="server"></asp:TextBox>

                                        </div>
                                <br />
                                 <input type="button" class="btn btn-warning" id="AraButton" value="Ara" runat="server" onserverclick="ara" onfocus="ChangeColour()"  />
                                   </form>
                                 <%--<asp:Button class="btn btn-warning" ID="Button1" runat="server" Text="Ara" OnClick="ara" />--%>
                       
                              </div>            
	                      </div> <%--arama kısmı bitişi--%>  
                     </div>		
            
                     <div class="row">
                         <div class="well well-small">
                             <h4>Haberler</h4>
                         <%--haber kısmı başlangıcı--%>
                              <div class="well well-small" ><%--1. Haber elemanı başlangıcı--%>
                                  <asp:HyperLink ID="NewsLink1" runat="server">
                                     <asp:Label ID="NewsTitle1" CssClass="" runat ="server"></asp:Label><br />
                                        <ul class="thumbnails" style="text-align:left">
                                         <li class="span1">
                                             <asp:Image ID="NewsImage1" class="img-rounded" Style="margin-right:500px" BorderStyle="Inset" BorderWidth="1" ImageAlign="Left" runat="server"/>
                                         </li>
                                         <div class="row">
                                                     <li class="span2">
                                                     <asp:Label ID="NewsDescription1" Font-Size="XX-Small" ForeColor="Black"  runat="server"></asp:Label>
                                                    </li>
                                         </div>
                                      </ul>
                                  </asp:HyperLink>
                              </div><%--1. Haber elemanı bitişi--%>
                              <div class="well well-small"><%--2. Haber elemanı başlangıcı--%>
                                  <asp:HyperLink ID="NewsLink2" runat="server">
                                     <asp:Label ID="NewsTitle2" CssClass="caption" runat ="server"></asp:Label><br/>
                                     <ul class="thumbnails" style="text-align:left">
                                         <li class="span1">
                                             <asp:Image ID="NewsImage2" class="img-rounded" Style="margin-right:500px" BorderStyle="Inset" BorderWidth="1" ImageAlign="Left" runat="server"/>
                                         </li>
                                         <div class="row">
                                                     <li class="span2">
                                                     <asp:Label ID="NewsDescription2" Font-Size="XX-Small" ForeColor="Black"  runat="server"></asp:Label>
                                                    </li>
                                         </div>
                                      </ul>
                                  </asp:HyperLink>
                              </div><%--2. Haber elemanı bitişi--%>
                              <div class="well well-small"><%--3. Haber elemanı başlangıcı--%>
                                  <asp:HyperLink ID="NewsLink3" runat="server">
                                     <asp:Label ID="NewsTitle3" CssClass="caption" runat ="server"></asp:Label><br />
                                      <ul class="thumbnails" style="text-align:left">
                                         <li class="span1">
                                             <asp:Image ID="NewsImage3" class="img-rounded" Style="margin-right:500px" BorderStyle="Inset" BorderWidth="1" ImageAlign="Left" runat="server"/>
                                         </li>
                                         <div class="row">
                                                     <li class="span2">
                                                     <asp:Label ID="NewsDescription3" Font-Size="XX-Small" ForeColor="Black"  runat="server"></asp:Label>
                                                    </li>
                                         </div>
                                      </ul>
                                  </asp:HyperLink>
                              </div><%--3. Haber elemanı bitişi--%>
                        <%--haber kısmı bitişi--%>
                     </div>			     
                </div><%--sağ taraftaki panel bitişi--%>
              </div>



            </div><%--1. ana satır bitişi--%>
           
           
    

</asp:Content>

