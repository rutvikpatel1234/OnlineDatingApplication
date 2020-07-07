<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paymentpage.aspx.cs" Inherits="TPOnlineDatingSite.Paymentpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <link href="tpstyle.css" rel="stylesheet" type="text/css" />
     <style>
             .colorwhite{
            color:white;
            font-size:20px;
        }
             body{
                 text-align:center;
             }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divpayment" runat="server">
              <h2 style="text-align:center; color:white;">Payment</h2>
            
            <asp:Label ID="lblSub" Text="Subscription" runat="server" CssClass="colorwhite"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlsub" runat="server">
            <asp:ListItem>Please Select</asp:ListItem>
                <asp:ListItem Value="200">Year $200</asp:ListItem>
            </asp:DropDownList>
            <br />

            <asp:Label ID="lblname" Text="Card Holder Name" runat="server" CssClass ="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtname" runat="server" placeholder="Joye"></asp:TextBox>
        <br />
            <asp:Label ID="lblcardtype" Text="Card Type" runat="server" CssClass="colorwhite"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCardType" runat="server">
            <asp:ListItem>American Express</asp:ListItem>
            <asp:ListItem>Discover</asp:ListItem>
            <asp:ListItem>MasterCard</asp:ListItem>
            <asp:ListItem>Visa</asp:ListItem>
            </asp:DropDownList>
            <br />
             <asp:Label ID="lblcardnumber" Text="Card Number" runat="server" CssClass="colorwhite"></asp:Label><br />
            <asp:TextBox ID="txtcardnumber" runat="server" placeholder="0000000000" MaxLength="10"></asp:TextBox>
        <br />
             <asp:Label ID="lblccv" Text="CCV Number" runat="server" CssClass="colorwhite"></asp:Label><br />
            <asp:TextBox ID="txtcvv" runat="server" placeholder="000" MaxLength="3"></asp:TextBox>
        <br />
             <asp:Label ID="lblexp" Text="Exp Date" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:DropDownList ID="monthl" runat="server" AutoPostBack="true">
           <asp:ListItem Enabled="true" Text="Month" Value="month"></asp:ListItem>
           <asp:ListItem Text="01" Value="01"></asp:ListItem>
            <asp:ListItem Text="02" Value="02"></asp:ListItem>
            <asp:ListItem Text="03" Value="03"></asp:ListItem>
             <asp:ListItem Text="04" Value="04"></asp:ListItem>
            <asp:ListItem Text="05" Value="05"></asp:ListItem>
            <asp:ListItem Text="06" Value="06"></asp:ListItem>
             <asp:ListItem Text="07" Value="07"></asp:ListItem>
            <asp:ListItem Text="08" Value="08"></asp:ListItem>
            <asp:ListItem Text="09" Value="09"></asp:ListItem>
              <asp:ListItem Text="10" Value="10"></asp:ListItem>
            <asp:ListItem Text="11" Value="11"></asp:ListItem>
              <asp:ListItem Text="12" Value="12"></asp:ListItem>
       </asp:DropDownList>
       <asp:DropDownList ID="yearl" runat="server" AutoPostBack="true">
           <asp:ListItem Enabled="true" Text="Year" Value="year"></asp:ListItem>
            <asp:ListItem Text="2021" Value="2021"></asp:ListItem>
            <asp:ListItem Text="2023" Value="2023"></asp:ListItem>
             <asp:ListItem Text="2024" Value="2024"></asp:ListItem>
            <asp:ListItem Text="2025" Value="2025"></asp:ListItem>
            <asp:ListItem Text="2026" Value="2026"></asp:ListItem>
             <asp:ListItem Text="2027" Value="2027"></asp:ListItem>
            <asp:ListItem Text="2028" Value="2028"></asp:ListItem>
            <asp:ListItem Text="2029" Value="2029"></asp:ListItem>
              <asp:ListItem Text="2030" Value="2030"></asp:ListItem>
      </asp:DropDownList>
        <br />
            <br />
                  <asp:Button ID="btnsubmit" runat="server" Text="Complete Purchase" class="btn btn-primary" OnClick="btnsubmit_Click" OnClientClick="btnsubmit_Click" />

        </div>
    </form>
</body>
</html>
