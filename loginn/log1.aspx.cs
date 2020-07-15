using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginn
{
    public partial class log1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Username, Passoword;
            Username = TextBox1.Text;
            Passoword = TextBox2.Text;
            if (Username == "hima" && Passoword == "1235") 
            {
                Response.Redirect("home.aspx");
            }
    

        }
    }
}