namespace WindowsFormsControlLibrary
{
    partial class ExampleSentence
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.engLabel = new System.Windows.Forms.Label();
            this.chnLabel = new System.Windows.Forms.Label();
            this.exSound = new System.Windows.Forms.PictureBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exSound)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(this.engLabel);
            flowLayoutPanel1.Controls.Add(this.chnLabel);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(37, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(700, 114);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.WrapContents = false;
            // 
            // engLabel
            // 
            this.engLabel.AutoSize = true;
            this.engLabel.Location = new System.Drawing.Point(5, 5);
            this.engLabel.Margin = new System.Windows.Forms.Padding(5);
            this.engLabel.Name = "engLabel";
            this.engLabel.Padding = new System.Windows.Forms.Padding(8);
            this.engLabel.Size = new System.Drawing.Size(71, 31);
            this.engLabel.TabIndex = 0;
            this.engLabel.Text = "label1";
            // 
            // chnLabel
            // 
            this.chnLabel.AutoSize = true;
            this.chnLabel.Location = new System.Drawing.Point(5, 46);
            this.chnLabel.Margin = new System.Windows.Forms.Padding(5);
            this.chnLabel.Name = "chnLabel";
            this.chnLabel.Padding = new System.Windows.Forms.Padding(8);
            this.chnLabel.Size = new System.Drawing.Size(71, 31);
            this.chnLabel.TabIndex = 1;
            this.chnLabel.Text = "label1";
            // 
            // exSound
            // 
            this.exSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exSound.Image = global::WindowsFormsControlLibrary.Properties.Resources.sound;
            this.exSound.Location = new System.Drawing.Point(2, 2);
            this.exSound.Margin = new System.Windows.Forms.Padding(2);
            this.exSound.Name = "exSound";
            this.exSound.Size = new System.Drawing.Size(29, 32);
            this.exSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exSound.TabIndex = 6;
            this.exSound.TabStop = false;
            this.exSound.Click += new System.EventHandler(this.exSound_Click);
            // 
            // ExampleSentence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(flowLayoutPanel1);
            this.Controls.Add(this.exSound);
            this.Name = "ExampleSentence";
            this.Size = new System.Drawing.Size(740, 121);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exSound;
        private System.Windows.Forms.Label engLabel;
        private System.Windows.Forms.Label chnLabel;
    }
}
