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
            this.multipleChoice = new WindowsFormsControlLibrary.MultipleChoice();
            this.SuspendLayout();
            // 
            // multipleChoice
            // 
            this.multipleChoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multipleChoice.Location = new System.Drawing.Point(13, 13);
            this.multipleChoice.Name = "multipleChoice";
            this.multipleChoice.Size = new System.Drawing.Size(618, 279);
            this.multipleChoice.TabIndex = 0;
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(645, 305);
            this.Controls.Add(this.multipleChoice);
            this.Name = "ChoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary.MultipleChoice multipleChoice;
    }
}