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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnLogin(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = northwind");
            SqlCommand cmd;
            string sqlins = "SELECT * FROM Magician WHERE name = @Name AND password = @Password";

            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlins, conn);

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar);

                cmd.Parameters["@Name"].Value = NameInput.Text;
                cmd.Parameters["@Password"].Value = PasswordInput.Text;

                cmd.ExecuteNonQuery();
                Response.Redirect("Profile.aspx");

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