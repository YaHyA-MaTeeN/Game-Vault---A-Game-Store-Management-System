using System;
using System.Windows.Forms;
namespace SE_PROJ_IDK_1._1
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            this.Hide();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FACEBOOK_SIGN_UP fACEBOOK = new FACEBOOK_SIGN_UP();
            this.Hide();
            fACEBOOK.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SIGN_UP signup = new SIGN_UP();
            this.Hide();
            signup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GOOGLE_SIGN_UP google = new GOOGLE_SIGN_UP();
            this.Hide(); google.Show();
        }
    }
}
