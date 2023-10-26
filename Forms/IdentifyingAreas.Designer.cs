namespace DeweyDecimalClassification_POE_Part1.Forms
{
    partial class IdentifyingAreas
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
            this.identifyAreasControl1 = new DeweyDecimalClassification_POE_Part1.Controls.IdentifyAreasControl();
            this.SuspendLayout();
            // 
            // identifyAreasControl1
            // 
            this.identifyAreasControl1.Location = new System.Drawing.Point(-4, -8);
            this.identifyAreasControl1.Name = "identifyAreasControl1";
            this.identifyAreasControl1.Size = new System.Drawing.Size(1770, 900);
            this.identifyAreasControl1.TabIndex = 0;
            // 
            // IdentifyingAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 803);
            this.Controls.Add(this.identifyAreasControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "IdentifyingAreas";
            this.Text = "IdentifyingAreas";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.IdentifyAreasControl identifyAreasControl1;
    }
}