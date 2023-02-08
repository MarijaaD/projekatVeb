using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Tretmani : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("");

            try
            {
                SelectTretmani(connection);
                SelectLokacije(connection);
            }
            catch (Exception x)
            {
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
        }

        void SelectTretmani(SqlConnection connection)
        {
            try
            {
                connection.Open();
                string upit = "SELECT * FROM Tretmani";
                SqlCommand command = new SqlCommand(upit, connection);
                SqlDataReader reader = command.ExecuteReader();

                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            catch (Exception x)
            {
                Label1.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }
        void SelectLokacije(SqlConnection connection)
        {
            try
            {
                connection.Open();
                string upit = "SELECT * FROM Lokacije";
                SqlCommand command = new SqlCommand(upit, connection);
                SqlDataReader reader = command.ExecuteReader();

                GridView2.DataSource = reader;
                GridView2.DataBind();
            }
            catch (Exception x)
            {
                Label1.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
