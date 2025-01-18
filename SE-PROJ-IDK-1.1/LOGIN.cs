using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace SE_PROJ_IDK_1._1
{

    public partial class LOGIN : Form
    {
        //String es = ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-NNLBQ90\\SQLEXPRESS;Initial Catalog=GameVaultDB;Integrated Security=True;Trust Server Certificate=True"].ConnectionString;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object? sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fetch username and password input
            string inputUsername = username.Text.Trim();
            string inputPassword = pass.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both Username and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;

            // SQL query to verify user credentials and fetch the IsAdmin field
            string query = "SELECT UserID, IsAdmin FROM Users WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@Username", inputUsername);
                        cmd.Parameters.AddWithValue("@Password", inputPassword);

                        // Open connection
                        conn.Open();

                        // Execute query and get the result
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Read the values from the query result
                                reader.Read();
                                int userId = reader.GetInt32(reader.GetOrdinal("UserID"));
                                bool isAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));

                                if (isAdmin)
                                {
                                    MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Redirect to Admin page
                                    ADMIN_SHOP adminPage = new ADMIN_SHOP();
                                    this.Hide();
                                    adminPage.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Welcome to the Store!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Redirect to Store page
                                    USER_SHOP storePage = new USER_SHOP(userId);
                                    this.Hide();
                                    storePage.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FORGOTPASSWORD fORGOTPASSWORD = new FORGOTPASSWORD();
            this.Hide();
            fORGOTPASSWORD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
