using System;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class LoginForm : Form
    {
        private readonly string _rightUsername;

        private readonly string _rightPassword;

        private readonly SuccessHandler _successHandler;

        public delegate void SuccessHandler();

        public LoginForm(string username,string password,SuccessHandler successHandler)
        {
            InitializeComponent();
            _rightUsername = username;
            _rightPassword = password;
            _successHandler = successHandler;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == _rightUsername && passwordTextBox.Text == _rightPassword)
            {
                Hide();
                _successHandler.Invoke();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK);
            }
        }
    }
}
