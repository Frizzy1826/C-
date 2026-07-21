using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical5c
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            { int ViewStateVal = Convert.ToInt32(ViewState["count"]) + 1;
              Label2.Text = "view state ="+ViewStateVal.ToString();
            }
            else
            {
                ViewState["count"] = 1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = ViewState["count"].ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie h = new HttpCookie("name");
            h.Value=TextBox1.Text;
            Response.Cookies.Add(h);
            Response.Redirect("Webform2.aspx");

        }
    }
}
