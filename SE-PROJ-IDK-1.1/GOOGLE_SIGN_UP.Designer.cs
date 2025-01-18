namespace SE_PROJ_IDK_1._1
{
    partial class GOOGLE_SIGN_UP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GOOGLE_SIGN_UP));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            age = new TextBox();
            email = new TextBox();
            password = new TextBox();
            name = new TextBox();
            button3 = new Button();
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
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(486, 422);
            button2.Name = "button2";
            button2.Size = new Size(86, 32);
            button2.TabIndex = 19;
            button2.Text = "sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(303, 358);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 18;
            label4.Text = "age";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(303, 294);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 17;
            label3.Text = "email";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(303, 243);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 16;
            label2.Text = "password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(303, 191);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 15;
            label1.Text = "name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // age
            // 
            age.Location = new Point(442, 359);
            age.Name = "age";
            age.Size = new Size(181, 23);
            age.TabIndex = 14;
            // 
            // email
            // 
            email.Location = new Point(442, 295);
            email.Name = "email";
            email.Size = new Size(181, 23);
            email.TabIndex = 13;
            // 
            // password
            // 
            password.Location = new Point(442, 244);
            password.Name = "password";
            password.Size = new Size(181, 23);
            password.TabIndex = 12;
            // 
            // name
            // 
            name.Location = new Point(442, 192);
            name.Name = "name";
            name.Size = new Size(181, 23);
            name.TabIndex = 11;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(27, 504);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 20;
            button3.Text = "HELP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GOOGLE_SIGN_UP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__expand__916275;
            ClientSize = new Size(941, 551);
            Controls.Add(button3);
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
            Name = "GOOGLE_SIGN_UP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GOOGLE_SIGN_UP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox age;
        private TextBox email;
        private TextBox password;
        private TextBox name;
        private Button button3;
    }
}