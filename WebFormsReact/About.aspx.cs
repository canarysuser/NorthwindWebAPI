using React;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public static class PageExtensions
{
    public static void HostReactComponent(this Page page, string reactComponent, HtmlGenericControl hostElementId, object data = null, bool serverRendering=false, bool containerRendering=false)
    {
        IReactEnvironment env = AssemblyRegistration.Container.Resolve<IReactEnvironment>();

        var component = env.CreateComponent(reactComponent, data);
        hostElementId.InnerHtml = component.RenderHtml(
            renderContainerOnly: containerRendering,
            renderServerOnly: serverRendering
            );
        page.ClientScript.RegisterClientScriptBlock(
            type: page.GetType(),
            key: reactComponent+"JS",
            script: component.RenderJavaScript(waitForDOMContentLoad: true),
            addScriptTags: true
            );
    }
}
public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.HostReactComponent("GrommetApp", reactRoot, null, false, true);
    }

}