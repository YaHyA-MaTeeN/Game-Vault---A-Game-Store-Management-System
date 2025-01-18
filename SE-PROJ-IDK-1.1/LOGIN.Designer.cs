using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SE_PROJ_IDK_1._1
{
    partial class LOGIN
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

        private void InitializeComponent()
        {
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            pass = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.freepik__candid_image_photography_natural_textures_highly_r__532512;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.game_vault;
            pictureBox1.Location = new Point(146, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(781, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.SILVER;
            label1.Location = new Point(262, 216);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.SILVER;
            label2.Location = new Point(262, 295);
            label2.MaximumSize = new Size(100, 23);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            username.Location = new Point(389, 217);
            username.Name = "username";
            username.Size = new Size(235, 23);
            username.TabIndex = 4;
            username.TextChanged += username_TextChanged;
            // 
            // pass
            // 
            pass.Location = new Point(389, 295);
            pass.Name = "pass";
            pass.Size = new Size(235, 23);
            pass.TabIndex = 5;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.GOLD;
            button2.Location = new Point(453, 405);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 6;
            button2.Text = "LOG IN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.SILVER;
            button3.Location = new Point(501, 351);
            button3.Name = "button3";
            button3.Size = new Size(123, 24);
            button3.TabIndex = 7;
            button3.Text = "forgot password";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = Properties.Resources.BLUE;
            button4.Location = new Point(30, 516);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "HELP";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // LOGIN
            // 
            BackgroundImage = Properties.Resources.freepik__expand__916271;
            ClientSize = new Size(941, 551);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pass);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Cursor = Cursors.PanSW;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LOGIN_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox pass;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}