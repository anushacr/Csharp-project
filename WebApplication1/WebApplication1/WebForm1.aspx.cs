using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id;
            string tutorialname, tutorialdesc;
            id = Convert.ToInt32(TextBox1.Text);
            tutorialname = TextBox2.Text;
            tutorialdesc = TextBox3.Text;
            Label4.Text = "tutorial details" + id + "," + tutorialname + "," + tutorialdesc;
        }
    }
}
    