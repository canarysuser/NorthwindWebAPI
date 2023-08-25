using React;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class TestClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public partial class _Default : Page
{
    private TestClass data;
    public _Default()
    {
        data = new TestClass { Id = 100, Name = "Sample" };
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (IsPostBack)
        //{
        //    var formId = Request.Form["Id"];
        //    var formName = Request.Form["Name"];
        //    data = new TestClass
        //    {
        //        Id = Convert.ToInt32(formId),
        //        Name = formName
        //    };
        //    Id.Text = data.Id.ToString();
        //    Name.Text = data.Name;
        //    HostReactComponent();
        //}
        if (!IsPostBack)
        {
            //var data = new TestClass{ Id = 100, Name = "Sample" };
            Id.Text = data.Id.ToString(); 
            Name.Text = data.Name;
            HostReactComponent();
        }

    }
    private void HostReactComponent()
    {
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
    protected void Unnamed_Click(object sender, EventArgs e)
    {

    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        data = new TestClass
        {
            Id = Convert.ToInt32(Id.Text),
            Name = Name.Text.ToUpper()
        };
        HostReactComponent(); 
        Name.Text = data.Name;
        Id.Text = data.Id.ToString();
    }
}