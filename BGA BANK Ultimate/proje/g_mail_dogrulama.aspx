<%@ Page Title="" Language="C#" MasterPageFile="~/IndexMasterPage.master" AutoEventWireup="true" CodeFile="g_mail_dogrulama.aspx.cs" Inherits="g_mail_dogrulama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row" style="text-align:center">
      <div class="span2"></div>
        
          <div class="span9">

            <div class="well well-small">
                <h4>Mail Doğrulama </h4>
                  <form id="form1" method="post" action="" runat="server">

                       <div class="input-append">
				                 <div class="control-group">
                                  <label class="btn btn-warning"><span class="icon-envelope-alt" ></span></label>
                                  <asp:TextBox class="input-xlarge" ID="aktivasyon" placeholder="Aktivasyon Kodunu Giriniz"  runat="server"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-error" runat="server" ValidationGroup="Kayıt"  ErrorMessage="Aktivasyon Kodu Boş Geçilemez" ControlToValidate="aktivasyon">*</asp:RequiredFieldValidator>
                                 </div>
                               </div>


                      

                       <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="Kayıt" runat="server" />
                       <asp:Button ID="Button1" runat="server" Text="Gönder" class="btn btn-warning" OnClick="Button1_Click" ValidationGroup="Kayıt"  /><br />
                      <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                      </form>


            </div>


        </div>



    </div>


</asp:Content>

