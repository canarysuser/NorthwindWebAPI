<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <h1> React With WebForms</h1>
       <div ID="pnl1" runat="server">

       </div>
       <asp:Panel ID="aspNetPanel" runat="server">
 <div className="card shadow mt-6 m-auto w-50">
                <div className="card-header bg-primary">
                </div>
                <div className="card-body">
                    <p> Welcome to ASP.NET App</p>
                    <asp:Label ID="idLabel" runat="server"> </asp:Label>
                    <asp:Label ID="nameLabel" runat="server"> </asp:Label>
                </div>
              
                    <asp:Label ID="Label1" runat="server" Text="Id" />
                    <asp:TextBox ID="Id" runat="server" />
                       <br />
                    <asp:Label ID="Label2" runat="server" Text="Name" />
                    <asp:TextBox ID="Name" runat="server" />
                        
                    <asp:Button runat="server" ID="btn1" onClick="btn1_Click" Text="Submit" />
                
            </div>
       </asp:Panel>
         
    </div>
    <script src="ReactScripts/App.jsx"></script>
    <%--<script defer src="Scripts/Components/App.jsx" type="text/babel"></script>--%>
    
</asp:Content>
