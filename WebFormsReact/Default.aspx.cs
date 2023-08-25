using React;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IReactEnvironment env = AssemblyRegistration.Container.Resolve<IReactEnvironment>();
        var data = new { Id = 100, Name = "Sample" };
        var component = env.CreateComponent("App", data);
        pnl1.InnerHtml = component.RenderHtml(
            renderContainerOnly: false,
            renderServerOnly: false
            );
        ClientScript.RegisterClientScriptBlock(
            type: GetType(),
            key: "AppScript",
            script: component.RenderJavaScript(waitForDOMContentLoad: true),
            addScriptTags: true
            );

    }
}