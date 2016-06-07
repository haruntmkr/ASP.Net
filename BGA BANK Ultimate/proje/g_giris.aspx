<%@ Page Title="" Language="C#" MasterPageFile="~/BireyselMasterPage.master" AutoEventWireup="true" CodeFile="g_giris.aspx.cs" Inherits="g_giris" ValidateRequest="False" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   
    
    
    <div class="row">
        <div class="span4">

            <div class="well well-small" style="text-align:center">
                <h3><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3>
               <div class="well well-small">
                <img src="img/users/<%=_id%>.png" class="img-rounded" alt="Cinque Terre" width="304" height="236">
                <h5 style="text-align:left">
                <asp:datalist id="DataList1" runat="server">
                <itemtemplate> 
                 
                Hesap Bilgisi: <%#Eval("hesap")%> TL
                <br />
                Email : <%#Eval("email")%>
                <br />
                Telefon :<%#Eval("tel")%> 
                </itemtemplate>
                <separatortemplate><hr></separatortemplate>
                </asp:datalist> 
                Hesap Numarası: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>


                       
        

                    
                </h5> 
              </div>  
            

                   
                    
                              
          
         
            </div>
        </div>

         <!--Kutu başlangıç-->
                                 <div class="span5" >       <!--span 5 tag başlangıcı-->               

                                             <div class="span2">
                                                 <asp:HyperLink ID="HyperLink6" NavigateUrl="~/g_paratrans.aspx" Font-Underline="false" runat="server">
				                                 
				                                    <div class="well well-small">
					                                    <h4 style="margin:-9px -9px -10px">
					                                   <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-magic"></i>
					                                    <span><br/>EFT <br /> Havale </span>
					                                    </a>
					                                    </h4>
					                           
				                                    </div>
                                                 </asp:HyperLink>
			                                 </div>
                                             <div class="span2">
				                                 <asp:HyperLink ID="HyperLink5" NavigateUrl="~/g_ayar_ip.aspx" Font-Underline="false"  runat="server">
				                                 
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
                                                 <a  href="g_ozet.aspx?id=<%= _id %>" style="text-decoration:none;">
				                                 
				                                    <div class="well well-small">
					                                    <h4 style="margin:-9px -9px -10px">
					                                    <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-beaker"></i>
					                                    <span><br/>Hesap <br /> Özeti </span>
					                                    </a>
					                                    </h4>
					                                
				                                    </div>
                                            
			                                 </div>
                                             <div class="span2">
                                                 <asp:HyperLink ID="HyperLink3" NavigateUrl="~/g_atmbul.aspx" Font-Underline="false" runat="server">
				                                 
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
                                                 <asp:HyperLink ID="HyperLink2" NavigateUrl="g_TLyukle.aspx" Font-Underline="false" runat="server">
				                                        
				                                    <div class="well well-small">
					                                    <h4 style="margin:-9px -9px -10px">
					                                    <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-magic"></i>
					                                    <span><br/>Lira <br /> Yükleme </span>
					                                    </a>
					                                    </h4>
					                              
				                                    </div>
                                                     </asp:HyperLink>
                                              
    
			                                 </div>
                                              
                                             <div class="span2">
                                          
                                                  <asp:HyperLink ID="HyperLink1" NavigateUrl="~/g_ayar.aspx" Font-Underline="false" runat="server">
				                                        <div class="well well-small">
                                                                <h4 style="margin:-9px -9px -10px">
					                                             <i style="width:auto; font-size:2em; line-height:1em; height:auto; color:#FE5214" class="icon-wrench"></i>
					                                            <span><br/>Üye <br /> Ayarları </span>
					                                            </a>
					                                            </h4>
				                                        </div>
                                                  </asp:HyperLink>
			                                 </div>
                                                   
                                            </div> <!--span 5 tag sonu-->   
                                 <div class="span3">
                                             <div class="span4">
		                                            <div class="thumbnail">
			                                            <h4>Girişlerim</h4>
			                                            <a href="portfolio.html"><img src="themes/images/1.jpg" alt="bootstrap business templates"></a>
			                                            <p>
			                                            <br/>
			                                           <table border="0"  class="table table-striped" style="font-size:12px">
                                                         <thead>
                                                             <tr>
                                                                 <th>Hesap No</th>
                                                                 <th>Tarih</th>
                                                                 <th>Tarayıcı Bilgisi</th>
                                                                 <th>IP Adresleri</th>
                                                             </tr>
                                                         </thead>
                                                             <asp:Repeater ID="Repeater1" runat="server">
                                                                 <ItemTemplate>
                                                                  <tr>   
                                                                   <th> <%#Eval("hno")%></th>
                                                                   <th> <%#Eval("tarih")%></th>
                                                                   <th> <%#Eval("tarayici_bilgisi")%></th>
                                                                   <th><%#Eval("IP")%></th>
                                                                      </tr>
                                                                 </ItemTemplate>
                                                            </asp:Repeater>
			                                           </table>
			                                            </p>			                                        
		                                            </div>
	                                         </div>     
                                </div>
        <!--Kutu bitiş-->

       

    </div>
          

  
   


</asp:Content>

