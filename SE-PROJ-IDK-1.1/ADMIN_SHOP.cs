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
    public partial class ADMIN_SHOP : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;

        public ADMIN_SHOP()
        {
            InitializeComponent();
            tableLayoutPanel1.AutoScroll = true;
        }

        // Event: Form Load - Display all games
        private void ADMIN_SHOP_Load(object sender, EventArgs e)
        {
            LoadGames();
        }

        // Event: Add new game
        private void button2_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();
            string priceInput = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(priceInput))
            {
                MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to parse price as decimal
            if (!decimal.TryParse(priceInput, out decimal price))
            {
                MessageBox.Show("Please enter a valid price!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string insertQuery = "INSERT INTO Games (Title, Description, Price) VALUES (@Title, @Description, @Price)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Price", price);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Game added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                        LoadGames();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method: Load all games into the TableLayoutPanel
        private void LoadGames()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string getGamesQuery = "SELECT GameID, Title, Description, Price FROM Games";
                    using (SqlCommand cmd = new SqlCommand(getGamesQuery, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Add header row
                        tableLayoutPanel1.RowCount = 1;
                        AddGameRow("Title", "Description", "Price", true);

                        while (reader.Read())
                        {
                            int gameId = Convert.ToInt32(reader["GameID"]);
                            string title = reader["Title"].ToString();
                            string description = reader["Description"].ToString();
                            string price = reader["Price"].ToString();
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

        // Method: Add a row to the TableLayoutPanel
        private void AddGameRow(string title, string description, string price, bool isHeader = false, int gameId = 0)
        {
            // Title Column
            Label lblTitle = new Label
            {
                Text = title,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                AutoEllipsis = true
            };

            // Description Column
            Label lblDescription = new Label
            {
                Text = description,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                AutoSize = true, // Allow the label to wrap the text
                MaximumSize = new Size(200, 0) // Set a maximum width for the label
            };

            // Price Column
            Label lblPrice = new Label
            {
                Text = price,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
            };

            // Remove Button
            Button btnRemove = new Button
            {
                Text = isHeader ? "" : "Remove",
                Dock = DockStyle.Fill,
                Tag = gameId,
                Enabled = !isHeader // Disable button for header
            };

            if (!isHeader)
            {
                btnRemove.Click += (s, e) =>
                {
                    // Remove game logic
                    DialogResult result = MessageBox.Show("Do you want to remove this game?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        RemoveGame(gameId);
                    }
                };
            }

            // Add controls to TableLayoutPanel in the correct order
            int rowIndex = tableLayoutPanel1.RowCount++; // Increment row count
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tableLayoutPanel1.Controls.Add(lblTitle, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(lblDescription, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(lblPrice, 2, rowIndex);
            tableLayoutPanel1.Controls.Add(btnRemove, 3, rowIndex);
        }

        // Method: Remove a game from the database
        private void RemoveGame(int gameId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string deleteQuery = "DELETE FROM Games WHERE GameID = @GameID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@GameID", gameId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Game removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGames();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing game: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method: Clear input fields
        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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

        private void REPORT_PAGE_BUTTON_Click(object sender, EventArgs e)
        {
            ADMIN_USERINFO aDMIN_USERINFO = new ADMIN_USERINFO();
            this.Hide();
            aDMIN_USERINFO.Show();
        }

        private void NEWS_PAGE_BUTTON_Click(object sender, EventArgs e)
        {
            ADMIN_NEWS aDMIN_NEWS = new ADMIN_NEWS();
            this.Hide();
            aDMIN_NEWS.Show();
        }

        // Other event handlers (button1_Click, NEWS_PAGE_BUTTON_Click, REPORT_PAGE_BUTTON_Click)
        // ...
    }
}