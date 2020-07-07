<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="MessageConversation.aspx.cs" Inherits="TPOnlineDatingSite.MessageConversation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
           .colorwhite{
            color:white;
            font-size:20px;
        }
    </style>
     <div class="row">
            <div class="col-md-4"></div>
            <div id="messageContainer" class="col-md-4">
                <asp:Label ID="lblSendMessage" runat="server" Font-Size="Large" Text="Type a message below!" CssClass="colorwhite"></asp:Label>
                <br />
                <asp:Label ID="lblMessage" runat="server" Text="Message:" CssClass="colorwhite"></asp:Label>
                <br />
                <asp:TextBox ID="txtMessage" CssClass="txtMessage" ForeColor="Black" TextMode="MultiLine" Rows="3" runat="server" Height="128px" Width="516px"></asp:TextBox>
                <div class="row">
                    <div class="col-md-4">
                        <asp:Button ID="btnSend"  CssClass="btn btn-primary" runat="server" Text="Send" OnClick="btnSend_Click" />
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnGetMessages"  CssClass="btn btn-primary" runat="server" Text="Get Messages" OnClick="btnGetMessages_Click" />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
