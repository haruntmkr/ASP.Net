<%@ Page Title="" Language="C#" ValidateRequest="False" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="g_paratrans.aspx.cs" Inherits="g_paratrans" %>

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
                <h4>Havale Yap</h4>
                 <form action="g_paratrans.aspx" method="get" runat="server">
                     
                      <div class="input-append">
                      <label class="btn btn-warning"><span class="icon-link" ></span></label>
                        <asp:TextBox class="input-xxlarge" ID="TextBox1" onkeypress="return returnumber(event)" runat="server" placeholder="Gönderilecek müşteri numarası giriniz." ></asp:TextBox><br />
                                     
                     </div>

                     <div class="input-append">
                      <label style="padding:4px 15px" class="btn btn-warning"><span class="input-group-addon" >&#8378;</span></label>
                         <asp:TextBox class="input-xxlarge" ID="TextBox2" onkeypress="return returnumber(event)" runat="server" placeholder="Gönderilecek miktarı giriniz."   ></asp:TextBox><br />
                 
                     </div>

                      <asp:Button class="btn btn-warning"  ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" /><br/><br />
                     <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                 </form>
          </div>
        </div>



    </div>
   

</asp:Content>

