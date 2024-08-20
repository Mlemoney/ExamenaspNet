using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class ArticleForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Remplir les catégories (exemple de remplissage)
                ddlCategory.Items.Add(new ListItem("Chemise", "Chemise"));
                ddlCategory.Items.Add(new ListItem("Pantalon", "Pantalon"));
                ddlCategory.Items.Add(new ListItem("Robe", "Robe"));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "ECommerceDB"; // Remplacez par votre chaîne de connexion

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Articles (Nom, Description, Categorie, Genre, Couleur, Taille, Prix) " +
                               "VALUES (@Nom, @Description, @Categorie, @Genre, @Couleur, @Taille, @Prix)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Categorie", ddlCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@Genre", ddlGenre.SelectedValue);
                cmd.Parameters.AddWithValue("@Couleur", txtCouleur.Text);
                cmd.Parameters.AddWithValue("@Taille", txtTaille.Text);
                cmd.Parameters.AddWithValue("@Prix", txtPrix.Text);

                cmd.ExecuteNonQuery();
                lblMessage.Text = "Article ajouté avec succès!";
            }
        }
    }
}
