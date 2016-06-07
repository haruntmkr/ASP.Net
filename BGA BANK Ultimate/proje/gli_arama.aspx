﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Gli_IndexMasterPage.master" AutoEventWireup="true" CodeFile="gli_arama.aspx.cs" Inherits="arama" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">


       
    <div class="row" style="text-align:left">
            <div class="span8">
                        <div class="well well-small">
                            <h4>Arama Sonuçları</h4>
                            <div class="well well-small">   
                                <h5>Aranan Haber: <asp:Label ID="Label1" runat="server" Text=""></asp:Label> </h5>
                                <hr />
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                       <strong> Haber baslik: <%#Eval("haber_baslik") %></strong><br>
                                      <strong>  Haber detay:  <%#Eval("haber_detay") %></strong>
                                    </ItemTemplate>
                                </asp:Repeater>



                            </div>
                       </div>
            </div>

        <div class="span4"><%--arama kısmı başlangıcı--%>
                             <div class="well well-small">
                             <div class="form-search" style="text-align:center">
                                 <h5>Arama Yap</h5>
                                      <div class="col-sm-10">
                                       

                                          <asp:TextBox ID="TextBox1" CssClass="form-control"  runat="server"></asp:TextBox>

                                        </div>
                                <br />
                                 <input type="button" class="btn btn-warning" id="AraButton" value="Ara" runat="server" onserverclick="ara" onfocus="ChangeColour()"  />
                                 <%--<asp:Button class="btn btn-warning" ID="Button1" runat="server" Text="Ara" OnClick="ara" />--%>
                               
                              </div>  
                                </div>          
	   </div>



    </div>
    </form>

    


  


</asp:Content>

