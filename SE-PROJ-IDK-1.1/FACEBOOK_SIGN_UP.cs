using System.Configuration;
using System.Data.SqlClient;

namespace SE_PROJ_IDK_1._1
{
    public partial class FACEBOOK_SIGN_UP : Form
    {
        public FACEBOOK_SIGN_UP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }

        private void FACEBOOK_SIGN_UP_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fetch input values from textboxes
            string username = name.Text.Trim();
            string userPassword = password.Text.Trim();
            string userEmail = email.Text.Trim();
            int userAge;

            // Validate that all fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(userEmail) || !int.TryParse(age.Text.Trim(), out userAge))
            {
                MessageBox.Show("Please fill all fields correctly!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that username contains only alphabetic characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Username must contain only alphabetic characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!System.Text.RegularExpressions.Regex.IsMatch(userEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address (e.g., sheri@gmail.com).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password length
            if (userPassword.Length < 8)
            {
                MessageBox.Show("Password must contain at least 8 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (userAge <= 0)
            {
                MessageBox.Show("Age must be a positive integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;

            // SQL query to insert a new user into the Users table
            string query = "INSERT INTO Users (Username, Password, Email, IsAdmin, Age) VALUES (@Username, @Password, @Email, 0, @Age)";

            try
            {
                // Create a new SqlConnection and SqlCommand
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", userPassword);
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        cmd.Parameters.AddWithValue("@Age", userAge);

                        // Open the connection and execute the query
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (result > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the input fields
                            name.Clear();
                            password.Clear();
                            email.Clear();
                            age.Clear();
                            HOME hOME = new HOME();
                            this.Hide();
                            hOME.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occur
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
