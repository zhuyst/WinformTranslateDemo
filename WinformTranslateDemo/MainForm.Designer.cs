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
            System.Windows.Forms.Label label1;
            this.wordListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.word = new System.Windows.Forms.Label();
            this.pho1 = new System.Windows.Forms.Label();
            this.pho2 = new System.Windows.Forms.Label();
            this.means = new System.Windows.Forms.Label();
            this.sound1 = new System.Windows.Forms.PictureBox();
            this.sound2 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.Controls.Add(this.wordListView);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(295, 543);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "单词列表";
            // 
            // wordListView
            // 
            this.wordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.wordListView.Location = new System.Drawing.Point(7, 25);
            this.wordListView.MultiSelect = false;
            this.wordListView.Name = "wordListView";
            this.wordListView.Size = new System.Drawing.Size(282, 512);
            this.wordListView.TabIndex = 0;
            this.wordListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(385, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(681, 543);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "翻译结果";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(this.word);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(this.means);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(6, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            flowLayoutPanel1.Size = new System.Drawing.Size(669, 513);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.word.Location = new System.Drawing.Point(20, 20);
            this.word.Margin = new System.Windows.Forms.Padding(5);
            this.word.Name = "word";
            this.word.Padding = new System.Windows.Forms.Padding(8);
            this.word.Size = new System.Drawing.Size(84, 41);
            this.word.TabIndex = 0;
            this.word.Text = "Nice";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(this.pho1);
            flowLayoutPanel2.Controls.Add(this.sound1);
            flowLayoutPanel2.Controls.Add(this.pho2);
            flowLayoutPanel2.Controls.Add(this.sound2);
            flowLayoutPanel2.Location = new System.Drawing.Point(18, 69);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(628, 42);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // pho1
            // 
            this.pho1.AutoSize = true;
            this.pho1.Location = new System.Drawing.Point(5, 5);
            this.pho1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.pho1.Name = "pho1";
            this.pho1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pho1.Size = new System.Drawing.Size(80, 31);
            this.pho1.TabIndex = 2;
            this.pho1.Text = "美 [naɪs]";
            // 
            // pho2
            // 
            this.pho2.AutoSize = true;
            this.pho2.Location = new System.Drawing.Point(130, 5);
            this.pho2.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.pho2.Name = "pho2";
            this.pho2.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.pho2.Size = new System.Drawing.Size(80, 31);
            this.pho2.TabIndex = 3;
            this.pho2.Text = "英 [naɪs]";
            // 
            // means
            // 
            this.means.AutoSize = true;
            this.means.Location = new System.Drawing.Point(20, 119);
            this.means.Margin = new System.Windows.Forms.Padding(5);
            this.means.Name = "means";
            this.means.Padding = new System.Windows.Forms.Padding(8);
            this.means.Size = new System.Drawing.Size(490, 61);
            this.means.TabIndex = 2;
            this.means.Text = "n.尼斯\r\n\r\nadj.令人愉快的；宜人的；吸引人的；用于形容词或副词前以加强语气";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(20, 205);
            label6.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            label6.Name = "label6";
            label6.Padding = new System.Windows.Forms.Padding(8);
            label6.Size = new System.Drawing.Size(55, 31);
            label6.TabIndex = 3;
            label6.Text = "例句";
            // 
            // label7
            // 
            label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label7.Location = new System.Drawing.Point(18, 241);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(626, 2);
            label7.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(332, 265);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "->";
            // 
            // sound1
            // 
            this.sound1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound1.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.sound1.Location = new System.Drawing.Point(88, 3);
            this.sound1.Name = "sound1";
            this.sound1.Size = new System.Drawing.Size(29, 33);
            this.sound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sound1.TabIndex = 5;
            this.sound1.TabStop = false;
            // 
            // sound2
            // 
            this.sound2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound2.Image = global::WinformTranslateDemo.Properties.Resources.sound;
            this.sound2.Location = new System.Drawing.Point(213, 3);
            this.sound2.Name = "sound2";
            this.sound2.Size = new System.Drawing.Size(29, 33);
            this.sound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sound2.TabIndex = 6;
            this.sound2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 567);
            this.Controls.Add(label1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView wordListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label pho1;
        private System.Windows.Forms.Label pho2;
        private System.Windows.Forms.Label means;
        private System.Windows.Forms.PictureBox sound1;
        private System.Windows.Forms.PictureBox sound2;
    }
}