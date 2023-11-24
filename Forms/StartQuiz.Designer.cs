namespace DeweyDecimalClassification_POE_Part1.Forms
{
    partial class StartQuiz
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
            this.startQuizControl1 = new DeweyDecimalClassification_POE_Part1.Controls.StartQuizControl();
            this.SuspendLayout();
            // 
            // startQuizControl1
            // 
            this.startQuizControl1.Location = new System.Drawing.Point(-1, 0);
            this.startQuizControl1.Name = "startQuizControl1";
            this.startQuizControl1.Size = new System.Drawing.Size(1633, 757);
            this.startQuizControl1.TabIndex = 0;
            // 
            // StartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 771);
            this.Controls.Add(this.startQuizControl1);
            this.Name = "StartQuiz";
            this.Text = "StartQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.StartQuizControl startQuizControl1;
    }
}