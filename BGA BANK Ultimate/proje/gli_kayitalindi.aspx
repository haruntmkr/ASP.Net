<%@ Page Title="" Language="C#" MasterPageFile="~/Gli_IndexMasterPage.master" AutoEventWireup="true" CodeFile="gli_kayitalindi.aspx.cs" Inherits="gli_kayitalindi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta http-equiv="refresh" content="10;URL=../gli_log_in.aspx"/>  <!--10 sn sonra index.php ye yönlendirilecek-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row" style="text-align:center">
        <div class="span10">
            <div class="well well-small">
                <h4>Tebrikler! Başvurunuz Alındı..</h4>
                <ul class="nav nav-list">
                    <div class="alert alert-success">
                    <p> Başvurunuz alındı. Müşteri numarası ve şifre bilgileriniz eposta yoluyla iletilecektir.. <p>
                    </div>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>

