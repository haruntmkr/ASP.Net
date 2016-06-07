<%@ Page Title="" ValidateRequest="False" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="g_ayar_ip.aspx.cs" Inherits="g_ayar_ip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
                    <div class="span6">
                       
                            <div class="well well-small">
                                 <h4>Giriş Yapılacak IP Adresleri</h4>

                                <form action="" method="get" runat="server">

                                
                                        
                                      <div class="control-group" style="text-align:center;margin:0px" >
				                     
				                        <div class="controls">
                                            <label class="checkbox" style="margin:3px;padding-left:150px;padding-right:300px">
                                          <asp:CheckBox type="checkbox"  ID="CheckBox1" runat="server" style="margin:0px"  />
				                            <span class="label label-info" style="margin:0px" >Yalnızca seçtiğim IP adresleri giriş yapabilsin</span>

                                           </label>
					                       
				                          
				                        </div>
			                      
                                    </div>
                                                     
                                      <div class="input-append" style="text-align:center">
                   
                                
                                      <label class="btn btn-warning"><span class="icon-link" ></span></label>
                                        <asp:TextBox class="input-xlarge" ID="TextBox1"  runat="server" placeholder="Eklemek istediğiniz IP adresini giriniz..." ></asp:TextBox><br />
                                     
                                     </div>
                                    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                                     
                                      <asp:Button class="btn btn-warning"  ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" /><br/><br />
                                     
                       
                        </div>
                </div>

            <div class="span4">
                <div class="well well-small">
                    <h4>Mail Doğrulama</h4>
                     <div class="control-group" style="text-align:center;margin:0px" >
				                     
				                        <div class="controls">
                                            <label class="checkbox" style="margin:3px;padding-left:50px;padding-right:300px">
                                          <asp:CheckBox type="checkbox"  ID="CheckBox2" runat="server" style="margin:0px" />
				                            <span class="label label-info" style="margin:0px" >Girişte Mail Adresime Aktivasyon Kodu Gönder</span>

                                           </label>
					                       
				                          
				                        </div>
			                      
                                    </div>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                      <asp:Button class="btn btn-warning"  ID="Button2" runat="server" Text="Gönder" OnClick="Button2_Click" /><br/><br />
                      </form>
                </div>
                


          <div class="well well-small" style="text-align:center">
               <h4>IP Listem </h4>
                    <table border="0" class="table table-striped" style="font-size:12px">
                                                         <thead>
                                                             <tr>
                                                                 <th>Hesap Numarası</th>
                                                                 <th>IP</th>
                                                              
                                                             </tr>
                                                         </thead>
                                                             <asp:Repeater ID="Repeater1" runat="server">
                                                                 <ItemTemplate>
                                                                  <tr>   
                                                                   <th> <%#Eval("hno")%></th>
                                                                   <th> <%#Eval("IP")%></th>
                                                                
                                                                      </tr>
                                                                 </ItemTemplate>
                                                            </asp:Repeater>
			                                           </table>
            </div>

                                       
          







            </div>


</asp:Content>
