using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SE_PROJ_IDK_1._1
{
    public partial class payment_page : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;
        private int _gameId;
        private int _userId;

        public payment_page(int gameId, int userId)
        {
            InitializeComponent();
            _gameId = gameId;
            _userId = userId;
        }

        private void CONFIRM_PAYMENT_button2_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(name_textBox3.Text) ||
                string.IsNullOrWhiteSpace(cardnumber_textBox1.Text) ||
                string.IsNullOrWhiteSpace(date_issued_textBox2.Text) ||
                string.IsNullOrWhiteSpace(pjone_number_textBox4.Text) ||
                string.IsNullOrWhiteSpace(address_textBox5.Text))
            {
                MessageBox.Show("Please fill in all fields before confirming the payment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with payment if validation is successful
            InsertPurchaseRecord();
        }

        private void InsertPurchaseRecord()
        {
            try
            {
                // Assume we have a connection string for the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get the logged-in UserID (this would usually be fetched from a logged-in session)

                    string query = "INSERT INTO Purchases (UserID, GameID, PurchaseDate) VALUES (@UserID, @GameID, @PurchaseDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@GameID", _gameId);
                        cmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Show confirmation message
                MessageBox.Show("Purchase Successful!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the payment page and return to the shop (or navigate to the library)
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing your payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payment_page_Load(object sender, EventArgs e)
        {

        }

        private void cardnumber_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CANCEL_BUTTON_Click(object sender, EventArgs e)
        {
             
            this.Close();
            
        }
    }
}
