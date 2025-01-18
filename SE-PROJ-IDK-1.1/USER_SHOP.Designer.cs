namespace SE_PROJ_IDK_1._1
{
    partial class USER_SHOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_SHOP));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.freepik__candid_image_photography_natural_textures_highly_r__532513;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 7;
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
            button2.BackColor = SystemColors.Menu;
            button2.BackgroundImage = Properties.Resources.BLUE;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(30, 497);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "help";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.freepik__adjust__96547__1_;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(853, 9);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 4;
            button3.Text = "NEWS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(853, 63);
            button4.Name = "button4";
            button4.Size = new Size(75, 41);
            button4.TabIndex = 5;
            button4.Text = "LIBRARY";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.0731716F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.92683F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.Location = new Point(29, 184);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(882, 307);
            tableLayoutPanel1.TabIndex = 6;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.GOLD;
            label1.Location = new Point(29, 135);
            label1.Name = "label1";
            label1.Size = new Size(112, 34);
            label1.TabIndex = 8;
            label1.Text = "EXPLORE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // USER_SHOP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__expand__916275;
            ClientSize = new Size(941, 551);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "USER_SHOP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "USER_SHOP";
            Load += USER_SHOP_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}