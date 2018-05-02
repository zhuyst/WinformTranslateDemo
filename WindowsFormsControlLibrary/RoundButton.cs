using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    /// <summary>
    /// https://blog.csdn.net/luzhenyuxfcy/article/details/51966673
    /// </summary>
    public partial class RoundButton : Button
    {
        private int _radius; //半径   

        //圆形按钮的半径属性  
        [Category("布局")]
        [Browsable(true)]
        [ReadOnly(false)]
        public int Radius
        {
            set
            {
                _radius = value;
                Height = Width = Radius;
            }
            get { return _radius; }
        }

        private Image _imageEnter;

        [Category("外观")]
        [Browsable(true)]
        [ReadOnly(false)]
        public Image ImageEnter
        {
            set { _imageEnter = value; }
            get { return _imageEnter; }
        }

        private Image imageNormal;

        [Category("外观")]
        [Browsable(true)]
        [ReadOnly(false)]
        public Image ImageNormal
        {
            set
            {
                imageNormal = value;
                BackgroundImage = imageNormal;
            }
            get { return imageNormal; }
        }

        //以下代码用于在VS中隐藏BackgroundImage属性，使得只能通过Diameter设置Height和Width  
        [Browsable(false)]
        public new Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set { base.BackgroundImage = value; }
        }

        //以下代码用于在VS中隐藏Size属性，使得只能通过Diameter设置Height和Width  
        [Browsable(false)]
        public new Size Size
        {
            get { return base.Size; }
            set { base.Size = value; }
        }

        public RoundButton()
        {
            Radius = 64;
            Height = Width = Radius;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackgroundImage = _imageEnter;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        //重写OnPaint  
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, Radius, Radius);
            Region = new Region(path);
        }

        //重写OnMouseEnter  
        //protected override void OnMouseEnter(EventArgs e)  
        //{  
        //    Graphics g = this.CreateGraphics();  
        //    g.DrawEllipse(new Pen(Color.Blue), 0, 0, this.Width, this.Height);  
        //    g.Dispose();  
        //}  

        //重写OnSizeChanged  
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Height != Radius)
            {
                Radius = Width = Height;
            }
            else if (Width != Radius)
            {
                Radius = Height = Width;
            }
        }

        //重写OnMouseEnter  
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackgroundImage = ImageEnter;
        }

        //重写OnMouseLeave  
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackgroundImage = ImageNormal;
        }
    }
}
