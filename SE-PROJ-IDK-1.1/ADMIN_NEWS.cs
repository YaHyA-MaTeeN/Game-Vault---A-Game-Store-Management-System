using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SE_PROJ_IDK_1._1
{
    public partial class ADMIN_NEWS : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;

        public ADMIN_NEWS()
        {
            InitializeComponent();
            tableLayoutPanel1.AutoScroll = true; // Enable scrolling for the table
            this.Load += new EventHandler(this.ADMIN_NEWS_Load); // Ensure the Load event is properly wired
        }

        // Event: Form Load - Display all news
        private void ADMIN_NEWS_Load(object sender, EventArgs e)
        {
            LoadNews();
        }

        // Event: Add new news
        private void button2_Click(object sender, EventArgs e)
        {
            string title = TITLE_textBox1.Text.Trim();
            string content = ADD_NEWS_CONTENT_textBox1.Text.Trim();

            // Input validation
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Both Title and Content are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert new news into the database
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO News (Title, Content) VALUES (@Title, @Content)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Content", content);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("News added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                        LoadNews(); // Refresh the displayed news
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method: Load all news into the TableLayoutPanel
        private void LoadNews()
        {
            tableLayoutPanel1.Controls.Clear(); // Clear previous rows
            tableLayoutPanel1.RowStyles.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Title, Content, PublishedDate FROM News ORDER BY PublishedDate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Add header row
                        tableLayoutPanel1.RowCount = 1;
                        AddNewsRow("Title", "Content", "Published Date", true);

                        // Dynamically add rows for each news item
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            string content = reader["Content"].ToString();
                            string publishedDate = Convert.ToDateTime(reader["PublishedDate"]).ToString("yyyy-MM-dd");

                            AddNewsRow(title, content, publishedDate);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading news: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method: Add a row to TableLayoutPanel
        private void AddNewsRow(string title, string content, string date, bool isHeader = false)
        {
            Label lblTitle = new Label
            {
                Text = title,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            Label lblContent = new Label
            {
                Text = content,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            Label lblDate = new Label
            {
                Text = date,
                AutoSize = true,
                Font = isHeader ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9),
                ForeColor = isHeader ? Color.DarkBlue : Color.Black
            };

            tableLayoutPanel1.Controls.Add(lblTitle);
            tableLayoutPanel1.Controls.Add(lblContent);
            tableLayoutPanel1.Controls.Add(lblDate);
        }

        // Method: Clear input fields
        private void ClearInputFields()
        {
            TITLE_textBox1.Clear();
            ADD_NEWS_CONTENT_textBox1.Clear();
        }

        // Back button to return to previous page
        private void button1_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }

        private void REPORT_PAGE_BUTTON_Click(object sender, EventArgs e)
        {
            ADMIN_USERINFO adminUserInfo = new ADMIN_USERINFO();
            this.Hide();
            adminUserInfo.Show();
        }

        private void SHOP_PAGE_BUTTON_Click(object sender, EventArgs e)
        {
            ADMIN_SHOP adminShop = new ADMIN_SHOP();
            this.Hide();
            adminShop.Show();
        }

        private void ADD_NEWS_textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic to validate or modify the text as the user types
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADMIN_NEWS_Load_1(object sender, EventArgs e)
        {

        }
    }
}
