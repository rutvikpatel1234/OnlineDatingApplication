<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="DatingPage.aspx.cs" Inherits="TPOnlineDatingSite.DatingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
        .colorwhite{
            
            font-size:20px;
        }
        .colorwhite1{
            color:blue;
            font-size:20px;
            font:bold 10px;
        }
       .container1 {
  top: 100px;
  margin: 100px;
  background-color: #FFFFFF;
  border-radius: 50px;
  border: 3px solid #000000;
  opacity: 0.94;
}
       .date{
           padding:15px;
       }
    </style>

   
    

       <div class="container1">
  <div class="d-flex justify-content-center">
    

      <div id="divprofileinfo" runat="server" style="text-align:center;">
         <h2 style="text-align:center">Dating</h2>
          <div>
          <asp:Calendar ID="datepicker" runat="server" Visivle="false" OnSelectionChanged="datepicker_SelectionChanged">
            </asp:Calendar>
              </div>
          <br />
            <%--<asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>--%>
            <asp:TextBox ID="txtdtp" runat="server"></asp:TextBox>
          <asp:LinkButton ID="likpickdate" runat="server" OnClick="Lnkpickdate_Click">GetDate</asp:LinkButton>
          <br /><br />
          <asp:Label ID="lblLocation" runat="server" Text="Location"></asp:Label>
          <asp:DropDownList id="Locations" 
                    AutoPostBack="True"
                    OnSelectedIndexChanged="Locations_Change"
                    runat="server">
                    <asp:ListItem Selected="True" Value="Location"> Please Choice Location </asp:ListItem>
                  <asp:ListItem Value="Philadelphia"> Philadelphia </asp:ListItem>
                  <asp:ListItem Value="Lansdale"> Lansdale </asp:ListItem>
                  <asp:ListItem Value="NorthWales"> North Wales </asp:ListItem>
                  <asp:ListItem Value="kingofprussia"> king of prussia </asp:ListItem>
                  <asp:ListItem Value="NorthPhiladelphia"> North Philadelphia </asp:ListItem>

               </asp:DropDownList>
            <asp:Label ID="lblPlace" runat="server" Text="Place"></asp:Label>
             <asp:DropDownList id="Places"
                    AutoPostBack="True"
                    OnSelectedIndexChanged="Places_Change"
                    runat="server">
                 <asp:ListItem Selected="True" Value="Place"> Please Choice Place </asp:ListItem>
                  <asp:ListItem Value="SurayaRestaurant"> Suraya Restaurant </asp:ListItem>
                  <asp:ListItem Value="Maggiano"> Maggiano's Little Italy </asp:ListItem>
                  <asp:ListItem Value="TheDandelion"> The Dandelion </asp:ListItem>
                  <asp:ListItem Value="Parc"> Parc </asp:ListItem>
                  <asp:ListItem Value="Amada"> Amada </asp:ListItem>

               </asp:DropDownList>
          <br /><br />
          <div class="date">
      <asp:Button ID="btnPost" class="btn btn-dark" runat="server" Text="Submit" OnClick="PostData" />
          </div>
           
      </div>
      </div>
           </div>
</asp:Content>
