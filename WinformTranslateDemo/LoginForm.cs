using System;
using System.Windows.Forms;

namespace WinformTranslateDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginControl.RightUsername = "root";
            loginControl.RightPassword = "123456";
            loginControl.successHandler = () =>
            {
                Hide();
                new MainForm().Show();
            };
        }
    }
}
