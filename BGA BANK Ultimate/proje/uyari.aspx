<%@ Page Title="" Language="C#" MasterPageFile="~/IndexMasterPage.master" AutoEventWireup="true" CodeFile="uyari.aspx.cs" Inherits="uyari" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<meta http-equiv="refresh" content="3;URL=../g_log_in.aspx"/>  <!--3 sn sonra g_log_in.aspx ye yönlendirilecek-->


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="text-align:center">
        <div class="span10">
            <div class="well well-small">
                <h4>Yetkisiz Erişim!</h4>
                <ul class="nav nav-list">
                    <div class="alert alert-error">
                    <p> Yetkisiz erişim. Lütfen önce giriş yapınız... <p>
                    </div>
                </ul>
            </div>
        </div>
    </div>

</asp:Content>

