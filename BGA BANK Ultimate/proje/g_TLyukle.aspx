<%@ Page Title="" Language="C#" ValidateRequest="False" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="g_TLyukle.aspx.cs" Inherits="g_TLyukle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row" >
        <div class="span5" style="text-align:center" >
              <div class="well well-small" style="margin-top:initial" >
		                                            <div class="thumbnail">
			                                            <h4>Hareketler</h4>
			                                            <a href=""><img src="themes/images/1.jpg" alt="bootstrap business templates"></a>
			                                            <p>
			                                            <br/>
                                                           
			                                           <table border="0" class="table table-striped" style="font-size:12px">
                                                         <thead>
                                                             <tr>
                                                                 <th>Hareket</th>
                                                                 <th>Tarih</th>
                                                                 <th>Önceki Hesap Bakiyesi</th>
                                                                 <th>Hesap Bakiyesi</th>
                                                             </tr>

                                                         </thead>

                                                          

                                                             
                                                             <asp:Repeater ID="Repeater1" runat="server">
                                                                 <ItemTemplate>
                                                                  <tr>   
                                                                   <th> <%#Eval("aciklama")%></th>
                                                                   <th> <%#Eval("tarih")%></th>
                                                                   <th> <%#Eval("para1")%></th>
                                                                   <th> <%#Eval("para2")%></th>
                                                                      </tr>
                                                                 </ItemTemplate>
                                                            </asp:Repeater>
                                                            
			                                           </table>
                                        
			                                            </p>
			                                        
		                                            </div>
	           </div> 
        </div>
        <div class="span7" style="text-align:center" >
            <div class="well well-small" style="margin-top:initial" >
                <h4>TL Yükle</h4>
                <fieldset>
                 <form method="get" action="" runat="server">

                     <div class="input-append">
                        <label class="btn btn-warning"><span class="icon-phone" ></span></label>
                        <asp:TextBox ID="TBoxGSM" CssClass="input-xxlarge" runat="server" placeholder="Gönderilecek GSM No Giriniz" onkeypress="return returnumber(event)" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-error" runat="server" ValidationGroup="TLYukle"  ErrorMessage="GSM numarası boş bırakılamaz" ControlToValidate="TBoxGSM">*</asp:RequiredFieldValidator>              
                        <br />
                     </div>
                     <div class="input-append">
                         <label style="padding:4px 15px" class="btn btn-warning"><span class="input-group-addon" >&#8378;</span></label>
                         <asp:TextBox ID="TBoxTL" CssClass="input-xxlarge"  runat="server" placeholder="Gönderilecek TL Miktarını Giriniz" onkeypress="return returnumber(event)"  ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-error" runat="server" ValidationGroup="TLYukle"  ErrorMessage="Gönderilecek miktar boş bırakılamaz" ControlToValidate="TBoxTL">*</asp:RequiredFieldValidator>  
                         <br />
                     </div>
                    
                     
                     <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="TLYukle" runat="server" CssClass="text-error" />
                     <asp:Button class="btn btn-warning" ID="BtnTLGonder" OnClick="Button1_Click" runat="server" Text="Gönder" ValidationGroup="TLYukle"/>
                 </form>
                  <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </fieldset>
            </div>
        </div>
    </div>
</asp:Content>

