<%@ Application Language="C#" %>
<%@ Import Namespace="WebFormsReact" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="JavaScriptEngineSwitcher.Core" %>
<%@ Import Namespace="JavaScriptEngineSwitcher.V8" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);

        JsEngineSwitcher.Current.EngineFactories.AddV8();
        JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
        
        //Server Side Rendering 
        React.ReactSiteConfiguration.Configuration
            .AddScript("~/ReactScripts/App.jsx")
            .AddScript("~/ReactScripts/GrommetApp.jsx")
            ;



    }

</script>
