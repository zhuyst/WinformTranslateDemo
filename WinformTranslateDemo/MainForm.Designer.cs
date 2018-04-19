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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label1;
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.word = new System.Windows.Forms.Label();
            this.sound = new System.Windows.Forms.PictureBox();
            this.pho1 = new System.Windows.Forms.Label();
            this.pho2 = new System.Windows.Forms.Label();
            this.meansList = new WindowsFormsControlLibrary.MyLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ex1 = new WindowsFormsControlLibrary.MyLabel();
            this.ex1Sound = new System.Windows.Forms.PictureBox();
            this.ex2 = new WindowsFormsControlLibrary.MyLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wordListView = new System.Windows.Forms.ListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox1.Controls.Add(this.wordListView);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(295, 591);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "单词列表";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(380, 12);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(825, 591);
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
            flowLayoutPanel1.Location = new System.Drawing.Point(6, 24);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            flowLayoutPanel1.Size = new System.Drawing.Size(813, 561);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.word);
            this.flowLayoutPanel4.Controls.Add(this.sound);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(17, 17);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(772, 52);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.word.Location = new System.Drawing.Point(5, 5);
            this.word.Margin = new System.Windows.Forms.Padding(5);
            this.word.Name = "word";
            this.word.Padding = new System.Windows.Forms.Padding(8);
            this.word.Size = new System.Drawing.Size(80, 41);
            this.word.TabIndex = 0;
            this.word.Text = "单词";
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.SystemColors.Window;
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.sound.Location = new System.Drawing.Point(90, 5);
            this.sound.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.sound.Name = "sound";
            this.sound.Padding = new System.Windows.Forms.Padding(8);
            this.sound.Size = new System.Drawing.Size(35, 41);
            this.sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sound.TabIndex = 7;
            this.sound.TabStop = false;
            this.sound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sound_MouseDown);
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(this.pho1);
            flowLayoutPanel2.Controls.Add(this.pho2);
            flowLayoutPanel2.Location = new System.Drawing.Point(17, 73);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(772, 42);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // pho1
            // 
            this.pho1.AutoSize = true;
            this.pho1.Location = new System.Drawing.Point(5, 5);
            this.pho1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.pho1.Name = "pho1";
            this.pho1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pho1.Size = new System.Drawing.Size(53, 31);
            this.pho1.TabIndex = 2;
            this.pho1.Text = "音标1";
            // 
            // pho2
            // 
            this.pho2.AutoSize = true;
            this.pho2.Location = new System.Drawing.Point(68, 5);
            this.pho2.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.pho2.Name = "pho2";
            this.pho2.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pho2.Size = new System.Drawing.Size(53, 31);
            this.pho2.TabIndex = 3;
            this.pho2.Text = "音标2";
            // 
            // meansList
            // 
            this.meansList.AutoSize = true;
            this.meansList.Location = new System.Drawing.Point(20, 122);
            this.meansList.Margin = new System.Windows.Forms.Padding(5);
            this.meansList.Name = "meansList";
            this.meansList.Padding = new System.Windows.Forms.Padding(8);
            this.meansList.Size = new System.Drawing.Size(83, 31);
            this.meansList.TabIndex = 5;
            this.meansList.Text = "词义分析";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(20, 178);
            label6.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            label6.Name = "label6";
            label6.Padding = new System.Windows.Forms.Padding(8);
            label6.Size = new System.Drawing.Size(55, 31);
            label6.TabIndex = 3;
            label6.Text = "例句";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label7.Location = new System.Drawing.Point(18, 214);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(770, 2);
            label7.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ex1);
            this.panel1.Controls.Add(this.ex1Sound);
            this.panel1.Location = new System.Drawing.Point(17, 218);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 142);
            this.panel1.TabIndex = 8;
            // 
            // ex1
            // 
            this.ex1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ex1.BackColor = System.Drawing.SystemColors.Window;
            this.ex1.Location = new System.Drawing.Point(42, 5);
            this.ex1.Margin = new System.Windows.Forms.Padding(5);
            this.ex1.Name = "ex1";
            this.ex1.Padding = new System.Windows.Forms.Padding(8);
            this.ex1.Size = new System.Drawing.Size(725, 132);
            this.ex1.TabIndex = 6;
            this.ex1.Text = "例句1";
            // 
            // ex1Sound
            // 
            this.ex1Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ex1Sound.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.ex1Sound.Location = new System.Drawing.Point(5, 2);
            this.ex1Sound.Margin = new System.Windows.Forms.Padding(2);
            this.ex1Sound.Name = "ex1Sound";
            this.ex1Sound.Size = new System.Drawing.Size(29, 32);
            this.ex1Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ex1Sound.TabIndex = 5;
            this.ex1Sound.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(this.ex2);
            panel2.Controls.Add(this.pictureBox1);
            panel2.Location = new System.Drawing.Point(17, 364);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(772, 150);
            panel2.TabIndex = 9;
            // 
            // ex2
            // 
            this.ex2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ex2.Location = new System.Drawing.Point(42, 5);
            this.ex2.Margin = new System.Windows.Forms.Padding(5);
            this.ex2.Name = "ex2";
            this.ex2.Padding = new System.Windows.Forms.Padding(8);
            this.ex2.Size = new System.Drawing.Size(725, 140);
            this.ex2.TabIndex = 6;
            this.ex2.Text = "例句2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(332, 265);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "->";
            // 
            // wordListView
            // 
            this.wordListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordListView.FormattingEnabled = true;
            this.wordListView.ItemHeight = 15;
            this.wordListView.Location = new System.Drawing.Point(6, 24);
            this.wordListView.Name = "wordListView";
            this.wordListView.Size = new System.Drawing.Size(284, 559);
            this.wordListView.TabIndex = 0;
            this.wordListView.SelectedIndexChanged += new System.EventHandler(this.wordListView_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1218, 615);
            this.Controls.Add(label1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label pho1;
        private WindowsFormsControlLibrary.MyLabel meansList;
        private System.Windows.Forms.PictureBox ex1Sound;
        private WindowsFormsControlLibrary.MyLabel ex1;
        private System.Windows.Forms.Label pho2;
        private System.Windows.Forms.PictureBox sound;
        private WindowsFormsControlLibrary.MyLabel ex2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ListBox wordListView;
    }
}