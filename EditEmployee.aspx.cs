using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeDeps.Models;

namespace EmployeeDeps
{
    public partial class EditEmpolyee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var employeeID = int.Parse(Request.QueryString["empId"]);
                LoadEmployee(employeeID);
            }
        }
        public void LoadEmployee(int employeeID)
        {
            var dbString = WebConfigurationManager.ConnectionStrings["EmployeeDepsConnection"];
            using (SqlConnection sqlConnection = new SqlConnection(dbString.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string getEmpQuery = string.Format("SELECT * FROM Employee WHERE EmployeeID = {0}", employeeID);
                    SqlCommand getEmpCmd = new SqlCommand(getEmpQuery, sqlConnection);
                    SqlDataReader dr = getEmpCmd.ExecuteReader();
                    // TODO: Fill Fields
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
    }
}