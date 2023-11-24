namespace DeweyDecimalClassification_POE_Part1.Controls
{
    partial class Instructions
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
            this.pBtnLetsGo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBtnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBtnLetsGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pBtnLetsGo
            // 
            this.pBtnLetsGo.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.lets_go;
            this.pBtnLetsGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBtnLetsGo.Location = new System.Drawing.Point(675, 71);
            this.pBtnLetsGo.Name = "pBtnLetsGo";
            this.pBtnLetsGo.Size = new System.Drawing.Size(266, 77);
            this.pBtnLetsGo.TabIndex = 1;
            this.pBtnLetsGo.TabStop = false;
            this.pBtnLetsGo.Click += new System.EventHandler(this.pBtnLetsGo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.how_toPlay;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1525, 751);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pBtnBack
            // 
            this.pBtnBack.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.back;
            this.pBtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBtnBack.Location = new System.Drawing.Point(12, 22);
            this.pBtnBack.Name = "pBtnBack";
            this.pBtnBack.Size = new System.Drawing.Size(130, 34);
            this.pBtnBack.TabIndex = 13;
            this.pBtnBack.TabStop = false;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBtnBack);
            this.Controls.Add(this.pBtnLetsGo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Instructions";
            this.Size = new System.Drawing.Size(1531, 757);
            ((System.ComponentModel.ISupportInitialize)(this.pBtnLetsGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBtnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBtnLetsGo;
        public System.Windows.Forms.PictureBox pBtnBack;
    }
}
