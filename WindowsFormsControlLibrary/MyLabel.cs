using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class MyLabel : Label
    {
        public MyLabel()
        {
            InitializeComponent();
        }

        public void Add(string content)
        {
            Text += $"{content}\r\n\r\n";
        }

        public void Clear()
        {
            Text = string.Empty;
        }
    }
}
