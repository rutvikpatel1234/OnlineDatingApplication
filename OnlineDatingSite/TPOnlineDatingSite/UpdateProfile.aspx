<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="TPOnlineDatingSite.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
         /*.colorwhite{
            color:black;
            font-size:20px;
        }*/
        .container1 {
  top: 100px;
  margin: 100px;
  background-color: #FFFFFF;
  border-radius: 50px;
  border: 3px solid #73AD21;
        }
       
    </style>
    <div class="container1">
         <div class="d-flex justify-content-center">
              
             <div id="divprofileupdate" runat="server">
              <h2 style="text-align:center">Update Profile</h2>
            
           
        <div class="form-group">
      <asp:Label ID="lblname" Text="Name" runat="server"></asp:Label><br />
        <asp:TextBox ID="txtname" class="form-control" runat="server" placeholder="Enter Name"></asp:TextBox>
        </div>
         <div class="form-group">
       <asp:Label ID="lblage" Text="Age" runat="server"></asp:Label><br />
        <asp:TextBox ID="txtage" class="form-control" runat="server"  placeholder="Enter Age"></asp:TextBox>
        </div>
                 <div class="form-group">
       <asp:Label ID="lblgender" Text="Gender" runat="server"></asp:Label><br />
        <asp:TextBox ID="txtgender" class="form-control" runat="server"  placeholder="Enter Gender"></asp:TextBox>
        </div>
        <div class="form-group">
     <asp:Label ID="lblocc" Text="Occupation" runat="server"></asp:Label><br />
        <asp:TextBox ID="txtocc" class="form-control" runat="server" placeholder="Occupation"></asp:TextBox>
        </div>
             <div class="form-group">    
           <asp:Label ID="lblcommit" Text="Commitment Type" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:DropDownList ID="dropcommit" runat="server">
            <asp:ListItem>Friends</asp:ListItem>
            <asp:ListItem>Relationship</asp:ListItem>
            <asp:ListItem>Marriage</asp:ListItem>
                       </asp:DropDownList>
                 </div>
     <div class="form-group">
     <asp:Label ID="lblphoto" Text="Uplode Photo" runat="server" CssClass="colorwhite"></asp:Label> 
    <asp:FileUpload class="caret" ID="FileUpload10" runat="server"/>
    <br />
    <asp:Label ID="lblerror" runat="server" Text="" CssClass="colorwhite"></asp:Label>
    <br />
    <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="btn btn-secondary" OnClick="btnsubmit_Click" />
      <asp:Button ID="btnback" runat="server" Text="View Profile" class="btn btn-secondary" OnClick="btnback_Click" />
            </div>
             </div>
       </div>
    </div>
</asp:Content>
