using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthRecordSystem
{
    public partial class Calvary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MainView.ActiveViewIndex = 0; // Set the default view
                btnTabDiet.CssClass = "tabActive";
            }
        }

        protected void lnkAddDiet_Click(object sender, EventArgs e)
        {
            TextBox txtFoodGroup = grvDiet.FooterRow.FindControl("txtNewFoodGroup") as TextBox;
            DietDataSource.InsertParameters["FoodGroup"].DefaultValue = txtFoodGroup.Text;
            TextBox txtDailyServings = grvDiet.FooterRow.FindControl("txtNewDailyServings") as TextBox;
            DietDataSource.InsertParameters["DailyServings"].DefaultValue = txtDailyServings.Text;
            TextBox txtServingSizes = grvDiet.FooterRow.FindControl("txtNewServingSizes") as TextBox;
            DietDataSource.InsertParameters["ServingSizes"].DefaultValue = txtFoodGroup.Text;
            DietDataSource.Insert(); //insert the new diet                        

        }

        protected void btnTabDiet_Click(object sender, EventArgs e)
        {
            btnTabDiet.CssClass = "tabActive";
            btnTabPatients.CssClass = "tabView";
            MainView.ActiveViewIndex = 0; // Set the default view            
        }

        protected void btnTabPatients_Click(object sender, EventArgs e)
        {
            btnTabDiet.CssClass = "tabView";
            btnTabPatients.CssClass = "tabActive";
            MainView.ActiveViewIndex = 1; // Set the default view            
        }
    }
}