<%@ Page Title="" Language="C#" MasterPageFile="~/Gli_BireyselMasterPage.master" AutoEventWireup="true" CodeFile="gli_ayar.aspx.cs" Inherits="gli_ayar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

  <div class="row">
      <div class="span10">
         
          <div class="well well-small">
           
               <h3>Kişisel Bilgileri Güncelleme </h3>
                   <fieldset>
                          <form id="form1" runat="server">
                              <div class="well-small">
				              
                                  <div class="input-append">
                                  <label class="btn btn-warning"><span class="icon-user" ></span></label>
                                    <asp:TextBox class="input-xlarge" ID="TextBox1"   runat="server"></asp:TextBox>
                                             
                                 
                                 </div>
                                </div>
                              <div class="well-small">
				                
                                  <div class="input-append">
                                  <label class="btn btn-warning"><span class="icon-user-md" ></span></label>
                                    <asp:TextBox class="input-xlarge" ID="soyad"   runat="server"></asp:TextBox>
                                             
                                 </div>
                                 
                                 </div>
                               <div class="well-small"> 
				               <div class="control-group">
                                  <div class="input-append">
                                  <label class="btn btn-warning"><span class="icon-envelope-alt" ></span></label>
                                    <asp:TextBox class="input-xlarge" ID="email"   runat="server"></asp:TextBox>
                                             
                                 </div>
                                 </div>
                                 </div>
                               <div class="well-small">
                               <div class="control-group">
                                  <div class="input-append">
                                  <label class="btn btn-warning"><span class="icon-phone" ></span></label>
                                    <asp:TextBox class="input-xlarge" ID="tel"   runat="server"></asp:TextBox>
                                             
                                 </div>
                                 </div>
                                </div>
                             <div class="well-small">
				             <div class="control-group">
                                  <div class="input-append">
                                  <label class="btn btn-warning"><i class="icon-tag" ></i></label>
                                    <asp:TextBox class="input-xlarge" ID="firma"   runat="server"></asp:TextBox>
                                             
                                 </div>
                                 </div>
                              </div>
                               <div class="well-small">
				             <div class="control-group">
                                  <div class="input-append">
                                  <label class="btn btn-warning"><span class="icon-truck" ></span></label>
                                    <asp:TextBox class="input-xlarge" ID="plaka"   runat="server"></asp:TextBox>
                                             
                                 </div>
                                 </div>
                              </div>

                         <div class="well-small">
				             <div class="control-group">
                                  <div class="input-append">
                                  <label class="btn btn-warning"><span class="icon-home" ></span></label>
                                    <asp:TextBox TextMode="MultiLine" class="input-xlarge" ID="Adres"   runat="server"></asp:TextBox>
                                             
                                 </div>
                                 </div>
                       </div>
                              

                             <div class="well-small">
                                  <div class="form-horizontal" > 
                                      <div class="row" ><div class="span4" style="margin: 0 auto !important;float: none !important;"> 
                                      <a>
                                      <div class="control-group">
                                          <div class="input-append">
                                               <label class="btn btn-warning"><span class="icon-camera" ></span></label>
                                             
                                               <asp:FileUpload ID="FileUpload1" class="input-file" runat="server" Style="margin:0px 13px 0px 10px"  ClientIDMode="Static"  onchange="dosyayukle()"/><br />
                                               
                                          </div><br />
                                       <asp:Label ID="Label1" runat="server" Text=""></asp:Label> 
                                       </div>
                                     </a>
                                      </div>
                                  </div>
                                      </div>
                               </div>           
                              <asp:Button ID="Button1" runat="server" Text="Gönder" class="btn btn-warning" ValidationGroup="Kayıt" OnClick="Button1_Click"  /><br />
                              <asp:Literal ID="Literal1" runat="server"></asp:Literal>
				          
                         </form>
				            </fieldset>

              </div>
      


          </div>


  </div>



</asp:Content>

