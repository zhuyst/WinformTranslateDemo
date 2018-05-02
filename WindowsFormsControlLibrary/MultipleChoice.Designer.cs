namespace WindowsFormsControlLibrary
{
    partial class MultipleChoice
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
            System.Windows.Forms.Label label1;
            this.wordLabel = new System.Windows.Forms.Label();
            this.roundButton4 = new WindowsFormsControlLibrary.RoundButton();
            this.roundButton3 = new WindowsFormsControlLibrary.RoundButton();
            this.roundButton2 = new WindowsFormsControlLibrary.RoundButton();
            this.roundButton1 = new WindowsFormsControlLibrary.RoundButton();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(219, 113);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 15);
            label1.TabIndex = 5;
            label1.Text = "请选择单词中缺省的字母";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.wordLabel.Location = new System.Drawing.Point(237, 44);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(133, 53);
            this.wordLabel.TabIndex = 0;
            this.wordLabel.Text = "word";
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.Beige;
            this.roundButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ImageEnter = null;
            this.roundButton4.ImageNormal = null;
            this.roundButton4.Location = new System.Drawing.Point(453, 159);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Radius = 82;
            this.roundButton4.Size = new System.Drawing.Size(82, 82);
            this.roundButton4.TabIndex = 4;
            this.roundButton4.Text = "D";
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Beige;
            this.roundButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ImageEnter = null;
            this.roundButton3.ImageNormal = null;
            this.roundButton3.Location = new System.Drawing.Point(327, 159);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Radius = 82;
            this.roundButton3.Size = new System.Drawing.Size(82, 82);
            this.roundButton3.TabIndex = 3;
            this.roundButton3.Text = "C";
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Beige;
            this.roundButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ImageEnter = null;
            this.roundButton2.ImageNormal = null;
            this.roundButton2.Location = new System.Drawing.Point(201, 159);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Radius = 82;
            this.roundButton2.Size = new System.Drawing.Size(82, 82);
            this.roundButton2.TabIndex = 2;
            this.roundButton2.Text = "B";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Beige;
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ImageEnter = null;
            this.roundButton1.ImageNormal = null;
            this.roundButton1.Location = new System.Drawing.Point(75, 159);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Radius = 82;
            this.roundButton1.Size = new System.Drawing.Size(82, 82);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "A";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton_Click);
            // 
            // MultipleChoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(label1);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.wordLabel);
            this.Name = "MultipleChoice";
            this.Size = new System.Drawing.Size(618, 279);
            this.Load += new System.EventHandler(this.MultipleChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
    }
}
