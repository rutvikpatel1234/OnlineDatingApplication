﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPOnlineDatingSite
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnlogout_Click(object sender, EventArgs e)
        //{
        //    Session.Abandon();
        //    Response.Redirect("Homeuser.aspx");
        //}

        //protected void btnlogout_Click1(object sender, EventArgs e)
        //{
        //    Session.Abandon();
        //    Response.Redirect("Homeuser.aspx");
        //}

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Homeuser.aspx");
        }
    }
}