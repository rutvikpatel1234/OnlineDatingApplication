﻿<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ProfileInfo.aspx.cs" Inherits="TPOnlineDatingSite.ProfileInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .colorwhite{
            color: white;
            font-size:20px;
        }
        .colorwhite1{
           color: white;
            font-size:20px;
            font:bold 10px;
        }
       .container1 {
  top: 100px;
  margin: 100px;
  background-color: #FFFFFF;
  border-radius: 50px;
  border: 3px solid #73AD21;
}
    </style>

   <%-- <div class="container1">--%>
  <div class="d-flex justify-content-center">
    

      <div id="divprofileinfo" runat="server" style="text-align:center;">
         <h2 class="text-white" style="text-align:center" >View Profile</h2><br />


          <table class="table table-dark">
  <tbody>
    <tr>
      <th scope="row"><asp:Label ID="lblprofile" Text="Profile Name:" runat="server" CssClass="colorwhite"></asp:Label></th>
      <td> <asp:Label ID="lblname1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
        <tbody>
    <tr>
        <th scope="row"><asp:Label ID="lblheight" Text="Height:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td> <asp:Label ID="lblheight1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lblweight" Text="Weight:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td> <asp:Label ID="lblweight1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lblinterests" Text="Interests:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td><asp:Label ID="lblinterests1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lbllike" Text="Likes:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td> <asp:Label ID="lbllike1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lbldis" Text="Dislikes:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td><asp:Label ID="lbldis1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lblres" Text="Favorite Restaurants:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td><asp:Label ID="lblres1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lblbook" Text="Favorite Books:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td> <asp:Label ID="lblbook1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lblmovies" Text="Favorite Movies:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td><asp:Label ID="lblmovies1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lbladdress" Text="Home Address:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td> <asp:Label ID="lbladdress1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"> <asp:Label ID="lblcity" Text="City:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td><asp:Label ID="lblcity1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lblstate" Text="State:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td> <asp:Label ID="lblstate1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
               <tbody>
    <tr>
         <th scope="row"><asp:Label ID="lblzip" Text="Zip:" runat="server" CssClass="colorwhite"></asp:Label></th>
        <td><asp:Label ID="lblzip1" runat="server" Text="Label" CssClass="colorwhite1"></asp:Label></td>
    </tr>
      </tbody>
  </table>
    
         <%-- <asp:Button ID="btnback" runat="server" Text="Return To Profile" class="btn btn-primary btn-lg btn-block" OnClick="btnback_Click" OnClientClick="btnback_Click" />--%>
          
          </div>
  </div>    
      
</asp:Content>