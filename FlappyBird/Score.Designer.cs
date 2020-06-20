namespace FlappyBird
{
    partial class Score
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxNum1 = new System.Windows.Forms.PictureBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxNum2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNum3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNum1
            // 
            this.pictureBoxNum1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNum1.Image = global::FlappyBird.Properties.Resources._0;
            this.pictureBoxNum1.Location = new System.Drawing.Point(0, -5);
            this.pictureBoxNum1.Name = "pictureBoxNum1";
            this.pictureBoxNum1.Size = new System.Drawing.Size(25, 40);
            this.pictureBoxNum1.TabIndex = 0;
            this.pictureBoxNum1.TabStop = false;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // pictureBoxNum2
            // 
            this.pictureBoxNum2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNum2.Image = global::FlappyBird.Properties.Resources._9;
            this.pictureBoxNum2.Location = new System.Drawing.Point(25, -5);
            this.pictureBoxNum2.Name = "pictureBoxNum2";
            this.pictureBoxNum2.Size = new System.Drawing.Size(25, 40);
            this.pictureBoxNum2.TabIndex = 0;
            this.pictureBoxNum2.TabStop = false;
            // 
            // pictureBoxNum3
            // 
            this.pictureBoxNum3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNum3.Image = global::FlappyBird.Properties.Resources._9;
            this.pictureBoxNum3.Location = new System.Drawing.Point(50, -5);
            this.pictureBoxNum3.Name = "pictureBoxNum3";
            this.pictureBoxNum3.Size = new System.Drawing.Size(25, 40);
            this.pictureBoxNum3.TabIndex = 0;
            this.pictureBoxNum3.TabStop = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(75, 35);
            this.Controls.Add(this.pictureBoxNum3);
            this.Controls.Add(this.pictureBoxNum2);
            this.Controls.Add(this.pictureBoxNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Score";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNum1;
        private System.Windows.Forms.PictureBox pictureBoxNum2;
        private System.Windows.Forms.PictureBox pictureBoxNum3;
        public System.Windows.Forms.Timer timerRefresh;
    }
}