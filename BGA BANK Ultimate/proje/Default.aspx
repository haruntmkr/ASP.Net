<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest="False" %>

<!DOCTYPE html >

 <html xmlns="http://www.w3.org/1999/xhtml" xml:lang="tr" lang="tr">
<head>

    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Bilgi Güvenliği Akademisi-Güvensiz Bankacılık Uygulaması</title>
    
    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>

    <!-- Custom CSS -->
    <link href="css/grayscale.css" rel="stylesheet"/>
    <link href="css/styleLogo.css" rel="stylesheet" />
    <link rel="shortcut icon" href="img/logo.png"/>

    <!-- Custom Fonts -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>
    <link href="http://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic" rel="stylesheet" type="text/css"/>
    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css"/>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>
<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">

    <!-- Navigation -->
    <nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-main-collapse">
                    <i class="fa fa-bars"></i>
                </button>
                <a class="navbar-brand page-scroll" href="#page-top">
                    <i class="fa fa-play-circle"></i>  <span class="light">BGA</span> Bank
                </a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
                <ul class="nav navbar-nav">
                    <!-- Hidden li included to remove active class from about link when scrolled up past about section -->
                    <li class="hidden">
                        <a href="#page-top"></a>
                    </li>
                
                    <li>
                        <a class="page-scroll" href="http://bga.com.tr/">BGA</a>
                    </li>
                   
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>

    <!-- Intro Header -->
    <header class="intro">
        <div class="intro-body">
            <div class="container">
               
                <div class="row">
                   
                    
                    <div class="col-md-8 col-md-offset-2">
                        <form runat="server">
                                  <label class="radio inline">
                                  <h1 class="brand-heading"> 
                                       
                   BGA BANK</h1>
                                 
                                    </label>

                        </form>
                      

                        




                        <p class="intro-text">Türkiye'nin istismar edilebilir internet bankacılığı<br/></p>
                        <a href="#giris" class="btn btn-circle page-scroll">
                            <i class="fa fa-angle-double-down animated"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- About Section -->
   
  
    <!-- Contact Section -->
    <section id="giris" class="container content-section text-center">
        <div class="row">
            <div class="col-lg-10 col-lg-offset-1">
                <h2>BGA Bank</h2>
                <p>Bilgi Güvenliği Akademisi BGA Bank Güvensiz Internet Bankacılığı Uygulamasına Hoşgeldiniz...</br> Uygulama bünyesindeki  Güvensiz seçeneği zafiyetlerin hiç bir filtreleme uygulanmadan yazılım içerisinde konulmuş halidir. WAF seçeneğinde filtrelenmiş zafiyetler mevcuttur. Güvenli seçeneğinde uygulamanın istismar edilebilir kısımları  giderilerek yayınlanmıştır. Keyifli bir deneyim olması dileğiyle... </p>
                
                <ul class="list-inline banner-social-buttons">
                    <li>
                        <a href="g_index.aspx" class="btn btn-default btn-lg"></i> <span class="network-name">Güvensiz</span></a>
                    </li>
                    <li>
                        <a href="http://www.waf.ultimate.com" class="btn btn-default btn-lg"></i> <span class="network-name">WAF</span></a>
                    </li>
                    <li>
                        <a href="gli_index.aspx" class="btn btn-default btn-lg"></i> <span class="network-name">Güvenli</span></a>
                    </li>
                </ul>
            </div>
        </div>
    </section>

    <!-- Map Section -->
   <!-- <div id="map"></div>-->

    <!-- Footer -->
    <footer>
        <div class="container text-center">
            <p>Copyright &copy; Bilgi Güvenliği Akademisi 2016</p>
        </div>
    </footer>

    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="js/jquery.easing.min.js"></script>

    <!-- Google Maps API Key - Use your own API key to enable the map feature. More information on the Google Maps API can be found at https://developers.google.com/maps/ -->
    
    <!-- Custom Theme JavaScript -->
    <script src="js/grayscale.js"></script>

</body>

</html>