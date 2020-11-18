using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication7
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["App"] = 0;
            Application["user"] = 0;
            Application["App"] = (int)Application["App"] + 1;
        }
        void Session_start(object sender, EventArgs e)
        {
            Application["user"] = (int)Application["user"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            Application["user"] = (int)Application["user"] + 1;
        }
    }
}