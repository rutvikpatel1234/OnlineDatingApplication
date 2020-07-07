<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homeuser.aspx.cs" Inherits="TPOnlineDatingSite.Homeuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <script src="script/jquery.dd.js"></script>
    <script src="script/jquery.dd.min.js"></script>
  
    
   <style>
        body {
  font-family: Arial, Helvetica, sans-serif;
  margin: 0;
}
        .nav-item {
            color: black;
            font-size: 1.7em;
        }
         .imgheight {
            height: 225px;   
            bottom: 0;
        }
         .card
         {
                bottom: 0;
         }
         

        .details {
            top:5px;
            display: inline-block;
            margin: auto auto;
            vertical-align: top;
            margin: 5% 10px 40px 0;
            border: 2px solid #212529;
            left: 50px;
            
            
        }
         .card:hover {
             box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
         }
         
         h1 {
             
             text-shadow: 0 0 3px #28a745;
             text-align: center;
          }

         .about-section {
            padding: 50px;
            text-align: center;
            font-size: 50px;
            color: white;
}
  
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="homeuser">
    <nav class="navbar navbar-expand-md navbar-light bg-light">
        <a href="Homeuser.aspx" class="navbar-brand"><img src="img/logo.png" style="width:50px;height=50px;" /></a>
        <button type="button" class="navbar-toggler" data-toggle="collapse" data-target="#navbarCollapse">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarCollapse">
            <div class="navbar-nav">
         
            </div>
            <div class="navbar-nav ml-auto">
                      <a href="Searchusers.aspx" class="nav-item nav-link active">Search</a>
                 <a href="Registration.aspx" class="nav-item nav-link active">Sign Up</a>
                <a href="login.aspx" class="nav-item nav-link active">Login</a>
            </div>
        </div>
    </nav>
</div>

       
         <div class="container">
        <div class="bd-example">
  <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
    <ol class="carousel-indicators">
      <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
      <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
      <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
      <div class="carousel-item active">
        <img src="webphoto/home4.jpg" class="d-block w-100" alt="..."/>
        <div class="carousel-caption d-none d-md-block">
            <div class="about-section">
          <h5>Online Dating Web</h5>
          <p>Find singles looking to date.</p>
                </div>
        </div>
      </div>
      <div class="carousel-item">
        <img src="webphoto/home5.jpg" class="d-block w-100" alt="..."/>
        <div class="carousel-caption d-none d-md-block">
            <div class="about-section">
          <h5>Match</h5>
          <p>Best for Serious Relationships.</p>
                </div>
        </div>
      </div>
      <div class="carousel-item">
        <img src="webphoto/home12.jpg" class="d-block w-100" alt="..."/>
        <div class="carousel-caption d-none d-md-block">
            <div class="about-section">
          <h5>Online Dating</h5>
          <p>Best for Mature Dating.</p>
                </div>
        </div>
      </div>
    </div>
    <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
      <span class="carousel-control-prev-icon" aria-hidden="true"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
      <span class="carousel-control-next-icon" aria-hidden="true"></span>
      <span class="sr-only">Next</span>
    </a>
  </div>
</div>
     

        <div id="divprofilecard" runat="server" style="text-align:center;">
    <div runat="server" id="details">
            </div>
      </div>
         </div>   
    </form>
  

</body>
</html>


