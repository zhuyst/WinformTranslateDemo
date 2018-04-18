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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.wordListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
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
            groupBox2.Location = new System.Drawing.Point(412, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(654, 543);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "翻译结果";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(348, 266);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "->";
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
            flowLayoutPanel1.Location = new System.Drawing.Point(6, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            flowLayoutPanel1.Size = new System.Drawing.Size(642, 513);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8);
            this.label2.Size = new System.Drawing.Size(84, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nice";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(this.label3);
            flowLayoutPanel2.Controls.Add(this.pictureBox1);
            flowLayoutPanel2.Controls.Add(this.label4);
            flowLayoutPanel2.Location = new System.Drawing.Point(18, 69);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(602, 38);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8);
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "美 [naɪs]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(8);
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "英 [naɪs]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(8);
            this.label5.Size = new System.Drawing.Size(490, 61);
            this.label5.TabIndex = 2;
            this.label5.Text = "n.尼斯\r\n\r\nadj.令人愉快的；宜人的；吸引人的；用于形容词或副词前以加强语气";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(20, 201);
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
            label7.Location = new System.Drawing.Point(18, 237);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(602, 2);
            label7.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(101, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 33);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView wordListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}