namespace DeweyDecimalClassification_POE_Part1.Forms
{
    partial class MatchColumns
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
            this.matchColumnsControl1 = new DeweyDecimalClassification_POE_Part1.Controls.MatchColumnsControl();
            this.SuspendLayout();
            // 
            // matchColumnsControl1
            // 
            this.matchColumnsControl1.BackColor = System.Drawing.Color.Transparent;
            this.matchColumnsControl1.Location = new System.Drawing.Point(0, 0);
            this.matchColumnsControl1.Name = "matchColumnsControl1";
            this.matchColumnsControl1.Size = new System.Drawing.Size(1700, 900);
            this.matchColumnsControl1.TabIndex = 0;
            // 
            // MatchColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 803);
            this.Controls.Add(this.matchColumnsControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MatchColumns";
            this.Text = "MatchColumns";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MatchColumnsControl matchColumnsControl1;
    }
}