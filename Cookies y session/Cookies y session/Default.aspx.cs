using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies_y_session
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
                HttpCookie testCokkie = new HttpCookie("ExampleCookie");
                testCokkie.Expires = DateTime.Now.AddDays(5);
                Response.Cookies.Add(testCokkie);
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            HttpCookie ExampleCookie = Request.Cookies["ExampleCookie"];
            ExampleCookie["Edad"] = TextBox1.Text.ToString();
            ExampleCookie["Email"] = TextBox2.Text.ToString();

            Session["usuario"] = TextBox3.Text;
            Session["clave"] = TextBox4.Text;
            Response.Cookies.Add(ExampleCookie);
            Response.Redirect("About.aspx");
        }

    }
}