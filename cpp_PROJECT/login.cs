using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpp_PROJECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void close_btn_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (usrnme_txt.Text == "admin" && psswrd_txt.Text == "aituc")
            {
                home h = new home();
                h.Show();
                this.Hide();

            }
            else if (usrnme_txt.Text == "" || psswrd_txt.Text == "")
            {
                MessageBox.Show("enter username and password");

            }
            else {
                MessageBox.Show("wrong username or password");
            }

        }
        private void usrnme_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
