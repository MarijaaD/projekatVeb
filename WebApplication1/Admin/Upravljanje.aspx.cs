using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin
{
    public partial class Upravljanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=RELJA;Initial Catalog=marija;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                SelectTretmani(connection);
            }
            catch (Exception x)
            {
                Label5.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=RELJA;Initial Catalog=marija;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            int id = int.Parse(TextBox1.Text);
            string ime = TextBox2.Text;
            string ImeTretmana = TextBox3.Text;
            int Trajanje = int.Parse(TextBox4.Text);

            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
                {
                    Insert(connection, id, ime, ImeTretmana, Trajanje);
                }
                else
                {
                    Label5.Text = "MORATE UNETI SVE PODATKE";
                }
            }
            catch (Exception x)
            {
                Label5.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                SelectTretmani(connection);
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
                Label5.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }
        void Insert(SqlConnection connection, int id, string ime, string imeTretman, int trajanje)
        {
            try
            {
                connection.Open();
                SqlParameter p = new SqlParameter();
                SqlParameter p1 = new SqlParameter();
                SqlParameter p2 = new SqlParameter();
                SqlParameter p3 = new SqlParameter();

                p.Value = id;
                p1.Value = ime;
                p2.Value = imeTretman;
                p3.Value = trajanje;

                p.ParameterName = "@id";
                p1.ParameterName = "@ime";
                p2.ParameterName = "@imeTretman";
                p3.ParameterName = "@trajanje";

                string upit = "INSERT INTO Tretmani VALUES(@id,@ime,@imeTretman,@trajanje)";
                SqlCommand command = new SqlCommand(upit, connection);

                command.Parameters.Add(p);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);

                command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Label5.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
                TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
            }
        }

    }
}