namespace DeweyDecimalClassification_POE_Part1.Controls
{
    partial class MatchColumnsControl
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxCallNumbers = new System.Windows.Forms.ListBox();
            this.listBoxDescriptions = new System.Windows.Forms.ListBox();
            this.pbtnMainMenu = new System.Windows.Forms.PictureBox();
            this.pbtnMatchCheck = new System.Windows.Forms.PictureBox();
            this.pbtnTryAgain = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrRemaining = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnMatchCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnTryAgain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.Columns;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1700, 900);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxCallNumbers
            // 
            this.listBoxCallNumbers.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxCallNumbers.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCallNumbers.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxCallNumbers.FormattingEnabled = true;
            this.listBoxCallNumbers.ItemHeight = 31;
            this.listBoxCallNumbers.Location = new System.Drawing.Point(304, 238);
            this.listBoxCallNumbers.Name = "listBoxCallNumbers";
            this.listBoxCallNumbers.Size = new System.Drawing.Size(407, 252);
            this.listBoxCallNumbers.TabIndex = 1;
            this.listBoxCallNumbers.SelectedIndexChanged += new System.EventHandler(this.listBoxCallNumbers_SelectedIndexChanged);
            // 
            // listBoxDescriptions
            // 
            this.listBoxDescriptions.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxDescriptions.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDescriptions.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxDescriptions.FormattingEnabled = true;
            this.listBoxDescriptions.ItemHeight = 31;
            this.listBoxDescriptions.Location = new System.Drawing.Point(845, 238);
            this.listBoxDescriptions.Name = "listBoxDescriptions";
            this.listBoxDescriptions.Size = new System.Drawing.Size(407, 252);
            this.listBoxDescriptions.TabIndex = 2;
            this.listBoxDescriptions.SelectedIndexChanged += new System.EventHandler(this.listBoxDescriptions_SelectedIndexChanged);
            // 
            // pbtnMainMenu
            // 
            this.pbtnMainMenu.BackColor = System.Drawing.Color.Black;
            this.pbtnMainMenu.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.home_btn;
            this.pbtnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtnMainMenu.Location = new System.Drawing.Point(282, 644);
            this.pbtnMainMenu.Name = "pbtnMainMenu";
            this.pbtnMainMenu.Size = new System.Drawing.Size(161, 53);
            this.pbtnMainMenu.TabIndex = 3;
            this.pbtnMainMenu.TabStop = false;
            this.pbtnMainMenu.Click += new System.EventHandler(this.pbtnMainMenu_Click);
            // 
            // pbtnMatchCheck
            // 
            this.pbtnMatchCheck.BackColor = System.Drawing.Color.Black;
            this.pbtnMatchCheck.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.match_btn;
            this.pbtnMatchCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtnMatchCheck.Location = new System.Drawing.Point(650, 644);
            this.pbtnMatchCheck.Name = "pbtnMatchCheck";
            this.pbtnMatchCheck.Size = new System.Drawing.Size(161, 53);
            this.pbtnMatchCheck.TabIndex = 4;
            this.pbtnMatchCheck.TabStop = false;
            this.pbtnMatchCheck.Click += new System.EventHandler(this.pbtnMatchCheck_Click);
            // 
            // pbtnTryAgain
            // 
            this.pbtnTryAgain.BackColor = System.Drawing.Color.Black;
            this.pbtnTryAgain.BackgroundImage = global::DeweyDecimalClassification_POE_Part1.Properties.Resources.try_btn;
            this.pbtnTryAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtnTryAgain.Location = new System.Drawing.Point(989, 644);
            this.pbtnTryAgain.Name = "pbtnTryAgain";
            this.pbtnTryAgain.Size = new System.Drawing.Size(161, 53);
            this.pbtnTryAgain.TabIndex = 5;
            this.pbtnTryAgain.TabStop = false;
            this.pbtnTryAgain.Click += new System.EventHandler(this.pbtnTryAgain_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 16.17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(894, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(190, 36);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "0 Seconds";
            // 
            // tmrRemaining
            // 
            this.tmrRemaining.Interval = 1000;
            this.tmrRemaining.Tick += new System.EventHandler(this.tmrRemaining_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Black;
            this.lblScore.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 16.17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1141, 78);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 36);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score";
            // 
            // MatchColumnsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbtnTryAgain);
            this.Controls.Add(this.pbtnMatchCheck);
            this.Controls.Add(this.pbtnMainMenu);
            this.Controls.Add(this.listBoxDescriptions);
            this.Controls.Add(this.listBoxCallNumbers);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MatchColumnsControl";
            this.Size = new System.Drawing.Size(1352, 822);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnMatchCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnTryAgain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxCallNumbers;
        private System.Windows.Forms.ListBox listBoxDescriptions;
        private System.Windows.Forms.PictureBox pbtnMainMenu;
        private System.Windows.Forms.PictureBox pbtnMatchCheck;
        private System.Windows.Forms.PictureBox pbtnTryAgain;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrRemaining;
        private System.Windows.Forms.Label lblScore;
    }
}
