<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="UpdatePayment.aspx.cs" Inherits="TPOnlineDatingSite.UpdatePayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                .colorwhite1{
            color:blue;
            font-size:20px;
            font:bold 10px;
        }
    </style>
    <h1 style="text-align:center; color:white;">Update Payment Info</h1>

    <div id="divcardinfo" runat="server">
         <%--<asp:Label ID="lblcardholder" Text="Card Holder Name" runat="server" CssClass="colorwhite"></asp:Label><br />
          <asp:Label ID="lblname1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label>
        <br />
        <asp:Label ID="lbltype" Text="Card Type" runat="server" CssClass="colorwhite"></asp:Label><br />
          <asp:Label ID="lbltype1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label>
                <br />
        <asp:Label ID="lblnumber" Text="Card Number" runat="server" CssClass="colorwhite"></asp:Label><br />
          <asp:Label ID="lblnumber1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label>
          <br />
        <asp:Label ID="lblcardccv" Text="Card CCV" runat="server" CssClass="colorwhite"></asp:Label><br />
          <asp:Label ID="lblccv1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label>
        <br />
        <asp:Label ID="lblcardexp" Text="Exp Date" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:Label ID="lblmonth" Text="Month" runat="server" CssClass="colorwhite"></asp:Label>
          <asp:Label ID="Label2" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label>
        
        <asp:Label ID="lblcardyear" Text="Year" runat="server" CssClass="colorwhite"></asp:Label>
          <asp:Label ID="lblyear" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label><br />--%>
        <asp:GridView ID="gvcardinfo" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
         </asp:GridView>
        <asp:Button ID="btnupdate" runat="server" class="btn btn-primary" Text="Update Card" OnClick="btnupdate_Click" />
    </div>


    <div id="divupdatecard" runat="server">

        <div id="divpayment" runat="server">
           
            
         <%--   <asp:Label ID="lblSub" Text="Subscription" runat="server" CssClass="colorwhite"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlsub" runat="server">
            <asp:ListItem>Please Select</asp:ListItem>
                <asp:ListItem>Year $200</asp:ListItem>
            </asp:DropDownList>
            <br />--%>

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
        <asp:DropDownList ID="monthl" runat="server" AutoPostBack="false">
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
       <asp:DropDownList ID="yearl" runat="server" AutoPostBack="false">
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
                  <asp:Button ID="btnsubmit" runat="server" Text="Complete Purchase" class="btn btn-primary" OnClick="btnsubmit_Click" />

        </div>
    
        </div>

</asp:Content>
