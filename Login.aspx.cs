﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebToExplainBranching
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            if(string.IsNullOrEmpty(txtUserName.Text) ||string.IsNullOrEmpty(txtUserPwd.Text))
            {
                lblMsg.Text = "Mandatory";
            }
            else
            {
                if((txtUserName.Text=="sam") && (txtUserPwd.Text == "sam123"))
                {
                    lblMsg.Text = "Login Success";
                }
                else
                {
                    lblMsg.Text = "Login Failure";
                }
            }

        }
    }
}