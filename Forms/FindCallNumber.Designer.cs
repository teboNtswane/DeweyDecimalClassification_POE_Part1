namespace DeweyDecimalClassification_POE_Part1.Forms
{
    partial class FindCallNumber
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
            this.findingCallNumbers1 = new DeweyDecimalClassification_POE_Part1.Controls.FindingCallNumbers();
            this.SuspendLayout();
            // 
            // findingCallNumbers1
            // 
            this.findingCallNumbers1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.findingCallNumbers1.Location = new System.Drawing.Point(-4, -1);
            this.findingCallNumbers1.Name = "findingCallNumbers1";
            this.findingCallNumbers1.Size = new System.Drawing.Size(1785, 765);
            this.findingCallNumbers1.TabIndex = 0;
            // 
            // FindCallNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 752);
            this.Controls.Add(this.findingCallNumbers1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FindCallNumber";
            this.Text = "FindCallNumber";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.FindingCallNumbers findingCallNumbers1;
    }
}