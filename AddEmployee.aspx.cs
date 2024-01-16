using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace EmployeeDeps
{
    public partial class AddEmpolyee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO: Load Department list
        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var dbString = WebConfigurationManager.ConnectionStrings["EmployeeDepsConnection"];
            using (SqlConnection sqlConnection = new SqlConnection(dbString.ConnectionString))
            {
                try
                {
                    string sqlUpdate = string.Format("INSERT INTO Employee (FirstName, LastName, Position, Salary) VALUES (\'{0}\',\'{1}\',\'{2}\',{3})", FirstName.Text, LastName.Text, Position.Text, Salary.Text);
                    sqlConnection.Open();
                    SqlCommand updateCommand = new SqlCommand(sqlUpdate, sqlConnection);
                    updateCommand.ExecuteNonQuery();
                    Response.Redirect("EmployeeList.aspx");
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