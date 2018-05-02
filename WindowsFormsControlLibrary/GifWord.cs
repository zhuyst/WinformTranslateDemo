using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class GifWord : Label
    {
        public string Word { get; set; }
        public GifWord()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (string.IsNullOrEmpty(Word)) return;
            var font = new Font("黑体", 12);
            var brush = Brushes.Black;
            var pos = new PointF(0, 0);
            e.Graphics.DrawString(Word, font, brush, pos);
        }
    }
}
