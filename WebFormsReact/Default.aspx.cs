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
        if (IsPostBack)
        {
            var formId = Request.Form["Id"];
            var formName = Request.Form["Name"];
        }
        if (!IsPostBack)
        {
            var data = new { Id = 100, Name = "Sample" };
            Id.Text = data.Id.ToString(); 
            Name.Text = data.Name;  

            IReactEnvironment env = AssemblyRegistration.Container.Resolve<IReactEnvironment>();
           
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

    protected void Unnamed_Click(object sender, EventArgs e)
    {

    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        Name.Text = Name.Text.ToUpper();
    }
}