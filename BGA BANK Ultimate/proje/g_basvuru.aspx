<%@ Page Title="" ValidateRequest="False" Language="C#" MasterPageFile="~/IndexMasterPage.master" AutoEventWireup="true" CodeFile="g_basvuru.aspx.cs" Inherits="g_basvuru" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function ActiveMenuSelection() {
            document.getElementById("liAnasayfa").removeAttribute(["class"]);
            document.getElementById("liBasvuru").setAttribute(["class"], ["active"]);
            document.getElementById("liBireysel").removeAttribute(["class"]);
            document.getElementById("liTicari").removeAttribute(["class"]);
            document.getElementById("liHakkimizda").removeAttribute(["class"]);
            document.getElementById("liIletisim").removeAttribute(["class"]);
        }
        window.onload = ActiveMenuSelection;
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
    <form id="form1" method="post" action="g_basvuru.aspx" runat="server">

    <div class="row">
        
                    <div class="span12" style="text-align:center">
                        <div class="well well-small">
				            <h3>Hemen Başvurun</h3>
				            <fieldset>
                               <div class="input-append">
				                 <div class="control-group">
                                  <label class="btn btn-warning"><span class="icon-user" ></span></label>
                                  <asp:TextBox class="input-xlarge" ID="UserName" placeholder="İsim Giriniz"  runat="server"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-error" runat="server" ValidationGroup="Kayıt"  ErrorMessage="İsim Boş bırakılamaz" ControlToValidate="UserName">*</asp:RequiredFieldValidator>
                                 </div>
                               </div>

                                <div class="input-append">
				                    <div class="control-group">
                                      <label class="btn btn-warning"><span class="icon-user-md" ></span></label>
                                      <asp:TextBox ID="soyad" runat="server" placeholder="Soyad Giriniz" class="input-xlarge"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Soyad Boş bırakılamaz" ControlToValidate="soyad">*</asp:RequiredFieldValidator>
				                    </div>
                                </div>

                                    <div class="input-append">
				                        <div class="control-group">
                                            <label class="btn btn-warning"><span class="icon-envelope-alt" ></span></label>
                                          <asp:TextBox ID="email" runat="server" placeholder="Eposta Giriniz"  class="input-xlarge"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Mail Boş bırakılamaz" ControlToValidate="email">*</asp:RequiredFieldValidator>
				                        </div>
                                  </div>

                                <div class="input-append">      
                                     <div class="control-group">
                                      <label class="btn btn-warning"><span class="icon-truck" ></span></label>
                                      <asp:TextBox ID="plaka" runat="server" placeholder="Plaka Giriniz"  class="input-xlarge"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator7" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Mail Boş bırakılamaz" ControlToValidate="email">*</asp:RequiredFieldValidator>
				                     </div>
                                </div>


                                <div class="input-append">
                                     <div class="control-group">
                                          <label class="btn btn-warning"><span class="icon-tag" ></span></label> 
                                      <asp:TextBox ID="firma" runat="server" placeholder="Firma Giriniz"  class="input-xlarge"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Mail Boş bırakılamaz" ControlToValidate="email">*</asp:RequiredFieldValidator>
				                      </div>
                                </div>

                                <div class="input-append">
                                      <div class="control-group">  
                                          <label class="btn btn-warning"><span class="icon-phone" ></span></label>
                                          <asp:TextBox ID="tel" runat="server" placeholder="Telefon Giriniz" class="input-xlarge"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Telefon Bilgisi Boş bırakılamaz" ControlToValidate="tel">*</asp:RequiredFieldValidator>

				                      </div>
                                </div>
                           

                            <div class="input-append">
				              <div class="control-group" aria-sort="none" aria-readonly="False">
					             <label class="btn btn-warning"><span class="icon-home" ></span></label>
                                  <asp:TextBox ID="Adres" runat="server" TextMode="MultiLine" placeholder="Adres Bilgisi Giriniz " class="input-xlarge"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="text-error" runat="server" ValidationGroup="Kayıt" ErrorMessage="Adres Bilgisi boş bırakılamaz" ControlToValidate="Adres" Text="*">*</asp:RequiredFieldValidator>
				              </div>
                            </div>
                             
                            <div class="input-append">
                              	 <div class="controls">
                                       <label class="btn btn-warning"><span class="icon-group" ></span></label>
                                <asp:DropDownList ID="bireyselkurumsal" runat="server">
                                  <asp:ListItem Value="None">Üyelik tipi seçiniz</asp:ListItem> 
                                    <asp:ListItem Value="0">Bireysel</asp:ListItem>
                                    <asp:ListItem Value="1">Ticari</asp:ListItem>

                                </asp:DropDownList>

                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="bireyselkurumsal"
                ErrorMessage="Üye Tipi Seçiniz" ValidationGroup="Kayıt" InitialValue="None" >*</asp:RequiredFieldValidator>

                                </div>
                                </div>



                                <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="Kayıt" runat="server" />

                               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                              
                                <asp:Button ID="Button1" runat="server" Text="Gönder" class="btn btn-primary" OnClick="Button1_Click" ValidationGroup="Kayıt"  />
				

				            </fieldset>
			                  </div>
			            </div>



          

  



    </form>



</asp:Content>

