namespace SE_PROJ_IDK_1._1
{
    partial class payment_page
    {
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cardnumber_textBox1 = new TextBox();
            date_issued_textBox2 = new TextBox();
            name_textBox3 = new TextBox();
            pjone_number_textBox4 = new TextBox();
            address_textBox5 = new TextBox();
            CANCEL_BUTTON = new Button();
            CONFIRM_PAYMENT_button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.SILVER;
            label1.Location = new Point(223, 187);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "CARD NUMBER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.SILVER;
            label2.Location = new Point(223, 245);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 1;
            label2.Text = "DATE ISSUED";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.SILVER;
            label3.Location = new Point(223, 127);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 2;
            label3.Text = "NAME";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.SILVER;
            label4.Location = new Point(223, 295);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 3;
            label4.Text = "PHONE NUMBER";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Image = Properties.Resources.SILVER1;
            label5.Location = new Point(223, 342);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 4;
            label5.Text = "ADDRESS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardnumber_textBox1
            // 
            cardnumber_textBox1.Location = new Point(380, 187);
            cardnumber_textBox1.Name = "cardnumber_textBox1";
            cardnumber_textBox1.Size = new Size(271, 23);
            cardnumber_textBox1.TabIndex = 5;
            cardnumber_textBox1.TextChanged += cardnumber_textBox1_TextChanged;
            // 
            // date_issued_textBox2
            // 
            date_issued_textBox2.Location = new Point(380, 246);
            date_issued_textBox2.Name = "date_issued_textBox2";
            date_issued_textBox2.Size = new Size(271, 23);
            date_issued_textBox2.TabIndex = 6;
            // 
            // name_textBox3
            // 
            name_textBox3.Location = new Point(380, 127);
            name_textBox3.Name = "name_textBox3";
            name_textBox3.Size = new Size(271, 23);
            name_textBox3.TabIndex = 7;
            // 
            // pjone_number_textBox4
            // 
            pjone_number_textBox4.Location = new Point(380, 296);
            pjone_number_textBox4.Name = "pjone_number_textBox4";
            pjone_number_textBox4.Size = new Size(271, 23);
            pjone_number_textBox4.TabIndex = 8;
            // 
            // address_textBox5
            // 
            address_textBox5.Location = new Point(380, 343);
            address_textBox5.Name = "address_textBox5";
            address_textBox5.Size = new Size(271, 23);
            address_textBox5.TabIndex = 9;
            address_textBox5.TextChanged += address_textBox5_TextChanged;
            // 
            // CANCEL_BUTTON
            // 
            CANCEL_BUTTON.Location = new Point(552, 413);
            CANCEL_BUTTON.Name = "CANCEL_BUTTON";
            CANCEL_BUTTON.Size = new Size(75, 23);
            CANCEL_BUTTON.TabIndex = 10;
            CANCEL_BUTTON.Text = "CANCEL";
            CANCEL_BUTTON.UseVisualStyleBackColor = true;
            CANCEL_BUTTON.Click += CANCEL_BUTTON_Click;
            // 
            // CONFIRM_PAYMENT_button2
            // 
            CONFIRM_PAYMENT_button2.FlatStyle = FlatStyle.Popup;
            CONFIRM_PAYMENT_button2.Image = Properties.Resources.GOLD;
            CONFIRM_PAYMENT_button2.Location = new Point(411, 402);
            CONFIRM_PAYMENT_button2.Name = "CONFIRM_PAYMENT_button2";
            CONFIRM_PAYMENT_button2.Size = new Size(118, 45);
            CONFIRM_PAYMENT_button2.TabIndex = 11;
            CONFIRM_PAYMENT_button2.Text = "CONFIRM PAYMENT";
            CONFIRM_PAYMENT_button2.UseVisualStyleBackColor = true;
            CONFIRM_PAYMENT_button2.Click += CONFIRM_PAYMENT_button2_Click;
            // 
            // payment_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.freepik__expand__916272;
            ClientSize = new Size(941, 551);
            Controls.Add(CONFIRM_PAYMENT_button2);
            Controls.Add(CANCEL_BUTTON);
            Controls.Add(address_textBox5);
            Controls.Add(pjone_number_textBox4);
            Controls.Add(name_textBox3);
            Controls.Add(date_issued_textBox2);
            Controls.Add(cardnumber_textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "payment_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "payment_page";
            Load += payment_page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cardnumber_textBox1;
        private TextBox date_issued_textBox2;
        private TextBox name_textBox3;
        private TextBox pjone_number_textBox4;
        private TextBox address_textBox5;
        private Button CANCEL_BUTTON;
        private Button CONFIRM_PAYMENT_button2;
    }
}
