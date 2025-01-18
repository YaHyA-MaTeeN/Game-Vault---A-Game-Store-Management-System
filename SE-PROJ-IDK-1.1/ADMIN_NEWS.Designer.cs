namespace SE_PROJ_IDK_1._1
{
    partial class ADMIN_NEWS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_NEWS));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ADD_NEWS_CONTENT_textBox1 = new TextBox();
            REPORT_PAGE_BUTTON = new Button();
            SHOP_PAGE_BUTTON = new Button();
            label2 = new Label();
            label3 = new Label();
            TITLE_textBox1 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.freepik__candid_image_photography_natural_textures_highly_r__532513;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // button2
            // 
            button2.Location = new Point(396, 510);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 3;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources._3;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 593F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.Location = new Point(12, 164);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(917, 259);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.GOLD;
            label1.Location = new Point(16, 437);
            label1.Name = "label1";
            label1.Size = new Size(91, 57);
            label1.TabIndex = 5;
            label1.Text = "NEW NEWS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ADD_NEWS_CONTENT_textBox1
            // 
            ADD_NEWS_CONTENT_textBox1.Location = new Point(472, 471);
            ADD_NEWS_CONTENT_textBox1.Name = "ADD_NEWS_CONTENT_textBox1";
            ADD_NEWS_CONTENT_textBox1.Size = new Size(457, 23);
            ADD_NEWS_CONTENT_textBox1.TabIndex = 6;
            ADD_NEWS_CONTENT_textBox1.TextChanged += ADD_NEWS_textBox1_TextChanged;
            // 
            // REPORT_PAGE_BUTTON
            // 
            REPORT_PAGE_BUTTON.BackgroundImage = (Image)resources.GetObject("REPORT_PAGE_BUTTON.BackgroundImage");
            REPORT_PAGE_BUTTON.FlatStyle = FlatStyle.Popup;
            REPORT_PAGE_BUTTON.Location = new Point(854, 63);
            REPORT_PAGE_BUTTON.Name = "REPORT_PAGE_BUTTON";
            REPORT_PAGE_BUTTON.Size = new Size(75, 41);
            REPORT_PAGE_BUTTON.TabIndex = 7;
            REPORT_PAGE_BUTTON.Text = "REPORT";
            REPORT_PAGE_BUTTON.UseVisualStyleBackColor = true;
            REPORT_PAGE_BUTTON.Click += REPORT_PAGE_BUTTON_Click;
            // 
            // SHOP_PAGE_BUTTON
            // 
            SHOP_PAGE_BUTTON.BackgroundImage = (Image)resources.GetObject("SHOP_PAGE_BUTTON.BackgroundImage");
            SHOP_PAGE_BUTTON.FlatStyle = FlatStyle.Popup;
            SHOP_PAGE_BUTTON.Location = new Point(854, 9);
            SHOP_PAGE_BUTTON.Name = "SHOP_PAGE_BUTTON";
            SHOP_PAGE_BUTTON.Size = new Size(75, 41);
            SHOP_PAGE_BUTTON.TabIndex = 8;
            SHOP_PAGE_BUTTON.Text = "SHOP";
            SHOP_PAGE_BUTTON.UseVisualStyleBackColor = true;
            SHOP_PAGE_BUTTON.Click += SHOP_PAGE_BUTTON_Click;
            // 
            // label2
            // 
            label2.Location = new Point(158, 439);
            label2.Name = "label2";
            label2.Size = new Size(91, 29);
            label2.TabIndex = 9;
            label2.Text = "TITLE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(472, 437);
            label3.Name = "label3";
            label3.Size = new Size(91, 29);
            label3.TabIndex = 10;
            label3.Text = "CONTENT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TITLE_textBox1
            // 
            TITLE_textBox1.Location = new Point(158, 471);
            TITLE_textBox1.Name = "TITLE_textBox1";
            TITLE_textBox1.Size = new Size(177, 23);
            TITLE_textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.BLUE;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(95, 35);
            label4.TabIndex = 12;
            label4.Text = "NEWS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ADMIN_NEWS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__expand__916273;
            ClientSize = new Size(941, 551);
            Controls.Add(label4);
            Controls.Add(TITLE_textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SHOP_PAGE_BUTTON);
            Controls.Add(REPORT_PAGE_BUTTON);
            Controls.Add(ADD_NEWS_CONTENT_textBox1);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ADMIN_NEWS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN_NEWS";
            Load += ADMIN_NEWS_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox ADD_NEWS_CONTENT_textBox1;
        private Button REPORT_PAGE_BUTTON;
        private Button SHOP_PAGE_BUTTON;
        private Label label2;
        private Label label3;
        private TextBox TITLE_textBox1;
        private Label label4;
    }
}