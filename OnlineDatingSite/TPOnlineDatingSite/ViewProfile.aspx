<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="TPOnlineDatingSite.ViewProfile" %>
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
         /*.card:hover {
             box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
         }*/
         
         h1 {
             
             text-shadow: 0 0 3px #28a745;
             text-align: center;
         }
         .modal-footer
         {
             border-top: 0px;
             display: inline-flex;
         }
        
         
    </style>
    <div id="divprofilecard" runat="server" style="text-align:center;">
    <div runat="server" id="details">
            </div>
      </div>
</asp:Content>
