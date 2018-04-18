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
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.translateListBox = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.wordListBox);
            groupBox1.Location = new System.Drawing.Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(262, 413);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "单词列表";
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 15;
            this.wordListBox.Location = new System.Drawing.Point(7, 25);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(249, 379);
            this.wordListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.translateListBox);
            groupBox2.Location = new System.Drawing.Point(311, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(362, 413);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "翻译结果";
            // 
            // translateListBox
            // 
            this.translateListBox.FormattingEnabled = true;
            this.translateListBox.ItemHeight = 15;
            this.translateListBox.Location = new System.Drawing.Point(7, 25);
            this.translateListBox.Name = "translateListBox";
            this.translateListBox.Size = new System.Drawing.Size(349, 379);
            this.translateListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(281, 205);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "->";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(label1);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.ListBox translateListBox;
    }
}