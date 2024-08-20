using System;
using System.Data.SqlClient;

namespace ECommerce
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "ECommerceDB";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Users (Nom, Prenoms, DateNaissance, Login, Password) VALUES (@Nom, @Prenoms, @DateNaissance, @Login, @Password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@Prenoms", txtPrenoms.Text);
                cmd.Parameters.AddWithValue("@DateNaissance", txtDateNaissance.Text);
                cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblMessage.Text = "Erreur lors de l'inscription.";
                }
            }
        }
    }
}
