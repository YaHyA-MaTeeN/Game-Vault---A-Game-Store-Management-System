using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SE_PROJ_IDK_1._1
{
    public partial class ADMIN_USERINFO : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;

        public ADMIN_USERINFO()
        {
            InitializeComponent();
            USERS_tableLayoutPanel1.AutoScroll = true;
            PURCHASES_tableLayoutPanel2.AutoScroll = true;
        }

        private void ADMIN_USERINFO_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadPurchases();
            DisplayTotalProfit();
        }

        // Load Users into USERS_tableLayoutPanel1
        private void LoadUsers()
        {
            USERS_tableLayoutPanel1.Controls.Clear();
            USERS_tableLayoutPanel1.RowStyles.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Username, Email, Age FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Add header row
                        USERS_tableLayoutPanel1.RowCount = 1;
                        AddRowToTableLayoutPanel(USERS_tableLayoutPanel1, "Username", "Email", "Age", true);

                        // Add user rows
                        while (reader.Read())
                        {
                            string username = reader["Username"].ToString();
                            string email = reader["Email"].ToString();
                            string age = reader["Age"].ToString();
                            AddRowToTableLayoutPanel(USERS_tableLayoutPanel1, username, email, age);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Purchases into PURCHASES_tableLayoutPanel2
        private void LoadPurchases()
        {
            PURCHASES_tableLayoutPanel2.Controls.Clear();
            PURCHASES_tableLayoutPanel2.RowStyles.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            Games.Title AS GameTitle, 
                            Users.Username AS BuyerName, 
                            Purchases.PurchaseDate 
                        FROM Purchases
                        JOIN Users ON Purchases.UserID = Users.UserID
                        JOIN Games ON Purchases.GameID = Games.GameID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Add header row
                        PURCHASES_tableLayoutPanel2.RowCount = 1;
                        AddRowToTableLayoutPanel(PURCHASES_tableLayoutPanel2, "Game Title", "Buyer Name", "Purchase Date", true);

                        // Add purchase rows
                        while (reader.Read())
                        {
                            string gameTitle = reader["GameTitle"].ToString();
                            string buyerName = reader["BuyerName"].ToString();
                            string purchaseDate = reader["PurchaseDate"].ToString();
                            AddRowToTableLayoutPanel(PURCHASES_tableLayoutPanel2, gameTitle, buyerName, purchaseDate);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purchases: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display Total Profit in TOTAL_PROFIT_tableLayoutPanel1
        private void DisplayTotalProfit()
        {
            TOTAL_PROFIT_tableLayoutPanel1.Controls.Clear();
            TOTAL_PROFIT_tableLayoutPanel1.RowStyles.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            SUM(Games.Price) AS TotalProfit 
                        FROM Purchases
                        JOIN Games ON Purchases.GameID = Games.GameID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        conn.Close();

                        string totalProfit = result != DBNull.Value ? result.ToString() : "0";

                        // Add total profit to the table
                        Label profitLabel = new Label
                        {
                            Text = $"Total Sales: {totalProfit}",
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            ForeColor = Color.DarkGreen,
                            AutoSize = true
                        };

                        TOTAL_PROFIT_tableLayoutPanel1.Controls.Add(profitLabel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total profit: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper Method: Add Row to TableLayoutPanel
        private void AddRowToTableLayoutPanel(TableLayoutPanel tableLayoutPanel, string col1, string col2, string col3, bool isHeader = false)
        {
            Label lblCol1 = new Label
            {
                Text = col1,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            Label lblCol2 = new Label
            {
                Text = col2,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            Label lblCol3 = new Label
            {
                Text = col3,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            tableLayoutPanel.Controls.Add(lblCol1);
            tableLayoutPanel.Controls.Add(lblCol2);
            tableLayoutPanel.Controls.Add(lblCol3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void SHOP_PAGE_BUTTON_Click(object sender, EventArgs e)
        {
            ADMIN_SHOP aDMIN_SHOP = new ADMIN_SHOP();
            this.Hide();
            aDMIN_SHOP.Show();
        }

        private void ADMIN_NEWS_PAGE_BUTTON_Click(object sender, EventArgs e)
        {
            ADMIN_NEWS aDMIN_NEWS = new ADMIN_NEWS();
            this.Hide();
            aDMIN_NEWS.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TOTAL_PROFIT_tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
