using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.DataConnection;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(txtTutorialId.Text);
            tutorialModel.TutorialName = txtTutorialName.Text;
            tutorialModel.TutorialDesc = txtTutorialDesc.Text;
            tutorialModel.Published = Convert.ToInt32(txtPublished.Text);

            string msg = tutorialDBConnectionObj.InsertTutorial(tutorialModel);
            lblResult.Text = msg;

            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }

       

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
    