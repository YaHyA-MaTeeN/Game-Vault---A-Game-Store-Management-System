using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SE_PROJ_IDK_1._1
{
    public partial class USER_LIBRARY : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;
        private int _userId; // Store the UserID for the current user

        public USER_LIBRARY(int userId)
        {
            InitializeComponent();
            _userId = userId; // Receive the UserID from the previous form
            tableLayoutPanel1.AutoScroll = true; // Enable scrolling
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            USER_NEWS userNews = new USER_NEWS(_userId);
            this.Hide();
            userNews.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            USER_SHOP userShop = new USER_SHOP(_userId);
            this.Hide();
            userShop.Show();
        }

        private void USER_LIBRARY_Load(object sender, EventArgs e)
        {
            LoadPurchasedGames();
        }

        private void LoadPurchasedGames()
        {
            string query = @"
                SELECT g.GameID, g.Title, g.Description, g.Price 
                FROM Purchases p
                INNER JOIN Games g ON p.GameID = g.GameID
                WHERE p.UserID = @UserID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add the parameter for the user ID
                        cmd.Parameters.AddWithValue("@UserID", _userId);

                        // Open connection
                        conn.Open();

                        // Execute the query and read the results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear the TableLayoutPanel before adding new rows
                            tableLayoutPanel1.Controls.Clear();
                            tableLayoutPanel1.RowStyles.Clear();

                            // Add a header row
                            tableLayoutPanel1.RowCount = 1;
                            AddGameRow("Title", "Description", "Price", true);

                            // Loop through the rows returned by the query
                            while (reader.Read())
                            {
                                int gameId = Convert.ToInt32(reader["GameID"]);
                                string gameTitle = reader["Title"].ToString();
                                string gameDescription = reader["Description"].ToString();
                                string gamePrice = $"${reader["Price"].ToString()}";

                                // Add the game row with clickable functionality
                                AddGameRow(gameTitle, gameDescription, gamePrice, false, gameId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purchased games: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddGameRow(string title, string description, string price, bool isHeader, int gameId = 0)
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

            // Price Label or Download Button
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
                Button downloadButton = new Button
                {
                    Text = "Download",
                    Tag = gameId, // Store GameID in the button's Tag property
                    Width = 100,
                    Height = 30
                };
                downloadButton.Click += GameDownloadButton_Click; // Add click event
                priceControl = downloadButton;
            }

            // Add controls to the TableLayoutPanel
            tableLayoutPanel1.Controls.Add(lblTitle);
            tableLayoutPanel1.Controls.Add(lblDescription);
            tableLayoutPanel1.Controls.Add(priceControl);
        }

        private void GameDownloadButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag != null)
            {
                int gameId = Convert.ToInt32(button.Tag); // Get GameID from the button's Tag property
                DownloadGame(gameId); // Simulate the download
            }
        }

        private void DownloadGame(int gameId)
        {
            try
            {
                // Simulate downloading the game (You can add actual download logic here if required)
                MessageBox.Show($"Game with ID {gameId} has been successfully downloaded!", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading game: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
