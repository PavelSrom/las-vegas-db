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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnRegister(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = northwind");
            SqlCommand cmd;
            string sqlins = "INSERT INTO Magician VALUES (@Name, @ArtistName, @Password, @Role)";

            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlins, conn);

                cmd.Parameters.Add("@Name", SqlDbType.Text);
                cmd.Parameters.Add("@ArtistName", SqlDbType.Text);
                cmd.Parameters.Add("@Password", SqlDbType.Text);
                cmd.Parameters.Add("@Role", SqlDbType.Text);

                cmd.Parameters["@Name"].Value = NameInput.Text;
                cmd.Parameters["@ArtistName"].Value = ArtistNameInput.Text;
                cmd.Parameters["@Password"].Value = PasswordInput.Text;
                cmd.Parameters["@Role"].Value = Role.SelectedValue;

                cmd.ExecuteNonQuery();

                if (Role.SelectedValue.Equals("Secretary"))
                {
                    Message.Text = "Secretary has been registered";
                } else if (Role.SelectedValue.Equals("Manager"))
                {
                    Message.Text = "Manager has been registered";
                } else
                {
                    Message.Text = "Magician has been registered";
                }
            } catch (Exception err)
            {
                Message.Text = err.Message;
            } finally
            {
                conn.Close();
            }


        }
    }
}