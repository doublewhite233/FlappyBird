namespace FlappyBird
{
    partial class Skin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skin));
            this.buttonClose = new System.Windows.Forms.Button();
            this.timerBirdMove = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBird4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBird3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBird2 = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxBird1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBg1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBg4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBg3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBg2 = new System.Windows.Forms.PictureBox();
            this.labelb1 = new System.Windows.Forms.Label();
            this.labelb2 = new System.Windows.Forms.Label();
            this.labelb4 = new System.Windows.Forms.Label();
            this.labelb3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::FlappyBird.Properties.Resources.close;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(244, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(21, 20);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerBirdMove
            // 
            this.timerBirdMove.Enabled = true;
            this.timerBirdMove.Interval = 50;
            this.timerBirdMove.Tick += new System.EventHandler(this.timerBirdMove_Tick);
            // 
            // pictureBoxBird4
            // 
            this.pictureBoxBird4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBird4.Location = new System.Drawing.Point(183, 210);
            this.pictureBoxBird4.Name = "pictureBoxBird4";
            this.pictureBoxBird4.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBird4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBird4.TabIndex = 2;
            this.pictureBoxBird4.TabStop = false;
            this.pictureBoxBird4.Click += new System.EventHandler(this.pictureBoxBird4_Click);
            this.pictureBoxBird4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBird4_Paint);
            // 
            // pictureBoxBird3
            // 
            this.pictureBoxBird3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBird3.Location = new System.Drawing.Point(49, 210);
            this.pictureBoxBird3.Name = "pictureBoxBird3";
            this.pictureBoxBird3.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBird3.TabIndex = 3;
            this.pictureBoxBird3.TabStop = false;
            this.pictureBoxBird3.Click += new System.EventHandler(this.pictureBoxBird3_Click);
            this.pictureBoxBird3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBird3_Paint);
            // 
            // pictureBoxBird2
            // 
            this.pictureBoxBird2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBird2.Location = new System.Drawing.Point(183, 78);
            this.pictureBoxBird2.Name = "pictureBoxBird2";
            this.pictureBoxBird2.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBird2.TabIndex = 4;
            this.pictureBoxBird2.TabStop = false;
            this.pictureBoxBird2.Click += new System.EventHandler(this.pictureBoxBird2_Click);
            this.pictureBoxBird2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBird2_Paint);
            // 
            // buttonOK
            // 
            this.buttonOK.BackgroundImage = global::FlappyBird.Properties.Resources.ok;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(100, 313);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 28);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBird1
            // 
            this.pictureBoxBird1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBird1.Location = new System.Drawing.Point(49, 78);
            this.pictureBoxBird1.Name = "pictureBoxBird1";
            this.pictureBoxBird1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBird1.TabIndex = 1;
            this.pictureBoxBird1.TabStop = false;
            this.pictureBoxBird1.Click += new System.EventHandler(this.pictureBoxBird1_Click);
            this.pictureBoxBird1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBird1_Paint);
            // 
            // pictureBoxBg1
            // 
            this.pictureBoxBg1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBg1.BackgroundImage")));
            this.pictureBoxBg1.Location = new System.Drawing.Point(22, 55);
            this.pictureBoxBg1.Name = "pictureBoxBg1";
            this.pictureBoxBg1.Size = new System.Drawing.Size(105, 105);
            this.pictureBoxBg1.TabIndex = 8;
            this.pictureBoxBg1.TabStop = false;
            // 
            // pictureBoxBg4
            // 
            this.pictureBoxBg4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBg4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBg4.BackgroundImage")));
            this.pictureBoxBg4.Location = new System.Drawing.Point(154, 188);
            this.pictureBoxBg4.Name = "pictureBoxBg4";
            this.pictureBoxBg4.Size = new System.Drawing.Size(105, 105);
            this.pictureBoxBg4.TabIndex = 9;
            this.pictureBoxBg4.TabStop = false;
            // 
            // pictureBoxBg3
            // 
            this.pictureBoxBg3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBg3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBg3.BackgroundImage")));
            this.pictureBoxBg3.Location = new System.Drawing.Point(22, 188);
            this.pictureBoxBg3.Name = "pictureBoxBg3";
            this.pictureBoxBg3.Size = new System.Drawing.Size(105, 105);
            this.pictureBoxBg3.TabIndex = 10;
            this.pictureBoxBg3.TabStop = false;
            // 
            // pictureBoxBg2
            // 
            this.pictureBoxBg2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBg2.BackgroundImage")));
            this.pictureBoxBg2.Location = new System.Drawing.Point(154, 55);
            this.pictureBoxBg2.Name = "pictureBoxBg2";
            this.pictureBoxBg2.Size = new System.Drawing.Size(105, 105);
            this.pictureBoxBg2.TabIndex = 11;
            this.pictureBoxBg2.TabStop = false;
            // 
            // labelb1
            // 
            this.labelb1.AutoSize = true;
            this.labelb1.BackColor = System.Drawing.Color.Transparent;
            this.labelb1.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelb1.Location = new System.Drawing.Point(45, 131);
            this.labelb1.Name = "labelb1";
            this.labelb1.Size = new System.Drawing.Size(60, 18);
            this.labelb1.TabIndex = 12;
            this.labelb1.Text = "YELLOW";
            // 
            // labelb2
            // 
            this.labelb2.AutoSize = true;
            this.labelb2.BackColor = System.Drawing.Color.Transparent;
            this.labelb2.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelb2.Location = new System.Drawing.Point(189, 131);
            this.labelb2.Name = "labelb2";
            this.labelb2.Size = new System.Drawing.Size(41, 18);
            this.labelb2.TabIndex = 12;
            this.labelb2.Text = "BLUE";
            // 
            // labelb4
            // 
            this.labelb4.AutoSize = true;
            this.labelb4.BackColor = System.Drawing.Color.Transparent;
            this.labelb4.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelb4.Location = new System.Drawing.Point(183, 263);
            this.labelb4.Name = "labelb4";
            this.labelb4.Size = new System.Drawing.Size(51, 18);
            this.labelb4.TabIndex = 14;
            this.labelb4.Text = "BLACK";
            // 
            // labelb3
            // 
            this.labelb3.AutoSize = true;
            this.labelb3.BackColor = System.Drawing.Color.Transparent;
            this.labelb3.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelb3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelb3.Location = new System.Drawing.Point(57, 263);
            this.labelb3.Name = "labelb3";
            this.labelb3.Size = new System.Drawing.Size(34, 18);
            this.labelb3.TabIndex = 13;
            this.labelb3.Text = "RED";
            // 
            // Skin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.nullboard;
            this.ClientSize = new System.Drawing.Size(285, 370);
            this.Controls.Add(this.labelb4);
            this.Controls.Add(this.labelb3);
            this.Controls.Add(this.labelb2);
            this.Controls.Add(this.labelb1);
            this.Controls.Add(this.pictureBoxBird4);
            this.Controls.Add(this.pictureBoxBird3);
            this.Controls.Add(this.pictureBoxBird2);
            this.Controls.Add(this.pictureBoxBird1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxBg1);
            this.Controls.Add(this.pictureBoxBg2);
            this.Controls.Add(this.pictureBoxBg3);
            this.Controls.Add(this.pictureBoxBg4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timerBirdMove;
        private System.Windows.Forms.PictureBox pictureBoxBird4;
        private System.Windows.Forms.PictureBox pictureBoxBird3;
        private System.Windows.Forms.PictureBox pictureBoxBird2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxBird1;
        private System.Windows.Forms.PictureBox pictureBoxBg1;
        private System.Windows.Forms.PictureBox pictureBoxBg4;
        private System.Windows.Forms.PictureBox pictureBoxBg3;
        private System.Windows.Forms.PictureBox pictureBoxBg2;
        private System.Windows.Forms.Label labelb1;
        private System.Windows.Forms.Label labelb2;
        private System.Windows.Forms.Label labelb4;
        private System.Windows.Forms.Label labelb3;
    }
}