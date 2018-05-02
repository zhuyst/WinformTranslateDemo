using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class GifWord : Label
    {
        public string word { get; set; }
        public GifWord()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (string.IsNullOrEmpty(word)) return;

            Font font = new System.Drawing.Font("黑体", 12);

            Brush brush = Brushes.Black;

            PointF pos = new PointF(0, 0);

            e.Graphics.DrawString(

                word,

                font,

                brush,

                pos);
        }
    }
}
