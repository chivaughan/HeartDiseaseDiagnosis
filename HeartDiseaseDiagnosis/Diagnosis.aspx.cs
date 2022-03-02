using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HealthRecordSystem
{
    public partial class Diagnosis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //Do this the very first time the page loads
            {
                if (Session["IllnessInfo"] == null || Session["DietInfo"] == null) // Check whether the session variables are null
                {
                    Response.Redirect("Default.aspx"); //Redirect to the home page if any of the session variables is null
                    return; // Stop every further action
                }
                ltrIllnessInfo.Text = Session["IllnessInfo"].ToString();
                ltrDietInfo.Text = Session["DietInfo"].ToString();
                Session.Remove("IllnessInfo");
                Session.Remove("DietInfo");
                //Populate the gridview with the content of the diet table
                string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                SqlConnection conn;
                string selectString = @"SELECT * FROM Diet";
                SqlDataAdapter da;
                DataTable dt;
                conn = new SqlConnection(connString);
                conn.Open(); // Open the connection
                da = new SqlDataAdapter(selectString, conn);
                dt = new DataTable();
                da.Fill(dt);
                grvDiet.DataSource = dt;
                grvDiet.DataBind();
                da.Dispose();
                dt.Dispose();
                conn.Close(); // Close the connection
            }
        }
    }
}