using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SE_PROJ_IDK_1._1
{
    public partial class FORGOTPASSWORD : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;
        private const string RECOVERY_CODE = "123"; // Hardcoded recovery code
        public FORGOTPASSWORD()
        {
            InitializeComponent();
        }

        // Event: Update password button click
        private void button1_Click(object sender, EventArgs e)
        {
            string username = USERNAME_textBox.Text.Trim();
            string code = CODE_textBox.Text.Trim();
            string newPassword = PASSWORD_textBox.Text.Trim();
            string confirmPassword = CONFIRM_PASSWORD_textBox.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(code) ||
                string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (code != RECOVERY_CODE)
            {
                MessageBox.Show("Invalid recovery code!", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update password in the database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if user exists
                    string checkUserQuery = "SELECT IsAdmin FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Update password
                        string updatePasswordQuery = "UPDATE Users SET Password = @Password WHERE Username = @Username";
                        using (SqlCommand updateCmd = new SqlCommand(updatePasswordQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Password", newPassword); // TODO: Hash the password
                            updateCmd.Parameters.AddWithValue("@Username", username);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Redirect based on role
                                bool isAdmin = Convert.ToBoolean(result);
                                if (isAdmin)
                                {
                                    ADMIN_SHOP adminShop = new ADMIN_SHOP();
                                    adminShop.Show();
                                }
                                else
                                {
                                    // Fetch the user ID for the logged-in user
                                    string fetchUserIdQuery = "SELECT UserID FROM Users WHERE Username = @Username";
                                    using (SqlCommand fetchIdCmd = new SqlCommand(fetchUserIdQuery, conn))
                                    {
                                        fetchIdCmd.Parameters.AddWithValue("@Username", username);
                                        int userId = (int)fetchIdCmd.ExecuteScalar();

                                        USER_SHOP userShop = new USER_SHOP(userId);
                                        userShop.Show();
                                    }
                                }

                                this.Close(); // Close forgot password form
                            }
                            else
                            {
                                MessageBox.Show("Password update failed! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FORGOTPASSWORD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
