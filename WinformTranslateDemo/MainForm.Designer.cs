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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label1;
            this.wordListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.Controls.Add(this.wordListView);
            groupBox1.Location = new System.Drawing.Point(9, 10);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Size = new System.Drawing.Size(221, 434);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "单词列表";
            // 
            // wordListView
            // 
            this.wordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1});
            this.wordListView.Location = new System.Drawing.Point(5, 20);
            this.wordListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wordListView.MultiSelect = false;
            this.wordListView.Name = "wordListView";
            this.wordListView.Size = new System.Drawing.Size(212, 410);
            this.wordListView.TabIndex = 0;
            this.wordListView.UseCompatibleStateImageBehavior = false;
            this.wordListView.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 80;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(309, 10);
            groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox2.Size = new System.Drawing.Size(490, 434);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "翻译结果";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            flowLayoutPanel1.Controls.Add(this.label2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(this.label5);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            flowLayoutPanel1.Size = new System.Drawing.Size(482, 410);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nice";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(this.label3);
            flowLayoutPanel2.Controls.Add(this.pictureBox1);
            flowLayoutPanel2.Controls.Add(this.label4);
            flowLayoutPanel2.Location = new System.Drawing.Point(13, 54);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(452, 30);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "美 [naɪs]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(77, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "英 [naɪs]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label5.Size = new System.Drawing.Size(389, 48);
            this.label5.TabIndex = 2;
            this.label5.Text = "n.尼斯\r\n\r\nadj.令人愉快的；宜人的；吸引人的；用于形容词或副词前以加强语气";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(15, 158);
            label6.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            label6.Name = "label6";
            label6.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label6.Size = new System.Drawing.Size(43, 24);
            label6.TabIndex = 3;
            label6.Text = "例句";
            // 
            // label7
            // 
            label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label7.Location = new System.Drawing.Point(13, 186);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(452, 2);
            label7.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(261, 213);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 12);
            label1.TabIndex = 4;
            label1.Text = "->";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 454);
            this.Controls.Add(label1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView wordListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}