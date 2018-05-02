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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label1;
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.sound = new System.Windows.Forms.PictureBox();
            this.word = new System.Windows.Forms.Label();
            this.word1 = new WindowsFormsControlLibrary.Word();
            this.pho1 = new System.Windows.Forms.Label();
            this.pho2 = new System.Windows.Forms.Label();
            this.meansList = new WindowsFormsControlLibrary.MyLabel();
            this.exFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox1.Controls.Add(this.wordListBox);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(295, 598);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "单词列表";
            // 
            // wordListBox
            // 
            this.wordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 15;
            this.wordListBox.Location = new System.Drawing.Point(6, 24);
            this.wordListBox.Margin = new System.Windows.Forms.Padding(2);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(284, 559);
            this.wordListBox.TabIndex = 0;
            this.wordListBox.SelectedIndexChanged += new System.EventHandler(this.wordListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(380, 12);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(997, 598);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "翻译结果";
            // 
            // label5
            // 
            label5.Image = global::WinformTranslateDemo.Properties.Resources.QQ图片20180426213350;
            label5.Location = new System.Drawing.Point(832, 464);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(160, 128);
            label5.TabIndex = 7;
            // 
            // label4
            // 
            label4.Image = global::WinformTranslateDemo.Properties.Resources.QQ图片20180426211934;
            label4.Location = new System.Drawing.Point(832, 308);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(160, 128);
            label4.TabIndex = 6;
            // 
            // label3
            // 
            label3.Image = global::WinformTranslateDemo.Properties.Resources.QQ图片20180426211916;
            label3.Location = new System.Drawing.Point(832, 166);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(160, 128);
            label3.TabIndex = 5;
            // 
            // label2
            // 
            label2.Image = global::WinformTranslateDemo.Properties.Resources.QQ图片20180426211853;
            label2.Location = new System.Drawing.Point(832, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(160, 128);
            label2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(this.meansList);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(this.exFlowPanel);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(6, 24);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            flowLayoutPanel1.Size = new System.Drawing.Size(804, 568);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(this.sound);
            flowLayoutPanel4.Controls.Add(this.word);
            flowLayoutPanel4.Controls.Add(this.word1);
            flowLayoutPanel4.Controls.Add(this.button1);
            flowLayoutPanel4.Location = new System.Drawing.Point(17, 17);
            flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(772, 52);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.SystemColors.Window;
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.sound.Location = new System.Drawing.Point(0, 5);
            this.sound.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.sound.Name = "sound";
            this.sound.Padding = new System.Windows.Forms.Padding(8);
            this.sound.Size = new System.Drawing.Size(52, 41);
            this.sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sound.TabIndex = 7;
            this.sound.TabStop = false;
            this.sound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sound_MouseClick);
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.word.Location = new System.Drawing.Point(62, 5);
            this.word.Margin = new System.Windows.Forms.Padding(5);
            this.word.Name = "word";
            this.word.Padding = new System.Windows.Forms.Padding(8);
            this.word.Size = new System.Drawing.Size(80, 41);
            this.word.TabIndex = 0;
            this.word.Text = "单词";
            this.word.Visible = false;
            // 
            // word1
            // 
            this.word1.AutoSize = true;
            this.word1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.word1.BackColor = System.Drawing.Color.Transparent;
            this.word1.Location = new System.Drawing.Point(151, 4);
            this.word1.Margin = new System.Windows.Forms.Padding(4);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(0, 0);
            this.word1.TabIndex = 8;
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
            // exFlowPanel
            // 
            this.exFlowPanel.AutoScroll = true;
            this.exFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.exFlowPanel.Location = new System.Drawing.Point(17, 218);
            this.exFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.exFlowPanel.Name = "exFlowPanel";
            this.exFlowPanel.Size = new System.Drawing.Size(769, 264);
            this.exFlowPanel.TabIndex = 10;
            this.exFlowPanel.WrapContents = false;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(158, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "单选题";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1390, 622);
            this.Controls.Add(label1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label pho1;
        private WindowsFormsControlLibrary.MyLabel meansList;
        private System.Windows.Forms.Label pho2;
        private System.Windows.Forms.PictureBox sound;
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.FlowLayoutPanel exFlowPanel;
        private WindowsFormsControlLibrary.Word word1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}