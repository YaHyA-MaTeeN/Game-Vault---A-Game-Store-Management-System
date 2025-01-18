using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SE_PROJ_IDK_1._1
{
    public partial class USER_SHOP : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;
        private int _userId;

        public USER_SHOP(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            tableLayoutPanel1.AutoScroll = true; // Enable scrolling
        }

        // Load data when the form is first loaded
        private void USER_SHOP_Load(object sender, EventArgs e)
        {
            // Load available games into the table layout
            LoadAvailableGames();
        }

        // Method to load available games into the TableLayoutPanel
        private void LoadAvailableGames()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT g.GameID, g.Title, g.Description, g.Price
                FROM Games g
                WHERE g.GameID NOT IN (
                    SELECT p.GameID
                    FROM Purchases p
                    WHERE p.UserID = @UserID
                )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for the user ID
                        cmd.Parameters.AddWithValue("@UserID", _userId);

                        // Open the database connection
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Clear the TableLayoutPanel
                        tableLayoutPanel1.Controls.Clear();
                        tableLayoutPanel1.RowStyles.Clear();

                        // Add header row
                        tableLayoutPanel1.RowCount = 1;
                        AddGameRow("Title", "Description", "Price", true);

                        // Add rows for each game
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            string description = reader["Description"].ToString();
                            string price = $"${reader["Price"].ToString()}";
                            int gameId = Convert.ToInt32(reader["GameID"]);
                            AddGameRow(title, description, price, false, gameId);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading games: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to add a row to the TableLayoutPanel
        private void AddGameRow(string title, string description, string price, bool isHeader = false, int gameId = 0)
        {
            // Title Label
            Label lblTitle = new Label
            {
                Text = title,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            // Description Label
            Label lblDescription = new Label
            {
                Text = description,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            // Price Label or Button
            Control priceControl;
            if (isHeader)
            {
                priceControl = new Label
                {
                    Text = price,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.DarkBlue
                };
            }
            else
            {
                Button purchaseButton = new Button
                {
                    Text = price,
                    Tag = gameId, // Store GameID in the button's Tag property
                    Width = 100,
                    Height = 30
                };
                purchaseButton.Click += GameButton_Click; // Add click event
                priceControl = purchaseButton;
            }

            // Add controls to the TableLayoutPanel
            tableLayoutPanel1.Controls.Add(lblTitle);
            tableLayoutPanel1.Controls.Add(lblDescription);
            tableLayoutPanel1.Controls.Add(priceControl);
        }

        // Event handler for when a purchase button is clicked
        private void GameButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag != null)
            {
                int gameId = Convert.ToInt32(button.Tag); // Get GameID from the button's Tag property
                ShowPaymentPage(gameId); // Show the payment page
            }
        }

        // Method to show the payment page
        private void ShowPaymentPage(int gameID)
        {
            // Open the payment page and pass the GameID
            payment_page paymentForm = new payment_page(gameID, _userId);
            paymentForm.ShowDialog();
        }

        // Button: Help page
        private void button2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        // Button: News page
        private void button3_Click(object sender, EventArgs e)
        {
            USER_NEWS userNews = new USER_NEWS(_userId);
            this.Hide();
            userNews.Show();
        }

        // Button: Library page
        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            ShowUserLibrary();
        }

        // Method to show the user's purchased games
        private void ShowUserLibrary()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT Games.GameID, Games.Title, Games.Description, Games.Price 
                        FROM Games 
                        INNER JOIN Purchases ON Games.GameID = Purchases.GameID 
                        WHERE Purchases.UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Clear the TableLayoutPanel
                        tableLayoutPanel1.Controls.Clear();
                        tableLayoutPanel1.RowStyles.Clear();

                        // Add header row
                        tableLayoutPanel1.RowCount = 1;
                        AddGameRow("Title", "Description", "Price", true);

                        // Add rows for each purchased game
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            string description = reader["Description"].ToString();
                            string price = $"${reader["Price"].ToString()}";
                            int gameId = Convert.ToInt32(reader["GameID"]);
                            AddGameRow(title, description, price, false, gameId);
                        }
                        conn.Close();
                        USER_LIBRARY uSER_LIBRARY = new USER_LIBRARY(_userId);
                        this.Hide();
                        uSER_LIBRARY.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading library: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }
    }
}
