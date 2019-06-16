﻿<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Mi aplicación ASP.NET</title>
    <!-- Favicons
        ================================================== -->
    <link rel="shortcut icon" href="Content/img/favicon.ico" type="image/x-icon">
    <link rel="apple-touch-icon" href="Content/img/apple-touch-icon.png">
    <link rel="apple-touch-icon" sizes="72x72" href="Content/img/apple-touch-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="114x114" href="Content/img/apple-touch-icon-114x114.png">

    <!-- Bootstrap -->
    <link rel="stylesheet" type="text/css" href="Content/css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="fonts/font-awesome/css/font-awesome.css">

    <!-- Stylesheet
        ================================================== -->
    <link rel="stylesheet" type="text/css" href="Content/css/style.css">
    <link rel="stylesheet" type="text/css" href="Content/css/nivo-lightbox/nivo-lightbox.css">
    <link rel="stylesheet" type="text/css" href="Content/css/nivo-lightbox/default.css">
    <link href="https://fonts.googleapis.com/css?family=Raleway:300,400,500,600,700" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Dancing+Script:400,700" rel="stylesheet">

    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">
    <form runat="server">
        <!-- Navigation
            ==========================================-->
        <nav id="menu" class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1"><span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
                    <a class="navbar-brand page-scroll" href="#page-top">Resto BarbaCock</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="#about" class="page-scroll">About</a></li>
                        <li><a href="#restaurant-menu" class="page-scroll">Menu</a></li>
                        <li><a href="#call-reservation" class="page-scroll">Contacto</a></li>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->
            </div>
        </nav>
        <!-- Header -->
        <header id="header">
            <div class="intro">
                <div class="overlay">
                    <div class="container">
                        <div class="row">
                            <div class="intro-text">
                                <h1>Resto BarbaCock</h1>
                                <p>Restaurant / Pub</p>
                                <a href="#about" class="btn btn-custom btn-lg page-scroll">Sobre Nosotros</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </header>
        <div class="container body-content">
            <!-- About Section -->
            <div id="about">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12 col-md-6 ">
                            <div class="about-img">
                                <img src="img/about.jpg" class="img-responsive" alt="">
                            </div>
                        </div>
                        <div class="col-xs-12 col-md-6">
                            <div class="about-text">
                                <h2>Our Restaurant</h2>
                                <hr>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis sed dapibus leo nec ornare diam. Sed commodo nibh ante facilisis bibendum dolor feugiat at. Duis sed dapibus leo nec ornare diam commodo nibh.</p>
                                <h3>Awarded Chefs</h3>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis sed dapibus leo nec ornare diam. Sed commodo nibh ante facilisis bibendum dolor feugiat at. Duis sed dapibus leo nec ornare.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            d
            <!-- Call Reservation Section -->
            <div id="call-reservation" class="text-center">
                <div class="container">
                    <h2>Want to make a reservation? Call <strong>1-887-654-3210</strong></h2>
                </div>
            </div>
            <!-- Contact Section -->
            <div id="contact" class="text-center">
                <div class="container">
                    <div class="section-title text-center">
                        <h2>Contact Form</h2>
                        <hr>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit duis sed.</p>
                    </div>
                    <div class="col-md-10 col-md-offset-1">
                        <form name="sentMessage" id="contactForm" novalidate>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="text" id="name" class="form-control" placeholder="Name" required="required">
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <input type="email" id="email" class="form-control" placeholder="Email" required="required">
                                        <p class="help-block text-danger"></p>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <textarea name="message" id="message" class="form-control" rows="4" placeholder="Message" required></textarea>
                                <p class="help-block text-danger"></p>
                            </div>
                            <div id="success"></div>
                            <button type="submit" class="btn btn-custom btn-lg">Send Message</button>
                        </form>
                    </div>
                </div>
            </div>

        </div>
        <div id="footer">
            <div class="container text-center">
                <div class="col-md-4">
                    <h3>Address</h3>
                    <div class="contact-item">
                        <p>4321 California St,</p>
                        <p>San Francisco, CA 12345</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <h3>Opening Hours</h3>
                    <div class="contact-item">
                        <p>Mon-Thurs: 10:00 AM - 11:00 PM</p>
                        <p>Fri-Sun: 11:00 AM - 02:00 AM</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <h3>Contact Info</h3>
                    <div class="contact-item">
                        <p>Phone: +1 123 456 1234</p>
                        <p>Email: info@company.com</p>
                    </div>
                </div>
            </div>
            <div class="container-fluid text-center copyrights">
                <div class="col-md-8 col-md-offset-2">
                    <div class="social">
                        <ul>
                            <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                            <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                            <li><a href="#"><i class="fa fa-google-plus"></i></a></li>
                        </ul>
                    </div>
                    <p>&copy; 2016 Touché. All rights reserved. Designed by <a href="http://www.templatewire.com" rel="nofollow">TemplateWire</a></p>
                </div>
            </div>
        </div>
        <div style="z-index: 3000;height: 100%;width: 100%;background-color: rgba(50,50,50,0.9);display: block;position: fixed;top:0px">
            <div style="background-color: white;height: 30vh;width: 60%;position: fixed;left: 50%;top: 50%;transform: translate(-50%,-50%); padding:1em">
              <h2>Pagina en construccion</h2>
              <h3>Para Acceder al sistema ingrese a la url <a href="Sistema.aspx" >Sitema.aspx</a></h3>
            </div>
        </div>
    </form>
    <script type="text/javascript" src="Scripts/jquery.1.11.1.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.js"></script>
    <script type="text/javascript" src="Scripts/SmoothScroll.js"></script>
    <script type="text/javascript" src="Scripts/nivo-lightbox.js"></script>
    <script type="text/javascript" src="Scripts/jquery.isotope.js"></script>
    <script type="text/javascript" src="Scripts/jqBootstrapValidation.js"></script>
    <script type="text/javascript" src="Scripts/contact_me.js"></script>
    <script type="text/javascript" src="Scripts/main.js"></script>

</body>
</html>
