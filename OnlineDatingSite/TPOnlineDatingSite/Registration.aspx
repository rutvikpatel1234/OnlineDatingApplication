<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TPOnlineDatingSite.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
        <link href="tpstyle.css" rel="stylesheet" />
    <style>
        .colorwhite{
            color:white;
            font-size:20px;
        }
        body{
            color:white;

        }
        div{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="text-align:center;color:white;">Register</h1>
   <div id="divuserinfo" runat="server">
        <div class="container">
        <div class="row">
            <div class="form-group col-sm-6">
     <asp:Label ID="lbluser" Text="Username" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtuser" class="form-control input-sm" runat="server" placeholder="justin"></asp:TextBox>
                </div>
       <div class="form-group col-sm-6">
        <asp:Label ID="lblemail" Text="Email" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtemail" class="form-control input-sm" runat="server" placeholder="justin@yahoo.com"></asp:TextBox>
       </div>
              <div class="form-group col-sm-6">
        <asp:Label ID="lblpassword" Text="Password" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtpassword" class="form-control input-sm" runat="server" placeholder="Password"></asp:TextBox>
        </div>
              <div class="form-group col-sm-6">
        <asp:Label ID="lblprofile" Text="Profile Name" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtprofilename" class="form-control input-sm" runat="server" placeholder="Justin Bieber"></asp:TextBox>
    </div>
              <div class="form-group col-sm-6">
        <asp:Label ID="lbladdress" Text="Home Address" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtaddress" class="form-control input-sm" runat="server" placeholder="123 Somewere"></asp:TextBox>
        </div>
              <div class="form-group col-sm-6">
        <asp:Label ID="lblcity" Text="City" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtcity" class="form-control input-sm" runat="server" placeholder="Philadelphia"></asp:TextBox>
        </div>
              <div class="form-group col-sm-6">
        <asp:Label ID="lblstate" Text="State" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtstate" class="form-control input-sm" runat="server" placeholder="PA"></asp:TextBox>
        </div>
              <div class="form-group col-sm-6">
        <asp:Label ID="lblzip" Text="Zip" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtzip" class="form-control input-sm" runat="server" placeholder="12904"></asp:TextBox>
        </div>
          <div class="form-group col-sm-6">
        <asp:Label ID="lblphone" Text="phone" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtphone" class="form-control input-sm" runat="server" placeholder="1234567890"></asp:TextBox>
              </div>
        <br /><br />
            </div>
      <asp:Button ID="btnsubmit" runat="server" Text="Continue" class="btn btn-primary" OnClick="btnsubmit_Click" />
            </div>
    </div>
    <div id="divquestion" runat="server">

         <asp:Label ID="lblq1" Text="Question 1" runat="server" CssClass="colorwhite"></asp:Label><br />
         <asp:DropDownList ID="dropq1" runat="server">
            <asp:ListItem>Select Questions</asp:ListItem>
            <asp:ListItem>What was your childhood nickname?</asp:ListItem>
            <asp:ListItem>What school did you attend for sixth grade?</asp:ListItem>
            <asp:ListItem>In what city or town was your first job?</asp:ListItem>
        </asp:DropDownList>
      <%--  <asp:TextBox ID="txtq1" runat="server"></asp:TextBox>--%>
        <br />
        <asp:Label ID="lblans1" Text="Answer 1" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtans1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblq2" Text="Question 2" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:DropDownList ID="dropq2" runat="server">
             <asp:ListItem>Select Questions</asp:ListItem>
            <asp:ListItem>Who was your childhood hero?</asp:ListItem>
            <asp:ListItem>Where did you vacation last year?</asp:ListItem>
            <asp:ListItem>What was your high school mascot?</asp:ListItem>
        </asp:DropDownList>
       <%-- <asp:TextBox ID="txtq2" runat="server"></asp:TextBox>--%>
        <br />
        <asp:Label ID="lblqns2" Text="Answer 2" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtans2" runat="server"></asp:TextBox>
        <br />
        
            <asp:Label ID="lblq3" Text="Question 3" runat="server" CssClass="colorwhite"></asp:Label><br />
         <asp:DropDownList ID="dropq3" runat="server">
             <asp:ListItem>Select Questions</asp:ListItem>
            <asp:ListItem>What is the last name of the teacher who gave you your first failing grade?</asp:ListItem>
            <asp:ListItem>Where were you when you had your first kiss?</asp:ListItem>
            <asp:ListItem>What was the make and model of your first car?</asp:ListItem>
        </asp:DropDownList>
        <%--<asp:TextBox ID="txtq3" runat="server"></asp:TextBox>--%>
        <br />
        <asp:Label ID="lblans3" Text="Answer 3" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtans3" runat="server"></asp:TextBox>
        <br />
        <br />
               <asp:Button ID="btncomplete" runat="server" Text="Submit" class="btn btn-primary" OnClick="btncomplete_Click1" OnClientClick="btncomplete_Click"/>

    </div>

    </form>
</body>
</html>
