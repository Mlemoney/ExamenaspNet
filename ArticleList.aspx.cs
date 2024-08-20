using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class ArticleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadArticles();
            }
        }

        private void LoadArticles()
        {
            string connectionString = "ECommerceDB"; // Remplacez par votre chaîne de connexion

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Articles";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int articleId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Delete")
            {
                DeleteArticle(articleId);
                LoadArticles();
            }
            else if (e.CommandName == "Edit")
            {
                Response.Redirect($"ArticleForm.aspx?Id={articleId}");
            }
        }

        private void DeleteArticle(int id)
        {
            string connectionString = "ECommerceDB"; // Remplacez par votre chaîne de connexion

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Articles WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
