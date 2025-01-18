namespace SE_PROJ_IDK_1._1
{
    partial class USER_NEWS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_NEWS));
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
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.BLUE;
            button2.Location = new Point(36, 505);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "help";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(854, 63);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 4;
            button3.Text = "SHOP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(853, 9);
            button4.Name = "button4";
            button4.Size = new Size(75, 41);
            button4.TabIndex = 5;
            button4.Text = "LIBRARY";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources._3;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9156914F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.08431F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            tableLayoutPanel1.Location = new Point(36, 166);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(875, 333);
            tableLayoutPanel1.TabIndex = 6;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.GOLD;
            label1.Location = new Point(36, 121);
            label1.Name = "label1";
            label1.Size = new Size(127, 42);
            label1.TabIndex = 7;
            label1.Text = "TRENDING";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // USER_NEWS
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
            Name = "USER_NEWS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "USER_NEWS";
            Load += USER_NEWS_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}