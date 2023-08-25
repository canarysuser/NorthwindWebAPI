<%@ Page Title="Home Page" ClientIDMode="Static" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div ID="aspNetPanel" class="div1" runat="server">
        <div id="reactRootPanel">
        <div class="card">
            <div class="header bg-primary pad2">
                <h2>ASP.NET Panel</h2>
            </div>
            <div class="body-content">
                <div class="form-group">
                    <asp:Label ID="lbl1" runat="server" Cssclass="label-success" Text="Name" />
                    <asp:TextBox ID="Name" runat="server" CssClass="form-control" /> 
                </div>
                <div class="form-group">
                    <asp:Label ID="lbl2" runat="server" Cssclass="label-success" Text="Age" />
                    <asp:TextBox ID="Age" runat="server" CssClass="form-control" /> 
                </div>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Cssclass="label-success" Text="Country" />
                    <asp:DropDownList ID="Country" runat="server" CssClass="form-control">
                        <asp:ListItem Text="--Select--" Value="0" />
                        <asp:ListItem Text="India" Value="1" />
                        <asp:ListItem Text="Spain" Value="2" />
                        <asp:ListItem Text="Italy" Value="3" />
                        <asp:ListItem Text="Egypt" Value="4" />
                        <asp:ListItem Text="Japan" Value="5" />
                    </asp:DropDownList> 
                </div>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                    UseSubmitBehavior="true" CssClass="btn btn-secondary" />
                <asp:Button ID="btnGetTime" runat="server" Text="Fetch" OnClick="btnGetTime_Click"
                    CssClass="btn btn-secondary" />
                <asp:Label ID="lblTime" runat="server" />
            </div>
        </div>
        </div>
    </div>

   <div id="reactRoot"></div>

    <script src="ReactApp/dist/vendor.js"></script>
    <script src="ReactApp/dist/runtime.js"></script>
    <script src="ReactApp/dist/main.js"></script>
</asp:Content>
