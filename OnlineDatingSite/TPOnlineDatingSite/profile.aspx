<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="TPOnlineDatingSite.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <style>
        .colorwhite{
            color:white;
            font-size:20px;
        }
         .alertmessagge {
            padding: 10px;
            width: 100%;
            margin: 0 auto;
            text-align: center;
        }

       
         
    </style>
   

    <div id="diveditprofile" runat="server" style="text-align:center;">
        <asp:Label ID="lblocc" Text="Occupation" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtocc" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="lblgender" Text="Gender" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtgender" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblage" Text="Age" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblheight" Text="Height" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtheight" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblweight" Text="Weight" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtweight" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblinterests" Text="Interests" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtinterests" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbllike" Text="Likes" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtlike" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbldis" Text="Dislikes" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtdis" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblres" Text="Favorite Restaurants" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtres" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblbook" Text="Favorite Books" runat="server" CssClass="colorwhite"></asp:Label><br />
       <asp:TextBox ID="txtbook" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblmovies" Text="Favorite Movies" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtmovies" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblpoem" Text="Favorite Poems/Quotes" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtpoem" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblcommit" Text="Commitment Type" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:DropDownList ID="dropcommit" runat="server">
            <asp:ListItem>Friends</asp:ListItem>
            <asp:ListItem>Relationship</asp:ListItem>
            <asp:ListItem>Marriage</asp:ListItem>
                       </asp:DropDownList>
        <br />
        <asp:Label ID="lblhave" Text="Have Kids" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txthave" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblwants" Text="Wants Kids" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtwants" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblreli" Text="Religinon" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:DropDownList ID="dropreli" runat="server">
            <asp:ListItem>Hinduism</asp:ListItem>
            <asp:ListItem>Buddhism</asp:ListItem>
            <asp:ListItem>Christianity</asp:ListItem>
                       </asp:DropDownList>
        <br />
        <asp:Label ID="lbldesc" Text="Description" runat="server" CssClass="colorwhite"></asp:Label><br />
        <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblphoto" Text="Uplode Photo" runat="server" CssClass="colorwhite"></asp:Label> <br>
           
            <asp:FileUpload class="caret" ID="FileUpload1" runat="server"/>
             <br />
        <br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="btn btn-primary" OnClick="btnsubmit_Click" />
    

        </div>


</asp:Content>
