<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="HomeMember.aspx.cs" Inherits="TPOnlineDatingSite.HomeMember" %>
<%@ Register Src="~/Home.ascx" TagPrefix="home1" TagName="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <home1:Home runat="server" ID="Home" />
    

      
</asp:Content>
