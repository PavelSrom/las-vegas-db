using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace handin4
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowGrid();
        }

        protected void ShowGrid()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = northwind");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlsel = "SELECT * FROM Magician";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);
                rdr = cmd.ExecuteReader();

                HomeGridView.DataSource = rdr;
                HomeGridView.DataBind();

                Message.Text = "Data fetched successfully!";
            }
            catch (Exception err)
            {
                Message.Text = err.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}