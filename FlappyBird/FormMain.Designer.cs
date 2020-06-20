namespace FlappyBird
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxRoad = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            this.timerRoadMove = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.timerBirdmove = new System.Windows.Forms.Timer(this.components);
            this.buttonSkin = new System.Windows.Forms.Button();
            this.pictureBoxGuide = new System.Windows.Forms.PictureBox();
            this.buttonPauseStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRoad
            // 
            this.pictureBoxRoad.Image = global::FlappyBird.Properties.Resources.road;
            this.pictureBoxRoad.Location = new System.Drawing.Point(0, 448);
            this.pictureBoxRoad.Name = "pictureBoxRoad";
            this.pictureBoxRoad.Size = new System.Drawing.Size(376, 66);
            this.pictureBoxRoad.TabIndex = 0;
            this.pictureBoxRoad.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::FlappyBird.Properties.Resources.start;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(126, 257);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 28);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonScore
            // 
            this.buttonScore.BackgroundImage = global::FlappyBird.Properties.Resources.score;
            this.buttonScore.FlatAppearance.BorderSize = 0;
            this.buttonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScore.Location = new System.Drawing.Point(126, 293);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(80, 28);
            this.buttonScore.TabIndex = 2;
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // timerRoadMove
            // 
            this.timerRoadMove.Interval = 150;
            this.timerRoadMove.Tick += new System.EventHandler(this.timerRoadMove_Tick);
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitle.Image = global::FlappyBird.Properties.Resources.title;
            this.pictureBoxTitle.Location = new System.Drawing.Point(82, 125);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(180, 47);
            this.pictureBoxTitle.TabIndex = 3;
            this.pictureBoxTitle.TabStop = false;
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGame.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(345, 449);
            this.pictureBoxGame.TabIndex = 5;
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.Click += new System.EventHandler(this.pictureBoxGame_Click);
            this.pictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGame_Paint);
            // 
            // timerBirdmove
            // 
            this.timerBirdmove.Interval = 50;
            this.timerBirdmove.Tick += new System.EventHandler(this.timerBirdmove_Tick);
            // 
            // buttonSkin
            // 
            this.buttonSkin.BackgroundImage = global::FlappyBird.Properties.Resources.skin;
            this.buttonSkin.FlatAppearance.BorderSize = 0;
            this.buttonSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkin.Location = new System.Drawing.Point(126, 329);
            this.buttonSkin.Name = "buttonSkin";
            this.buttonSkin.Size = new System.Drawing.Size(80, 28);
            this.buttonSkin.TabIndex = 6;
            this.buttonSkin.UseVisualStyleBackColor = true;
            this.buttonSkin.Click += new System.EventHandler(this.buttonSkin_Click);
            // 
            // pictureBoxGuide
            // 
            this.pictureBoxGuide.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGuide.Image = global::FlappyBird.Properties.Resources.guide;
            this.pictureBoxGuide.InitialImage = global::FlappyBird.Properties.Resources.guide;
            this.pictureBoxGuide.Location = new System.Drawing.Point(132, 190);
            this.pictureBoxGuide.Name = "pictureBoxGuide";
            this.pictureBoxGuide.Size = new System.Drawing.Size(117, 105);
            this.pictureBoxGuide.TabIndex = 7;
            this.pictureBoxGuide.TabStop = false;
            // 
            // buttonPauseStart
            // 
            this.buttonPauseStart.BackgroundImage = global::FlappyBird.Properties.Resources.pause;
            this.buttonPauseStart.FlatAppearance.BorderSize = 0;
            this.buttonPauseStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPauseStart.Location = new System.Drawing.Point(22, 22);
            this.buttonPauseStart.Name = "buttonPauseStart";
            this.buttonPauseStart.Size = new System.Drawing.Size(28, 28);
            this.buttonPauseStart.TabIndex = 8;
            this.buttonPauseStart.UseVisualStyleBackColor = true;
            this.buttonPauseStart.Click += new System.EventHandler(this.buttonPauseStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::FlappyBird.Properties.Resources.exit;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(126, 365);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 28);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(288, 491);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.night;
            this.ClientSize = new System.Drawing.Size(344, 511);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonPauseStart);
            this.Controls.Add(this.pictureBoxGuide);
            this.Controls.Add(this.pictureBoxRoad);
            this.Controls.Add(this.pictureBoxGame);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSkin);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            this.Move += new System.EventHandler(this.FormMain_Move);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRoad;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.Timer timerRoadMove;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.Timer timerBirdmove;
        private System.Windows.Forms.Button buttonSkin;
        private System.Windows.Forms.PictureBox pictureBoxGuide;
        private System.Windows.Forms.Button buttonPauseStart;
        private System.Windows.Forms.Button buttonExit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

