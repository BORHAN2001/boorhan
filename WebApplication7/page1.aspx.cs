using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class page1 : System.Web.UI.Page
    {
        static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox3.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string textbox1 = (string)Session["firstname"];
            TextBox1.Text = textbox1;
            string textbox2 = (string)Session["lastname"];
            TextBox2.Text = textbox2;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["firstname"] = TextBox1.Text;
            TextBox1.Text = "";
            Session["lastname"] = TextBox2.Text;
            TextBox2.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            count = count + 1;
            ViewState["number"] = count;
            TextBox3.Text = ViewState["number"].ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx?name=" + TextBox1.Text);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpCookie mycookies = new HttpCookie("password", "112233");
            Response.Cookies.Add(mycookies);
            Response.Redirect("page2.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx?name=" + TextBox1.Text);
        }
    }
}