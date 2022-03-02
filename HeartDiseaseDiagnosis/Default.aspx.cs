using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthRecordSystem
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTakeTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("Test.aspx"); // Display the Test page
        }
    }
}