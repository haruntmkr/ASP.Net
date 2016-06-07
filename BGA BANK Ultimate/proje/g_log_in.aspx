<%@ Page Title="Giriş Sayfası" Language="C#" MasterPageFile="~/IndexMasterPage.master" ValidateRequest="False" AutoEventWireup="true" CodeFile="g_log_in.aspx.cs" Inherits="g_log_in" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <script type="text/javascript">
     
        function ActiveMenuSelection() {
            var page = window.location.search;
            if (page == "?page=ticari") {
                document.getElementById("liTicari").setAttribute(["class"], ["active"]);
                document.getElementById("liBireysel").removeAttribute(["class"]);
                document.getElementById("baslik").innerText = "Ticari Giriş";
            }else if (page == "?page=bireysel") {
                document.getElementById("liBi reysel").setAttribute(["class"], ["active"]);
                document.getElementById("liTicari").removeAttribute(["class"]);
            } else {
                document.getElementById("liBireysel").setAttribute(["class"], ["active"]);
                document.getElementById("liTicari").removeAttribute(["class"]);
            }
                
            document.getElementById("liAnasayfa").removeAttribute(["class"]);
            document.getElementById("liBasvuru").removeAttribute(["class"]);
            document.getElementById("liHakkimizda").removeAttribute(["class"]);
            document.getElementById("liIletisim").removeAttribute(["class"]);
        }
        window.onload = ActiveMenuSelection;
    

function OpenPopup() {

    popup("g_sifremi_unuttum.aspx");

}

function popup(url) {

    var width = 600;

    var height = 400;

    var left = (screen.width - width) / 2;

    var top = (screen.height - height) / 2;

    var params = 'width=' + width + ', height=' + height;

    params += ', top=' + top + ', left=' + left;

    params += ', directories=no';

    params += ', location=no';

    params += ', menubar=no';

    params += ', resizable=no';

    params += ', scrollbars=yes';

    params += ', status=no';

    params += ', toolbar=no';

    newwin = window.open(url, 'popupwindow', params);

    if (window.focus) { newwin.focus() }

    return false;
}


</script>
   
    <div class="well well-small">
    <div class="col-md-6 col-md-offset-3 " style="text-align:center">
        <div class="" style="text-align:center">
            <div class="panel-heading">
                <h3 id="baslik" class="panel-title pt">
                    Bireysel Giriş
                 </h3>
               <form action="g_log_in.aspx" class="form-inline" method="get" runat="server">
                  <br />
                  <label class="btn btn-warning"><span class="icon-user" ></span></label><asp:TextBox id="login_id" class="input-xlarge" placeholder="Müşteri Numarası" runat="server" /><br/>
                 <br/>
                  <label class="btn btn-warning"><span class="icon-lock" ></span></label><asp:TextBox class="input-xlarge" id="login_password" placeholder="Şifre" TextMode="Password" runat="server" /><br/>
                   
                  
                   <asp:Button  id="Submit" class="btn btn-warning" Text="Giriş Yap" OnClick="Submit_Click" runat="server"/><br/><br/>
                   

                    <%--<div class="control-group" style="text-align:center;margin:0px" >            
				          <div class="controls">
                                 <label class="checkbox" style="margin:3px;padding-left:200px;padding-right:200px">
                                     <asp:CheckBox ID="beniHatırlaCheckBox" CssClass="" ForeColor="#ff3300" runat="server"/>
				                     <span class="label label-warning" style="margin:0px" >Beni Hatırla</span>
                                </label>   
				           </div>                
                   </div>--%>

                   <a class="label label-warning" style="text-decoration:none" onclick="OpenPopup()">Şifremi Unuttum</a><br />
                   <asp:Label class="badge badge-important"  ID="LabelBilgi" runat="server"></asp:Label><br /><hr />
                  
               </form>
                <asp:Label ID="LabelE_posta" CssClass="text-success" runat="server" ClientIDMode="Static"  />
              </div>
        </div>
    </div>
    </div>



</asp:Content>


