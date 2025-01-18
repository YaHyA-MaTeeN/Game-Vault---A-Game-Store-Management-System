namespace SE_PROJ_IDK_1._1
{
    partial class SIGN_UP
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            name = new TextBox();
            password = new TextBox();
            email = new TextBox();
            age = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            help = new Button();
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
            pictureBox1.BackgroundImage = Properties.Resources.game_vault;
            pictureBox1.Location = new Point(130, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(781, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // name
            // 
            name.Location = new Point(434, 203);
            name.Name = "name";
            name.Size = new Size(181, 23);
            name.TabIndex = 2;
            name.TextChanged += name_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(434, 258);
            password.Name = "password";
            password.Size = new Size(181, 23);
            password.TabIndex = 3;
            // 
            // email
            // 
            email.Location = new Point(434, 309);
            email.Name = "email";
            email.Size = new Size(181, 23);
            email.TabIndex = 4;
            // 
            // age
            // 
            age.Location = new Point(434, 373);
            age.Name = "age";
            age.Size = new Size(181, 23);
            age.TabIndex = 5;
            age.TextChanged += age_TextChanged;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.SILVER;
            label1.Location = new Point(312, 204);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 6;
            label1.Text = "name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.SILVER;
            label2.Location = new Point(312, 258);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 7;
            label2.Text = "password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.SILVER;
            label3.Location = new Point(312, 309);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 8;
            label3.Text = "email";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.SILVER;
            label4.Location = new Point(312, 373);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 9;
            label4.Text = "age";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.GOLD;
            button2.Location = new Point(475, 427);
            button2.Name = "button2";
            button2.Size = new Size(93, 28);
            button2.TabIndex = 10;
            button2.Text = "sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // help
            // 
            help.Location = new Point(12, 516);
            help.Name = "help";
            help.Size = new Size(75, 23);
            help.TabIndex = 11;
            help.Text = "HELP";
            help.UseVisualStyleBackColor = true;
            help.Click += help_Click;
            // 
            // SIGN_UP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__expand__916272;
            ClientSize = new Size(941, 551);
            Controls.Add(help);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(age);
            Controls.Add(email);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SIGN_UP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGN_UP";
            Load += SIGN_UP_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox name;
        private TextBox password;
        private TextBox email;
        private TextBox age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button help;
    }
}