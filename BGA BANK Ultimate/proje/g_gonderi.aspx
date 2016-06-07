<%@ Page Title="" Language="C#" MasterPageFile="~/BireyselMasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="g_gonderi.aspx.cs" Inherits="g_gonderi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">
        function ActiveMenuSelection() {
            document.getElementById("liAnasayfa").removeAttribute(["class"]);
            document.getElementById("liHakkimizda").setAttribute(["class"], ["dropdown"]);
            document.getElementById("liIletisim").setAttribute(["class"], ["active"]);
            document.getElementById("liCıkıs").removeAttribute(["class"]);
        }
        window.onload = ActiveMenuSelection;
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
   <div class="row">
       <div class="span6">
           <div class="well well-small">
                <form id="form1" method="post" action="g_gonderi.aspx" runat="server">
               <h4>Müşteri Memnuniyeti/Şikayeti</h4>
                <div>
                    <br />
                    <div class="input-append">
				             <div class="control-group" aria-sort="none" aria-readonly="False">
				           <label class="btn btn-warning"><span class="input-group-addon" >@</span></label>                          
                                <asp:TextBox ID="AdSoyad" runat="server" placeholder="Ad Soyad giriniz"></asp:TextBox> 
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Ad soyad boş bırakılamaz" ControlToValidate="AdSoyad" Text="*">*</asp:RequiredFieldValidator>
				            </div>
                    </div>
                     
                    <div class="input-append">
				             <div class="control-group" aria-sort="none" aria-readonly="False">
				               <label class="btn btn-warning"><span class="icon-envelope" ></span></label>                             
                                    <asp:TextBox ID="Mesaj" runat="server" TextMode="MultiLine"  Height="225" placeholder="Mesaj giriniz" ></asp:TextBox>                    
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Mesaj boş bırakılamaz" ControlToValidate="Mesaj" Text="*">*</asp:RequiredFieldValidator>
				             <br />
                            </div>
                    </div>
                                <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="Kayıt" runat="server" />
                                <asp:Button ID="Button1" runat="server" Text="Gönder" class="btn btn-warning" ValidationGroup="Kayıt" OnClick="Button1_Click"   /><br />
                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </div>

                </form>  
           </div>
       </div>
        

       <div class="span6">

           <div class="well well-small">

               <h4>Müşterilerden Gelenler</h4>
                <table border="0" class="table table-striped" style="font-size:12px">
                                                         <thead>
                                                             <tr>
                                                                 <th>Ad Soyad</th>
                                                                 <th>Mesaj</th>
                                                              
                                                             </tr>

                                                         </thead>

                                                          

                                                             
                                                             <asp:Repeater ID="Repeater1" runat="server">
                                                                 <ItemTemplate>
                                                                  <tr>   
                                                                   <th> <%#Eval("adsoyad")%></th>
                                                                   <th> <%#Eval("mesaj")%></th>
                                                                
                                                                      </tr>
                                                                 </ItemTemplate>
                                                            </asp:Repeater>
                                                            
                                                           

			                                           </table>

              

           </div>


       </div>




   </div>

    




</asp:Content>

