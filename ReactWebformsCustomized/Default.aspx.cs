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
        if(!IsPostBack)
        {
            Name.Text = "Sample";
            Age.Text = "100";
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Name.Text = this.Name.Text.ToUpper() + ", " + this.Country.SelectedItem.Text;
    }

    protected void btnGetTime_Click(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToString();
    }
}