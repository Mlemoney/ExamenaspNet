using System;
using System.Data.SqlClient;

namespace ECommerce
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "ECommerceDB"; // Remplacez par votre chaîne de connexion
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE Login=@login AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Connexion réussie
                    Session["UserLogin"] = txtLogin.Text;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    // Échec de la connexion
                    lblMessage.Text = "Login ou mot de passe incorrect.";
                }
            }
        }
    }
}
