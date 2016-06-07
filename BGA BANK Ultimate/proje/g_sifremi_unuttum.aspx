<%@ Page Title="Şifremi Unuttum" ValidateRequest="False" Language="C#" AutoEventWireup="true" CodeFile="g_sifremi_unuttum.aspx.cs" Inherits="g_sifremi_unuttum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta charset="utf-8"/>
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
    <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
	<link id="callCss" rel="stylesheet" href="themes/current/bootstrap.min.css" type="text/css" media="screen"/>
	<link href="themes/css/bootstrap-responsive.min.css" rel="stylesheet" type="text/css"/>
	<link href="themes/css/font-awesome.css" rel="stylesheet" type="text/css"/>
	<link href="themes/css/base.css" rel="stylesheet" type="text/css"/>
	<style type="text/css" id="enject"></style>
    <script>document.cookie="PCUSESSIONID=stealme"

    </script>   
    
</head>
<body>
<section id="headerSection">
	<div class="container">
		<div class="navbar">
			<div class="container">
				<button type="button" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
				<span class="icon-bar"></span>
				<span class="icon-bar"></span>
				<span class="icon-bar"></span>
				</button>
				<h1><a class="brand" href="g_index.aspx"> BGA <small>  BANK</small></a></h1>
				<div class="nav-collapse collapse">
					<ul class="nav pull-right">

					</ul>
				</div>
			</div>
		</div>
	</div>
</section>
<!--Header Ends================================================ -->
<!-- Page banner -->
<section id="bannerSection" style="background:url(themes/images/banner/blog.png) no-repeat center center #000;">
	<div class="container" >	
		<h1 id="pageTitle"> 
		<span class="pull-right toolTipgroup">
			<a href="" data-placement="top" data-original-title=""><img style="width:45px" src="themes/images/facebook.png" alt="facebook" title="facebook"></a>
			<a href="" data-placement="top" data-original-title=""><img style="width:45px" src="themes/images/twitter.png" alt="twitter" title="twitter"></a>
			<a href="" data-placement="top" data-original-title=""><img style="width:45px" src="themes/images/youtube.png" alt="youtube" title="youtube"></a>
		</span>
		</h1>
	</div>
</section> 
<!-- Page banner end -->
<section id="bodySection">
		<div class="container">					
			<div class="row">	
			 <!--ContentPlaceHolder-->
                    <form id="form1" runat="server" class="control-group">
                        <div class="">
                            <h4 id="bilgi" class="label btn-warning">Lütfen sistemimize kayıtlı e-posta adresinizi ve müşteri numaranızı giriniz</h4> <br />
                            <asp:Label CssClass="control-label" runat="server" ClientIDMode="Static">E-posta : </asp:Label>
                            <asp:TextBox ID="btnE_mail" CssClass="controls" runat="server" ClientIDMode="Static" /><br />
                            <asp:Label CssClass="control-label" runat="server" ClientIDMode="Static">Müşteri No : </asp:Label>
                            <asp:TextBox ID="btnMusteriNo" CssClass="controls" runat="server" ClientIDMode="Static" /><br />
                            <asp:Button ID="btnbilgiGönder" runat="server" CssClass="btn btn-primary" Text="Gönder" OnClick="btnbilgiGönder_Click" />
                        </div>
                    </form>
			<!--ContentPlaceHolder-->
             
			</div>
		</div>	
</section>
 <!-- Footer
  ================================================== -->
<section id="footerSection">
<div class="container"><!-- container -->
    <footer class="footer well well-small">
	<div class="row-fluid">
	    
    </div>
	<p style="padding:18px 0 44px">&copy; 2016, BGA BANK </p>
	</footer>
    </div><!-- /container -->
</section>

<!-- Javascript
    ================================================== -->
<!-- Placed at the end of the document so the pages load faster -->
    <script type="text/javascript" src="http://platform.twitter.com/widgets.js"></script>
	<script src="themes/js/jquery-1.8.3.min.js"></script>
	<script src="themes/js/bootstrap.min.js"></script>
	<script src="themes/js/bootstrap-tooltip.js"></script>
    <script src="themes/js/bootstrap-popover.js"></script>
	<script src="themes/js/business_ltd_1.0.js"></script>
</body>
</html>








