using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class ScoreBoard : Form
    {
        private bool _openFlag = true;
        //分数
        private int _score = 0;
        //最高分
        private int _bestSc = 0;

        public int _BestSc
        {
            get { return _bestSc; }
            set { _bestSc = value; }
        }

        //图片数组
        Image[] scImg = new Image[10];

        public bool OpenFlag
        {
            get { return _openFlag; }
            set { _openFlag = value; }
        }

        public int _Score
        {
            get { return _score; }
            set { _score = value; }
        }

        private void scoreNum(int _score,PictureBox p1,PictureBox p2,PictureBox p3)
        {
            //个位
            if (_score < 10)
            {
                p1.Visible = false;
                p2.Visible = false;
                if (_score == 0)
                    p3.Image = scImg[0];
                if (_score == 1)
                    p3.Image = scImg[1];
                if (_score == 2)
                    p3.Image = scImg[2];
                if (_score == 3)
                    p3.Image = scImg[3];
                if (_score == 4)
                    p3.Image = scImg[4];
                if (_score == 5)
                    p3.Image = scImg[5];
                if (_score == 6)
                    p3.Image = scImg[6];
                if (_score == 7)
                    p3.Image = scImg[7];
                if (_score == 8)
                    p3.Image = scImg[8];
                if (_score == 9)
                    p3.Image = scImg[9];
            }

            //两位数
            if (_score >= 10 && _score < 100)
            {
                p1.Visible =false;
                p2.Visible = true;
                if (_score % 10 == 0)
                    p3.Image = scImg[0];
                if (_score % 10 == 1)
                    p3.Image = scImg[1];
                if (_score % 10 == 2)
                    p3.Image = scImg[2];
                if (_score % 10 == 3)
                    p3.Image = scImg[3];
                if (_score % 10 == 4)
                    p3.Image = scImg[4];
                if (_score % 10 == 5)
                    p3.Image = scImg[5];
                if (_score % 10 == 6)
                    p3.Image = scImg[6];
                if (_score % 10 == 7)
                    p3.Image = scImg[7];
                if (_score % 10 == 8)
                    p3.Image = scImg[8];
                if (_score % 10 == 9)
                    p3.Image = scImg[9];

                if (_score / 10 == 0)
                    p2.Image = scImg[0];
                if (_score / 10 == 1)
                    p2.Image = scImg[1];
                if (_score / 10 == 2)
                    p2.Image = scImg[2];
                if (_score / 10 == 3)
                    p2.Image = scImg[3];
                if (_score / 10 == 4)
                    p2.Image = scImg[4];
                if (_score / 10 == 5)
                    p2.Image = scImg[5];
                if (_score / 10 == 6)
                    p2.Image = scImg[6];
                if (_score / 10 == 7)
                    p2.Image = scImg[7];
                if (_score / 10 == 8)
                    p2.Image = scImg[8];
                if (_score / 10 == 9)
                    p2.Image = scImg[9];
            }

            //三位数
            if (_score >= 100 && _score < 1000)
            {
                p1.Visible = true;
                p2.Visible = true;
                if (_score % 10 == 0)
                    p3.Image = scImg[0];
                if (_score % 10 == 1)
                    p3.Image = scImg[1];
                if (_score % 10 == 2)
                    p3.Image = scImg[2];
                if (_score % 10 == 3)
                    p3.Image = scImg[3];
                if (_score % 10 == 4)
                    p3.Image = scImg[4];
                if (_score % 10 == 5)
                    p3.Image = scImg[5];
                if (_score % 10 == 6)
                    p3.Image = scImg[6];
                if (_score % 10 == 7)
                    p3.Image = scImg[7];
                if (_score % 10 == 8)
                    p3.Image = scImg[8];
                if (_score % 10 == 9)
                    p3.Image = scImg[9];

                if (_score / 10 % 10 == 0)
                    p2.Image = scImg[0];
                if (_score / 10 % 10 == 1)
                    p2.Image = scImg[1];
                if (_score / 10 % 10 == 2)
                    p2.Image = scImg[2];
                if (_score / 10 % 10 == 3)
                    p2.Image = scImg[3];
                if (_score / 10 % 10 == 4)
                    p2.Image = scImg[4];
                if (_score / 10 % 10 == 5)
                    p2.Image = scImg[5];
                if (_score / 10 % 10 == 6)
                    p2.Image = scImg[6];
                if (_score / 10 % 10 == 7)
                    p2.Image = scImg[7];
                if (_score / 10 % 10 == 8)
                    p2.Image = scImg[8];
                if (_score / 10 % 10 == 9)
                    p2.Image = scImg[9];

                if (_score / 100 == 0)
                    p1.Image = scImg[0];
                if (_score / 100 == 1)
                    p1.Image = scImg[1];
                if (_score / 100 == 2)
                    p1.Image = scImg[2];
                if (_score / 100 == 3)
                    p1.Image = scImg[3];
                if (_score / 100 == 4)
                    p1.Image = scImg[4];
                if (_score / 100 == 5)
                    p1.Image = scImg[5];
                if (_score / 100 == 6)
                    p1.Image = scImg[6];
                if (_score / 100 == 7)
                    p1.Image = scImg[7];
                if (_score / 100 == 8)
                    p1.Image = scImg[8];
                if (_score / 100 == 9)
                    p1.Image = scImg[9];
            }
        }

        //展示奖牌
        private void showMedal()
        {
            if (_score == 0)
                pictureBoxMedal.Visible = false;
            else if (_score > 0 && _score < 5)
                pictureBoxMedal.Image = Properties.Resources.medal3;
            else if (_score >= 5 && _score < 10)
                pictureBoxMedal.Image = Properties.Resources.medal2;
            else if (_score >= 10 && _score < 15)
                pictureBoxMedal.Image = Properties.Resources.medal1;
            else if (_score >= 15)
                pictureBoxMedal.Image = Properties.Resources.medal0;
        }

        public ScoreBoard()
        {
            InitializeComponent();

            //装载图片
            scImg[0] = FlappyBird.Properties.Resources._0;
            scImg[1] = FlappyBird.Properties.Resources._1;
            scImg[2] = FlappyBird.Properties.Resources._2;
            scImg[3] = FlappyBird.Properties.Resources._3;
            scImg[4] = FlappyBird.Properties.Resources._4;
            scImg[5] = FlappyBird.Properties.Resources._5;
            scImg[6] = FlappyBird.Properties.Resources._6;
            scImg[7] = FlappyBird.Properties.Resources._7;
            scImg[8] = FlappyBird.Properties.Resources._8;
            scImg[9] = FlappyBird.Properties.Resources._9;

            //显示分数
            timerRefresh.Enabled = true;

            
        }

        private void ScoreBoard_Click(object sender, EventArgs e)
        {
            _openFlag = false;
            //关闭窗体
            Close();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            //显示分数
            scoreNum(_score,pictureBoxNum1,pictureBoxNum2,pictureBoxNum3);
            scoreNum(_bestSc, pictureBoxBest1, pictureBoxBest2, pictureBoxBest3);
            
            showMedal();
            pictureBoxNum1.Refresh();
            pictureBoxNum2.Refresh();
            pictureBoxNum3.Refresh();
            pictureBoxBest1.Refresh();
            pictureBoxBest2.Refresh();
            pictureBoxBest3.Refresh();
        }
    }
}
