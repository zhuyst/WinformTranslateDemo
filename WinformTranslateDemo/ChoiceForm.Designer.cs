namespace WinformTranslateDemo
{
    partial class ChoiceForm
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
            this.multipleChoice1 = new WindowsFormsControlLibrary.MultipleChoice();
            this.SuspendLayout();
            // 
            // multipleChoice1
            // 
            this.multipleChoice1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multipleChoice1.Location = new System.Drawing.Point(13, 13);
            this.multipleChoice1.Name = "multipleChoice1";
            this.multipleChoice1.Size = new System.Drawing.Size(618, 279);
            this.multipleChoice1.TabIndex = 0;
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 305);
            this.Controls.Add(this.multipleChoice1);
            this.Name = "ChoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary.MultipleChoice multipleChoice1;
    }
}