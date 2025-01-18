namespace SE_PROJ_IDK_1._1
{
    partial class ADMIN_USERINFO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_USERINFO));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            SHOP_PAGE_BUTTON = new Button();
            ADMIN_NEWS_PAGE_BUTTON = new Button();
            USERS_tableLayoutPanel1 = new TableLayoutPanel();
            PURCHASES_tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TOTAL_PROFIT_tableLayoutPanel1 = new TableLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.freepik__candid_image_photography_natural_textures_highly_r__532513;
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(130, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(717, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // SHOP_PAGE_BUTTON
            // 
            SHOP_PAGE_BUTTON.BackgroundImage = (Image)resources.GetObject("SHOP_PAGE_BUTTON.BackgroundImage");
            SHOP_PAGE_BUTTON.FlatStyle = FlatStyle.Popup;
            SHOP_PAGE_BUTTON.Location = new Point(854, 63);
            SHOP_PAGE_BUTTON.Name = "SHOP_PAGE_BUTTON";
            SHOP_PAGE_BUTTON.Size = new Size(75, 41);
            SHOP_PAGE_BUTTON.TabIndex = 3;
            SHOP_PAGE_BUTTON.Text = "SHOP";
            SHOP_PAGE_BUTTON.UseVisualStyleBackColor = true;
            SHOP_PAGE_BUTTON.Click += SHOP_PAGE_BUTTON_Click;
            // 
            // ADMIN_NEWS_PAGE_BUTTON
            // 
            ADMIN_NEWS_PAGE_BUTTON.AutoEllipsis = true;
            ADMIN_NEWS_PAGE_BUTTON.BackColor = SystemColors.ActiveCaption;
            ADMIN_NEWS_PAGE_BUTTON.BackgroundImage = (Image)resources.GetObject("ADMIN_NEWS_PAGE_BUTTON.BackgroundImage");
            ADMIN_NEWS_PAGE_BUTTON.Cursor = Cursors.Hand;
            ADMIN_NEWS_PAGE_BUTTON.FlatStyle = FlatStyle.Popup;
            ADMIN_NEWS_PAGE_BUTTON.Location = new Point(853, 9);
            ADMIN_NEWS_PAGE_BUTTON.Name = "ADMIN_NEWS_PAGE_BUTTON";
            ADMIN_NEWS_PAGE_BUTTON.Size = new Size(74, 41);
            ADMIN_NEWS_PAGE_BUTTON.TabIndex = 4;
            ADMIN_NEWS_PAGE_BUTTON.Text = "NEWS";
            ADMIN_NEWS_PAGE_BUTTON.UseVisualStyleBackColor = true;
            ADMIN_NEWS_PAGE_BUTTON.Click += ADMIN_NEWS_PAGE_BUTTON_Click;
            // 
            // USERS_tableLayoutPanel1
            // 
            USERS_tableLayoutPanel1.BackgroundImage = Properties.Resources._3;
            USERS_tableLayoutPanel1.ColumnCount = 3;
            USERS_tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            USERS_tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            USERS_tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            USERS_tableLayoutPanel1.Location = new Point(12, 201);
            USERS_tableLayoutPanel1.Name = "USERS_tableLayoutPanel1";
            USERS_tableLayoutPanel1.RowCount = 2;
            USERS_tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            USERS_tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            USERS_tableLayoutPanel1.Size = new Size(321, 328);
            USERS_tableLayoutPanel1.TabIndex = 5;
            // 
            // PURCHASES_tableLayoutPanel2
            // 
            PURCHASES_tableLayoutPanel2.BackgroundImage = Properties.Resources._3;
            PURCHASES_tableLayoutPanel2.ColumnCount = 3;
            PURCHASES_tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PURCHASES_tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            PURCHASES_tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            PURCHASES_tableLayoutPanel2.Location = new Point(378, 201);
            PURCHASES_tableLayoutPanel2.Name = "PURCHASES_tableLayoutPanel2";
            PURCHASES_tableLayoutPanel2.RowCount = 2;
            PURCHASES_tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PURCHASES_tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PURCHASES_tableLayoutPanel2.Size = new Size(372, 328);
            PURCHASES_tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(10, 154);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 7;
            label1.Text = "USERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(378, 154);
            label2.Name = "label2";
            label2.Size = new Size(91, 29);
            label2.TabIndex = 8;
            label2.Text = "PURCHASES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(791, 154);
            label3.Name = "label3";
            label3.Size = new Size(91, 29);
            label3.TabIndex = 9;
            label3.Text = "PROFIT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TOTAL_PROFIT_tableLayoutPanel1
            // 
            TOTAL_PROFIT_tableLayoutPanel1.ColumnCount = 1;
            TOTAL_PROFIT_tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TOTAL_PROFIT_tableLayoutPanel1.Location = new Point(791, 201);
            TOTAL_PROFIT_tableLayoutPanel1.Name = "TOTAL_PROFIT_tableLayoutPanel1";
            TOTAL_PROFIT_tableLayoutPanel1.RowCount = 2;
            TOTAL_PROFIT_tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TOTAL_PROFIT_tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TOTAL_PROFIT_tableLayoutPanel1.Size = new Size(121, 42);
            TOTAL_PROFIT_tableLayoutPanel1.TabIndex = 10;
            TOTAL_PROFIT_tableLayoutPanel1.Paint += TOTAL_PROFIT_tableLayoutPanel1_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ADMIN_USERINFO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__expand__916275;
            ClientSize = new Size(941, 551);
            Controls.Add(TOTAL_PROFIT_tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PURCHASES_tableLayoutPanel2);
            Controls.Add(USERS_tableLayoutPanel1);
            Controls.Add(ADMIN_NEWS_PAGE_BUTTON);
            Controls.Add(SHOP_PAGE_BUTTON);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ADMIN_USERINFO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN_USERINFO";
            Load += ADMIN_USERINFO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button SHOP_PAGE_BUTTON;
        private Button ADMIN_NEWS_PAGE_BUTTON;
        private TableLayoutPanel USERS_tableLayoutPanel1;
        private TableLayoutPanel PURCHASES_tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel TOTAL_PROFIT_tableLayoutPanel1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}