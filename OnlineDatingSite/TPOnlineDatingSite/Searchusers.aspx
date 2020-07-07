<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Searchusers.aspx.cs" Inherits="TPOnlineDatingSite.Searchusers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
       
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <script src="script/jquery.dd.js"></script>
    <script src="script/jquery.dd.min.js"></script>
   <%-- <link href="tpstyle.css" rel="stylesheet" />--%>
    
    <link href="CSS/Searchmain.css" rel="stylesheet" />
    <style>
 html, body { 
        background-color:dodgerblue;
          font-family: Arial, Helvetica, sans-serif;
  margin: 0;
  
    }
       .colorwhite{
            color:black;
            font-size:20px;
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
             color:white;
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
    <script>
        $(document).ready(function () {
            var username = $.cookie('profile');
            $.ajax({
                url: "http://localhost:50377/api/Search/Findbyname/" + username,
                    type: 'GET',
                success: function (name) {
                    document.getElementById("btnsubmit").innerText = name;
                }

            });
        });
    </script>

  <form id="form1" runat="server">
        <div class="homeuser">
    <nav class="navbar navbar-expand-md navbar-light bg-light">
        <a href="Homeuser.aspx" class="navbar-brand"><img src="img/logo.png" style="width:50px;height=50px;" /></a>
        <button type="button" class="navbar-toggler" data-toggle="collapse" data-target="#navbarCollapse">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarCollapse">
            <div class="navbar-nav">
               <a href="Searchusers.aspx" class="nav-item nav-link active">Search User</a>
            </div>
            <div class="navbar-nav ml-auto">
                 <a href="Registration.aspx" class="nav-item nav-link active">Sign Up</a>
                <a href="login.aspx" class="nav-item nav-link active">Login</a>
            </div>
        </div>
    </nav>
</div>
          <h1>Search People</h1>
            <div class="main">
            
    <div id="divnormal" runat="server" style="text-align:center;">
      
        <asp:Label ID="lblname" Text="Search By Name" runat="server" CssClass="colorwhite"></asp:Label><br />
           
        <asp:TextBox ID="txtname" runat="server"  placeholder="Justin" Width="343px"></asp:TextBox><br /><br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="btn btn-dark" OnClick="btnsubmit_Click" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" class="btn btn-danger" /><br /><br />
        <asp:Button ID="btnadvance" runat="server" Text="Advance Search" class="btn btn-warning" OnClick="btnadvance_Click" />
     
 </div>
    

    <div id="divadvance" runat="server" style="text-align:center;">
    <asp:Label ID="lblbyname" Text="Search By Age" runat="server" CssClass="colorwhite"></asp:Label><br />
    
            <asp:TextBox ID="txtage1" runat="server" placeholder="19"></asp:TextBox><br /> 
            <asp:TextBox ID="txtage2"  runat="server" placeholder="40"></asp:TextBox><br /><br />
        <asp:Button ID="btnsubmitname" runat="server" class="btn btn-dark" Text="Search" OnClick="btnsubmitname_Click" />
        
        <br />

    <asp:Label ID="lblbygender" Text="Search By Want Kids" runat="server" CssClass="colorwhite" style="text-align:center;"></asp:Label><br />
    <asp:TextBox ID="txtgender" runat="server" placeholder="Yes or No"></asp:TextBox><br /><br />
    <asp:Button ID="btnsubmitgender" class="btn btn-dark" runat="server" Text="Search"  OnClick="btnsubmitgender_Click" />
    <br />

     <asp:Label ID="lbloccupation" Text="Search By Occupation" runat="server" CssClass="colorwhite"></asp:Label><br />
    <asp:TextBox ID="txtoccupation" runat="server" placeholder="Doctor"></asp:TextBox><br /><br />
    <asp:Button ID="btnsubmitoccupation" class="btn btn-dark" runat="server" Text="Search" OnClick="btnsubmitoccupation_Click" />
    <br />

      <asp:Label ID="lblcommit" Text="Commitment Type" runat="server" CssClass="colorwhite" style="text-align:center;"></asp:Label><br />
        <asp:DropDownList ID="dropcommit" runat="server">
            <asp:ListItem>friends</asp:ListItem>
            <asp:ListItem>Relationship</asp:ListItem>
            <asp:ListItem>Marriage</asp:ListItem>
                       </asp:DropDownList>
        
        <br /><br />
       <asp:Button ID="btnsubmitcommiy" class="btn btn-dark" runat="server" Text="Search" OnClick="btnsubmitcommiy_Click" />
        </div>
        
            </div>

        <div id="divprofilecard" runat="server" style="text-align:center;">
    <div runat="server" id="details">
            </div>
      </div>
    </form>
</body>
</html>
