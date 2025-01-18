using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SE_PROJ_IDK_1._1
{
    public partial class USER_NEWS : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["GameVaultDB"].ConnectionString;

        private int _userId;
        public USER_NEWS(int userId)
        {
            InitializeComponent();
            _userId = userId;
            tableLayoutPanel1.AutoScroll = true; // Enable scrolling for the table
            this.Load += new EventHandler(this.USER_NEWS_Load); // Ensure the Load event is properly wired
        }

        // Event: Form Load - Display all news
        private void USER_NEWS_Load(object sender, EventArgs e)
        {
            LoadNews();
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

        // Navigation buttons
        private void button1_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            USER_LIBRARY uSER_LIBRARY = new USER_LIBRARY(_userId);
            this.Hide();
            uSER_LIBRARY.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            USER_SHOP uSER_SHOP = new USER_SHOP(_userId);
            this.Hide();
            uSER_SHOP.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom rendering logic for the table panel
        }
    }
}
