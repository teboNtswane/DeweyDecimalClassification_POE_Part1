namespace DeweyDecimalClassification_POE_Part1.Controls
{
    partial class HomeUserControl
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
            this.btnFindCall = new System.Windows.Forms.Button();
            this.btnIdentifyAreas = new System.Windows.Forms.Button();
            this.btnReplaceBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindCall
            // 
            this.btnFindCall.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCall.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.open_book3;
            this.btnFindCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCall.Location = new System.Drawing.Point(721, 398);
            this.btnFindCall.Name = "btnFindCall";
            this.btnFindCall.Size = new System.Drawing.Size(146, 125);
            this.btnFindCall.TabIndex = 57;
            this.btnFindCall.Text = "Find Call Numbers";
            this.btnFindCall.UseVisualStyleBackColor = false;
            this.btnFindCall.Click += new System.EventHandler(this.btnFindCall_Click);
            // 
            // btnIdentifyAreas
            // 
            this.btnIdentifyAreas.BackColor = System.Drawing.Color.Transparent;
            this.btnIdentifyAreas.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.open_book2;
            this.btnIdentifyAreas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIdentifyAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentifyAreas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIdentifyAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyAreas.Location = new System.Drawing.Point(439, 398);
            this.btnIdentifyAreas.Name = "btnIdentifyAreas";
            this.btnIdentifyAreas.Size = new System.Drawing.Size(146, 125);
            this.btnIdentifyAreas.TabIndex = 56;
            this.btnIdentifyAreas.Text = "Identify Areas";
            this.btnIdentifyAreas.UseVisualStyleBackColor = false;
            this.btnIdentifyAreas.Click += new System.EventHandler(this.btnIdentifyAreas_Click);
            // 
            // btnReplaceBook
            // 
            this.btnReplaceBook.BackColor = System.Drawing.Color.Transparent;
            this.btnReplaceBook.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.open_book1;
            this.btnReplaceBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReplaceBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplaceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceBook.Location = new System.Drawing.Point(168, 398);
            this.btnReplaceBook.Name = "btnReplaceBook";
            this.btnReplaceBook.Size = new System.Drawing.Size(146, 125);
            this.btnReplaceBook.TabIndex = 55;
            this.btnReplaceBook.Text = "Replace Books";
            this.btnReplaceBook.UseVisualStyleBackColor = false;
            this.btnReplaceBook.Click += new System.EventHandler(this.btnReplaceBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.library;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 563);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(325, 64);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(358, 35);
            this.lblHeading.TabIndex = 58;
            this.lblHeading.Text = "Dewey Decimal System";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnFindCall);
            this.Controls.Add(this.btnIdentifyAreas);
            this.Controls.Add(this.btnReplaceBook);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1011, 569);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnReplaceBook;
        public System.Windows.Forms.Button btnIdentifyAreas;
        public System.Windows.Forms.Button btnFindCall;
        private System.Windows.Forms.Label lblHeading;
    }
}
