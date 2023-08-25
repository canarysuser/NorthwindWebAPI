<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <h1> Testing GROMMET App</h1>

    <div id="reactRoot" runat="server"></div>

    <script src="ReactScripts/GrommetApp.jsx"></script>
    <script type="text/jsx">
        var rootElement = document.getElementById("reactRoot"); 
        var root = ReactDOM.createRoot(rootElement); 
        root.render(<GrommetApp />)
    </script>
</asp:Content>
