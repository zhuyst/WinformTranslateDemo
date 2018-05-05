using System;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class LoginControl : UserControl
    {

        public LoginControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 正确的用户名
        /// </summary>
        public string RightUsername { get; set; }

        /// <summary>
        /// 正确的密码
        /// </summary>
        public string RightPassword { get; set; }

        /// <summary>
        /// 正确时执行的方法
        /// </summary>
        public event SuccessHandler SuccessHandlerEvent;

        /// <summary>
        /// 定义正确时执行的方法（委托）
        /// </summary>
        public delegate void SuccessHandler();

        private void loginButton_Click(object sender, EventArgs e)
        {
            //if (usernameTextBox.Text == RightUsername && passwordTextBox.Text == RightPassword)
            //{
                SuccessHandlerEvent?.Invoke();
            //}
            //else
            //{
            //    MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK);
            //}
        }
    }
}
