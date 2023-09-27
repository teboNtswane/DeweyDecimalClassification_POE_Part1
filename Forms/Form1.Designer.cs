namespace DeweyDecimalClassification_POE_Part1
{
    partial class WelcomeWindow
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
            this.homeUserControl1 = new DeweyDecimalClassification_POE_Part1.Controls.HomeUserControl();
            this.SuspendLayout();
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(12, 12);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1011, 569);
            this.homeUserControl1.TabIndex = 0;
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 589);
            this.Controls.Add(this.homeUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "WelcomeWindow";
            this.Text = "Dewey Decimal System";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.HomeUserControl homeUserControl1;
    }
}

