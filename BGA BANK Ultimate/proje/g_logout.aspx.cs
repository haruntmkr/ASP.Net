﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class g_logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Cookie cookie = new Cookie();
        cookie.yoket();
        Response.Redirect("g_log_in.aspx");

    }
}