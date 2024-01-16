using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDeps
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RefreshGridDate();
            }
        }

        public void RefreshGridDate()
        {
            var dbString = WebConfigurationManager.ConnectionStrings["EmployeeDepsConnection"];
            using (SqlConnection sqlConnection = new SqlConnection(dbString.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand employeesList = new SqlCommand("SELECT EmployeeID, CONCAT(FirstName,' ', LastName) as FullName FROM Employee", sqlConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(employeesList);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        elGird.DataSource = dataSet;
                        elGird.DataBind();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    sqlConnection.Dispose();
                }
            }
        }

        protected void elGird_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            // TODO: Confirm Dialog
        }

        protected void elGird_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedRow = elGird.Rows[index];

            if (e.CommandName == "ViewEmployee")
            {
                // TODO: Show Details Departments
            }
            else if (e.CommandName == "EditEmployee")
            {
                HiddenField idControl = (HiddenField)selectedRow.FindControl("hdEmpId");
                int empId = int.Parse(idControl.Value);
                Response.Redirect("EditEmployee.aspx?empId=" + empId);
            }
        }

        protected void elAddEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmployee.aspx");
        }
    }
}