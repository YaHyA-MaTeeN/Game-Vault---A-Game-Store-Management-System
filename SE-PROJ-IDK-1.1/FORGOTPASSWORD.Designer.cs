namespace SE_PROJ_IDK_1._1
{
    partial class FORGOTPASSWORD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORGOTPASSWORD));
            USERNAME_textBox = new TextBox();
            CODE_textBox = new TextBox();
            PASSWORD_textBox = new TextBox();
            CONFIRM_PASSWORD_textBox = new TextBox();
            update_password_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // USERNAME_textBox
            // 
            USERNAME_textBox.Location = new Point(420, 110);
            USERNAME_textBox.Name = "USERNAME_textBox";
            USERNAME_textBox.Size = new Size(207, 23);
            USERNAME_textBox.TabIndex = 0;
            // 
            // CODE_textBox
            // 
            CODE_textBox.Location = new Point(420, 184);
            CODE_textBox.Name = "CODE_textBox";
            CODE_textBox.Size = new Size(207, 23);
            CODE_textBox.TabIndex = 1;
            // 
            // PASSWORD_textBox
            // 
            PASSWORD_textBox.Location = new Point(420, 255);
            PASSWORD_textBox.Name = "PASSWORD_textBox";
            PASSWORD_textBox.Size = new Size(207, 23);
            PASSWORD_textBox.TabIndex = 2;
            // 
            // CONFIRM_PASSWORD_textBox
            // 
            CONFIRM_PASSWORD_textBox.Location = new Point(424, 322);
            CONFIRM_PASSWORD_textBox.Name = "CONFIRM_PASSWORD_textBox";
            CONFIRM_PASSWORD_textBox.Size = new Size(203, 23);
            CONFIRM_PASSWORD_textBox.TabIndex = 3;
            // 
            // update_password_button
            // 
            update_password_button.FlatStyle = FlatStyle.Popup;
            update_password_button.Image = (Image)resources.GetObject("update_password_button.Image");
            update_password_button.Location = new Point(480, 398);
            update_password_button.Name = "update_password_button";
            update_password_button.Size = new Size(88, 40);
            update_password_button.TabIndex = 4;
            update_password_button.Text = "UPDATE PASSWORD";
            update_password_button.UseVisualStyleBackColor = true;
            update_password_button.Click += button1_Click;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(245, 110);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 5;
            label1.Text = "USERNAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(245, 184);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 6;
            label2.Text = "CODE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(245, 254);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 7;
            label3.Text = "PASSWORD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(245, 321);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 8;
            label4.Text = "CONFIRM PASSWORD";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(319, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FORGOTPASSWORD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__expand__916275;
            ClientSize = new Size(941, 551);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(update_password_button);
            Controls.Add(CONFIRM_PASSWORD_textBox);
            Controls.Add(PASSWORD_textBox);
            Controls.Add(CODE_textBox);
            Controls.Add(USERNAME_textBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FORGOTPASSWORD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FORGOTPASSWORD";
            Load += FORGOTPASSWORD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox USERNAME_textBox;
        private TextBox CODE_textBox;
        private TextBox PASSWORD_textBox;
        private TextBox CONFIRM_PASSWORD_textBox;
        private Button update_password_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}