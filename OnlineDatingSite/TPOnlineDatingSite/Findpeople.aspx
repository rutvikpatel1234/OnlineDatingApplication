<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Findpeople.aspx.cs" Inherits="TPOnlineDatingSite.Findpeople" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .colorwhite{
            color:white;
            font-size:20px;
        }
      
         body {
  font-family: Arial, Helvetica, sans-serif;
  margin: 0;
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
            border: 2px solid #000000;
            left: 50px;
            
        }
         .card:hover {
             box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
         }
         
         h1 {
             color:white;
             text-shadow: 0 0 3px #28a745;
             text-align: center;
         }
         .modal-footer
         {
             border-top: 0px;
             display: inline-flex;
         }
  
    </style>
    <h1>Search People</h1>
     <div class="main">
            
    <div id="divnormal" runat="server" style="text-align:center;">
      
        <asp:Label ID="lblname" Text="Search By Name" runat="server" CssClass="colorwhite"></asp:Label><br />
           
        <asp:TextBox ID="txtname" runat="server"  placeholder="Justin" Width="343px"></asp:TextBox><br /><br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="btn btn-primary" OnClick="btnsubmit_Click" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" class="btn btn-danger" /><br /><br />
        <asp:Button ID="btnadvance" runat="server" Text="Advance Search" class="btn btn-warning" OnClick="btnadvance_Click" />
     
 </div>
    

    <div id="divadvance" runat="server" style="text-align:center;">
    <asp:Label ID="lblbyname" Text="Search By Age" runat="server" CssClass="colorwhite"></asp:Label><br />
    
            <asp:TextBox ID="txtage1" runat="server" placeholder="19"></asp:TextBox><br /> 
            <asp:TextBox ID="txtage2"  runat="server" placeholder="40"></asp:TextBox><br /><br />
        <asp:Button ID="btnsubmitname" runat="server" class="btn btn-primary" Text="Search" OnClick="btnsubmitname_Click" />
        
        <br />

    <asp:Label ID="lblbygender" Text="Search By Want Kids" runat="server" CssClass="colorwhite" style="text-align:center;"></asp:Label><br />
    <asp:TextBox ID="txtgender" runat="server" placeholder="Yes or No"></asp:TextBox><br /><br />
    <asp:Button ID="btnsubmitgender" class="btn btn-primary" runat="server" Text="Search"  OnClick="btnsubmitgender_Click" />
    <br />

     <asp:Label ID="lbloccupation" Text="Search By Occupation" runat="server" CssClass="colorwhite"></asp:Label><br />
    <asp:TextBox ID="txtoccupation" runat="server" placeholder="Doctor"></asp:TextBox><br /><br />
    <asp:Button ID="btnsubmitoccupation" class="btn btn-primary" runat="server" Text="Search" OnClick="btnsubmitoccupation_Click" />
    <br />

      <asp:Label ID="lblcommit" Text="Commitment Type" runat="server" CssClass="colorwhite" style="text-align:center;"></asp:Label><br />
        <asp:DropDownList ID="dropcommit" runat="server">
            <asp:ListItem>friends</asp:ListItem>
            <asp:ListItem>Relationship</asp:ListItem>
            <asp:ListItem>Marriage</asp:ListItem>
                       </asp:DropDownList>
        
        <br /><br />
       <asp:Button ID="btnsubmitcommiy" class="btn btn-primary" runat="server" Text="Search" OnClick="btnsubmitcommiy_Click" />
        </div>
        
            </div>
      <div id="divprofilecard" runat="server" style="text-align:center;">
    <div runat="server" id="details">
            </div>
      </div>
</asp:Content>
