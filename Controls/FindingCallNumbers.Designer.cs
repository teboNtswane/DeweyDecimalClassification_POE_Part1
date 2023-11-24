namespace DeweyDecimalClassification_POE_Part1.Controls
{
    partial class FindingCallNumbers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptnStart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBtnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ptnStart
            // 
            this.ptnStart.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.start_quiz;
            this.ptnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptnStart.Location = new System.Drawing.Point(588, 444);
            this.ptnStart.Name = "ptnStart";
            this.ptnStart.Size = new System.Drawing.Size(358, 82);
            this.ptnStart.TabIndex = 1;
            this.ptnStart.TabStop = false;
            this.ptnStart.Click += new System.EventHandler(this.ptnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.welcome_page;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1734, 759);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pBtnBack
            // 
            this.pBtnBack.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.back;
            this.pBtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBtnBack.Location = new System.Drawing.Point(13, 23);
            this.pBtnBack.Name = "pBtnBack";
            this.pBtnBack.Size = new System.Drawing.Size(130, 34);
            this.pBtnBack.TabIndex = 13;
            this.pBtnBack.TabStop = false;
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBtnBack);
            this.Controls.Add(this.ptnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FindingCallNumbers";
            this.Size = new System.Drawing.Size(1754, 765);
            ((System.ComponentModel.ISupportInitialize)(this.ptnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBtnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptnStart;
        public System.Windows.Forms.PictureBox pBtnBack;
    }
}
