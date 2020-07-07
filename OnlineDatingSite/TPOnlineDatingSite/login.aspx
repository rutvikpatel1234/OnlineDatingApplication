<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TPOnlineDatingSite.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <link href="CSS/main.css" rel="stylesheet" />
   <style>
   body, html {
  height: 100%;
  font-family: Arial, Helvetica, sans-serif;
  * {
  box-sizing: border-box;
}
}
       .bg-img { /* The image used */
           background-image: url("webphoto/background.jpg");
           min-height: 100%; /* Center and scale the image nicely */
           background-position: center;
           background-repeat: no-repeat;
           background-size: cover;
           position: relative;
       }
         .container1 {
  position: absolute;
  left: 600px;
  top: 100px;
  margin: 20px;
  width: 375px;
  padding: 16px;
  background-color: #FFFFFF;
  border: 1px solid #232323;
  border-radius: 25px;
}
         footer {
            width: 100%;
            padding: 1.5em;
            background-color: #2c2c2c;
            color: white;
            /*margin-top: 5.5em;*/
        }
    </style>
</head>
<body>
     <div class="bg-img">

            <form id="form1"  runat="server">
                         <div class="container">
                 <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
            <h5 class="card-title text-center">Login</h5>
        <div class="form-label-group">
            
               <asp:TextBox ID="txtusername" runat="server" CssClass="form-control"></asp:TextBox>
            <label for="username">Username</label>
              </div>
       
        <div class="form-label-group">
          
             <asp:TextBox ID="txtpassword" type="password" runat="server" CssClass="form-control"></asp:TextBox>
              <label for="password">Password</label>
             </div>
                 <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
           <div class="form-group">
        
         
<asp:Button ID="btnlogin" class="btn-lg btn-primary btn-block" runat="server" Text="LogIn" OnClick="btnlogin_Click" OnClientClick="btnlogin_Click"/><br />
               <asp:RadioButton ID="rdoremember" GroupName="fastlogin" Text="Remember Me" runat="server" /><br />
               <asp:RadioButton ID="rdoclearcookie" GroupName="fastlogin" Text="Clear Cookie" runat="server" />
               <br /><br />
            <asp:HyperLink ID="ForgetPasswordHyperLink" NavigateUrl="ForgotPassword.aspx" Text="Forgot your password?" runat="server"></asp:HyperLink>
            <br />
           
            <asp:HyperLink ID="RegisterHyperLink" NavigateUrl="Registration.aspx" Text="Create an account" runat="server"></asp:HyperLink>
            <br />
           
               </div>
              </div>
            </div>
          </div>
                     </div> </div>
    </form>
             
         </div>
   
    
   
</body>
</html>