﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("hello" +Request.QueryString.Get("name"));
            Response.Write("<br>");
            Response.Write("password :" + Request.Cookies["password"].Value);
        }
    }
}