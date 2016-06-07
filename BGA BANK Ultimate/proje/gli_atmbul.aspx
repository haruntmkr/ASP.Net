<%@ Page Title="" Language="C#" MasterPageFile="~/Gli_Menu.master" AutoEventWireup="true" CodeFile="gli_atmbul.aspx.cs" Inherits="gli_atmbul" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                     <div class="row">
                         <div class="span8">
                             <div class="well">
                                 
                                     <%if (arama == "")
                                     {%>
                                                <div class="alert alert-error"><h5 style="color:orangered">Şube/ATM Arama</h5></div><hr />
                                                        <table class="table table-striped">
                                                            <thead>
                                                                <tr>
                                                                    <th>Ad</th>
                                                                    <th>Adres</th>
                                                                    <th>Şube/ATM</th>
                                                                    <th>Durum</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                                <asp:Repeater ID="Repeater1" runat="server">
                                                                    <ItemTemplate>
                                                                        <tr>
                                                                            <td><%#Eval("ad")%></td>
                                                                            <td><%#Eval("adres")%></td>
                                                                            <td><%#Eval("tip")%></td>
                                                                            <td><%#Eval("durum")%></td>  
                                                                        </tr>
                                                                    </ItemTemplate>
                                                                </asp:Repeater>
                                                            </tbody>
                                                        </table>
                                                        <hr />
                                                            <div class="alert alert-danger">
                                                                 <h5>Aranacak bir değer giriniz.</h5>
                                                            </div>
                                                      
                                      <%}
                                      else
                                      {%>
                                              <div class="alert alert-success"><h5 style="color:orangered">Şube/ATM Arama</h5></div><hr/>
                                                    <table class="table table-striped">
                                                        <thead>
                                                            <tr>
                                                                 <th>Ad</th>
                                                                 <th>Adres</th>
                                                                 <th>Şube/ATM</th>
                                                                 <th>Durum</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <asp:Repeater ID="subeRepeater" runat="server">
                                                                <ItemTemplate>
                                                                    <tr>
                                                                        <td><%#Eval("ad")%></td>
                                                                        <td><%#Eval("adres")%></td>
                                                                        <td><%#Eval("tip")%></td>
                                                                        <td><%#Eval("durum")%></td>  
                                                                    </tr>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </tbody>
                                                    </table>
                                                    <hr />
                                                        <div class="alert alert-success">
                                                             <i><b><%=arama%></b></i><h5>değeri ile arama sonucunda bulunan Şube/ATM'ler.</h5>
                                                        </div>
                                                    
                                     <%}%>
                             </div>
                         </div>
                         <div class="span4">
                              <div class="well well-small"><%--arama kısmı başlangıcı--%>
                                  <div class="form-search">
                                      <form action="" method="get"  runat="server">
                                         <div class="thumbnail" ><h5 style="color:orangered">Şube/ATM Arama</h5></div>
                                          <br /> <br />
                                              <div class="col-sm-10">
                                                  <label class="btn btn-warning"><span class="icon-search" ></span></label><asp:TextBox ID="TextBox1" CssClass="form-control input-xlarge" placeholder="Aranacak kelimeyi giriniz..." runat="server"></asp:TextBox>
                                              </div>
                                         <br />
                                         
                                         <asp:Button class="btn btn-warning" ID="Button1" OnClick="Button1_Click" runat="server" Text="Arama" />
                                      </form>
                                  </div>            
	                          </div><%--arama kısmı bitişi--%>  
                        </div>
                     </div>		
</asp:Content>

