using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class Word : FlowLayoutPanel
    {
        public Word()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 根据传入的单词长度，创建相应数量的label
        /// 一个label一个字母
        /// </summary>
        /// <param name="word"></param>
        public void AddLabel(string word)
        {
            Controls.Clear();
            foreach (var t in word)
            {
                var label = new Label
                {
                    Text = t.ToString(),
                    AutoSize = true,
                    Font = new Font(this.Font.FontFamily, 20)
                };
                //Console.WriteLine(label.Text);
                Controls.Add(label);
            }
        }
    }
}
