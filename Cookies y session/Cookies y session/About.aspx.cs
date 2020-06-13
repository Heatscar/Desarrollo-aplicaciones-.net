using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies_y_session
{
    public partial class About : Page
    {
        protected void Button2_Click(object sender, System.EventArgs e)
        {
            HttpCookie exampleCookie = Request.Cookies["ExampleCookie"];
            if (exampleCookie != null)
            {
                string name = exampleCookie["Edad"];
                string city = exampleCookie["Email"];

                label1.Text = "Las cookies son:<br />";
                label1.Text += "Edad: " + name + "<br />Email: " + city;


                label2.Text ="La variable de sesion Usuario es: " + Session["usuario"].ToString();
                label3.Text = "<br />La variable de sesion Clave es: " + Session["clave"].ToString();
            }
        }
    }
}