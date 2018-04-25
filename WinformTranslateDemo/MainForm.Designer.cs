namespace WinformTranslateDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label1;
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.sound = new System.Windows.Forms.PictureBox();
            this.pho1 = new System.Windows.Forms.Label();
            this.pho2 = new System.Windows.Forms.Label();
            this.meansList = new WindowsFormsControlLibrary.MyLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ex1 = new WindowsFormsControlLibrary.MyLabel();
            this.ex1Sound = new System.Windows.Forms.PictureBox();
            this.ex2 = new WindowsFormsControlLibrary.MyLabel();
            this.ex2Sound = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.word = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ex1Sound)).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ex2Sound)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox1.Controls.Add(this.wordListBox);
            groupBox1.Location = new System.Drawing.Point(10, 10);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(236, 473);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "单词列表";
            // 
            // wordListBox
            // 
            this.wordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.wordListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 12;
            this.wordListBox.Location = new System.Drawing.Point(5, 19);
            this.wordListBox.Margin = new System.Windows.Forms.Padding(2);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(228, 448);
            this.wordListBox.TabIndex = 0;
            this.wordListBox.SelectedIndexChanged += new System.EventHandler(this.wordListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(304, 10);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(660, 473);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "翻译结果";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(this.meansList);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(this.panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(5, 19);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            flowLayoutPanel1.Size = new System.Drawing.Size(651, 449);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.word);
            this.flowLayoutPanel4.Controls.Add(this.sound);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(14, 14);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(618, 42);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.SystemColors.Window;
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.sound.Location = new System.Drawing.Point(71, 4);
            this.sound.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.sound.Name = "sound";
            this.sound.Padding = new System.Windows.Forms.Padding(6);
            this.sound.Size = new System.Drawing.Size(28, 33);
            this.sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sound.TabIndex = 7;
            this.sound.TabStop = false;
            this.sound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sound_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(this.pho1);
            flowLayoutPanel2.Controls.Add(this.pho2);
            flowLayoutPanel2.Location = new System.Drawing.Point(14, 60);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(618, 34);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // pho1
            // 
            this.pho1.AutoSize = true;
            this.pho1.Location = new System.Drawing.Point(4, 4);
            this.pho1.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.pho1.Name = "pho1";
            this.pho1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.pho1.Size = new System.Drawing.Size(41, 24);
            this.pho1.TabIndex = 2;
            this.pho1.Text = "音标1";
            // 
            // pho2
            // 
            this.pho2.AutoSize = true;
            this.pho2.Location = new System.Drawing.Point(53, 4);
            this.pho2.Margin = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.pho2.Name = "pho2";
            this.pho2.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.pho2.Size = new System.Drawing.Size(41, 24);
            this.pho2.TabIndex = 3;
            this.pho2.Text = "音标2";
            // 
            // meansList
            // 
            this.meansList.AutoSize = true;
            this.meansList.Location = new System.Drawing.Point(16, 100);
            this.meansList.Margin = new System.Windows.Forms.Padding(4);
            this.meansList.Name = "meansList";
            this.meansList.Padding = new System.Windows.Forms.Padding(6);
            this.meansList.Size = new System.Drawing.Size(65, 24);
            this.meansList.TabIndex = 5;
            this.meansList.Text = "词义分析";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(16, 144);
            label6.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            label6.Name = "label6";
            label6.Padding = new System.Windows.Forms.Padding(6);
            label6.Size = new System.Drawing.Size(43, 24);
            label6.TabIndex = 3;
            label6.Text = "例句";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label7.Location = new System.Drawing.Point(15, 172);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(616, 2);
            label7.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ex1);
            this.panel1.Controls.Add(this.ex1Sound);
            this.panel1.Location = new System.Drawing.Point(14, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 114);
            this.panel1.TabIndex = 8;
            // 
            // ex1
            // 
            this.ex1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ex1.BackColor = System.Drawing.SystemColors.Window;
            this.ex1.Location = new System.Drawing.Point(34, 4);
            this.ex1.Margin = new System.Windows.Forms.Padding(4);
            this.ex1.Name = "ex1";
            this.ex1.Padding = new System.Windows.Forms.Padding(6);
            this.ex1.Size = new System.Drawing.Size(580, 106);
            this.ex1.TabIndex = 6;
            this.ex1.Text = "例句1";
            // 
            // ex1Sound
            // 
            this.ex1Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ex1Sound.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.ex1Sound.Location = new System.Drawing.Point(4, 2);
            this.ex1Sound.Margin = new System.Windows.Forms.Padding(2);
            this.ex1Sound.Name = "ex1Sound";
            this.ex1Sound.Size = new System.Drawing.Size(23, 26);
            this.ex1Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ex1Sound.TabIndex = 5;
            this.ex1Sound.TabStop = false;
            this.ex1Sound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ex1Sound_MouseClick);
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(this.ex2);
            panel2.Controls.Add(this.ex2Sound);
            panel2.Location = new System.Drawing.Point(14, 294);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(618, 120);
            panel2.TabIndex = 9;
            // 
            // ex2
            // 
            this.ex2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ex2.Location = new System.Drawing.Point(34, 4);
            this.ex2.Margin = new System.Windows.Forms.Padding(4);
            this.ex2.Name = "ex2";
            this.ex2.Padding = new System.Windows.Forms.Padding(6);
            this.ex2.Size = new System.Drawing.Size(580, 112);
            this.ex2.TabIndex = 6;
            this.ex2.Text = "例句2";
            // 
            // ex2Sound
            // 
            this.ex2Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ex2Sound.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.ex2Sound.Location = new System.Drawing.Point(4, 2);
            this.ex2Sound.Margin = new System.Windows.Forms.Padding(2);
            this.ex2Sound.Name = "ex2Sound";
            this.ex2Sound.Size = new System.Drawing.Size(23, 26);
            this.ex2Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ex2Sound.TabIndex = 5;
            this.ex2Sound.TabStop = false;
            this.ex2Sound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ex2Sound_MouseClick);
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(266, 212);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 12);
            label1.TabIndex = 4;
            label1.Text = "->";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.word.Location = new System.Drawing.Point(4, 4);
            this.word.Margin = new System.Windows.Forms.Padding(4);
            this.word.Name = "word";
            this.word.Padding = new System.Windows.Forms.Padding(6);
            this.word.Size = new System.Drawing.Size(63, 32);
            this.word.TabIndex = 0;
            this.word.Text = "单词";
            this.word.Paint += new System.Windows.Forms.PaintEventHandler(this.word_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(974, 492);
            this.Controls.Add(label1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "翻译";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ex1Sound)).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ex2Sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pho1;
        private WindowsFormsControlLibrary.MyLabel meansList;
        private System.Windows.Forms.PictureBox ex1Sound;
        private WindowsFormsControlLibrary.MyLabel ex1;
        private System.Windows.Forms.Label pho2;
        private System.Windows.Forms.PictureBox sound;
        private WindowsFormsControlLibrary.MyLabel ex2;
        private System.Windows.Forms.PictureBox ex2Sound;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label word;
    }
}