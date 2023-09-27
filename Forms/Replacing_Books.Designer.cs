namespace DeweyDecimalClassification_POE_Part1.Forms
{
    partial class Replacing_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replacing_Books));
            this.replaceBooksUserControl1 = new DeweyDecimalClassification_POE_Part1.Controls.ReplaceBooksUserControl();
            this.SuspendLayout();
            // 
            // replaceBooksUserControl1
            // 
            this.replaceBooksUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replaceBooksUserControl1.BackgroundImage")));
            this.replaceBooksUserControl1.Location = new System.Drawing.Point(-1, -2);
            this.replaceBooksUserControl1.Name = "replaceBooksUserControl1";
            this.replaceBooksUserControl1.Size = new System.Drawing.Size(1592, 928);
            this.replaceBooksUserControl1.TabIndex = 0;
            // 
            // Replacing_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 930);
            this.Controls.Add(this.replaceBooksUserControl1);
            this.MaximizeBox = false;
            this.Name = "Replacing_Books";
            this.Text = "Replacing_Books";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ReplaceBooksUserControl replaceBooksUserControl1;
    }
}