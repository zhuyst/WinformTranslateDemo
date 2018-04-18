using System;
using System.Windows.Forms;

namespace WinformTranslateDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "root" && passwordTextBox.Text == "123456")
            {
                new MainForm {StartPosition = FormStartPosition.CenterParent}.ShowDialog();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK);
            }
        }
    }
}
