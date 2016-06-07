<%@ Page Title="" Language="C#" ValidateRequest="False" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="g_ozet.aspx.cs" Inherits="g_ozet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="row">
        <div class="span4">
            <div class="well well-small">
                   <h3><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3>
               <div class="well well-small">
                 
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

        <div class="span8">
            <div class="well well-small">
                 <div class="well well-small">
      <h4>Hesap Özeti</h4>
          <table border="0" class="table table-striped" style="font-size:12px">
                                                         <thead>
                                                             <tr>
                                                                 <th>Hareket</th>
                                                                 <th>Tarih</th>
                                                                 <th>İşlem Yapılan Hesap</th>
                                                                 <th>Miktar</th>
                                                 
                                                             </tr>
                                                         </thead>
                                                             <asp:Repeater ID="Repeater1" runat="server">
                                                                 <ItemTemplate>
                                                                  <tr>   
                                                                 <%#detaylar(Eval("aciklama").ToString(),Eval("para1").ToString(),Eval("para2").ToString(),Eval("hno2").ToString(),Eval("tarih").ToString())%>
                                                                 

                                                                 
                                                                  
                                                                      </tr>
                                                                 </ItemTemplate>
                                                            </asp:Repeater>
			                                           </table> 

  </div>




            </div>


        </div>




    </div>

     

</asp:Content>

