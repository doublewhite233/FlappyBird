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
    public partial class Score : Form
    {
        //FormBorderStyle属性=None,窗体生成出来大小和预期不一致解决方法
        //minimumSize设置1，1
        //transparentKey=control 窗体透明
        //topmost置顶

        //分数
        private int _score = 0;
        //图片数组
        Image[] scImg = new Image[10];
        //屏幕长宽
        private int _width = Screen.PrimaryScreen.Bounds.Width;
        private int _height = Screen.PrimaryScreen.Bounds.Height;

        public int _Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public Score()
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

            //初始化窗口大小
            this.Width = 25;
            pictureBoxNum1.Image = scImg[0];
        }

        public void scoreNum(int _score)
        {
            //个位
            if (_score < 10)
            {
                this.Width = 25;
                if (_score == 0)
                    pictureBoxNum1.Image = scImg[0];
                if (_score == 1)
                    pictureBoxNum1.Image = scImg[1];
                if (_score == 2)
                    pictureBoxNum1.Image = scImg[2];
                if (_score == 3)
                    pictureBoxNum1.Image = scImg[3];
                if (_score == 4)
                    pictureBoxNum1.Image = scImg[4];
                if (_score == 5)
                    pictureBoxNum1.Image = scImg[5];
                if (_score == 6)
                    pictureBoxNum1.Image = scImg[6];
                if (_score == 7)
                    pictureBoxNum1.Image = scImg[7];
                if (_score == 8)
                    pictureBoxNum1.Image = scImg[8];
                if (_score == 9)
                    pictureBoxNum1.Image = scImg[9];
            }

            //两位数
            if (_score >= 10&&_score<100)
            {
                this.Width = 50;
                this.Location =new Point((_width - this.Width) / 2-this.Width/8, _height / 8 + this.Height * 2 + 10);
                if (_score %10 == 0)
                    pictureBoxNum2.Image = scImg[0];
                if (_score % 10 == 1)
                    pictureBoxNum2.Image = scImg[1];
                if (_score % 10 == 2)
                    pictureBoxNum2.Image = scImg[2];
                if (_score % 10 == 3)
                    pictureBoxNum2.Image = scImg[3];
                if (_score % 10 == 4)
                    pictureBoxNum2.Image = scImg[4];
                if (_score % 10 == 5)
                    pictureBoxNum2.Image = scImg[5];
                if (_score % 10 == 6)
                    pictureBoxNum2.Image = scImg[6];
                if (_score % 10 == 7)
                    pictureBoxNum2.Image = scImg[7];
                if (_score % 10 == 8)
                    pictureBoxNum2.Image = scImg[8];
                if (_score % 10 == 9)
                    pictureBoxNum2.Image = scImg[9];

                if (_score/10 == 0)
                    pictureBoxNum1.Image = scImg[0];
                if (_score/10 == 1)
                    pictureBoxNum1.Image = scImg[1];
                if (_score/10 == 2)
                    pictureBoxNum1.Image = scImg[2];
                if (_score/10 == 3)
                    pictureBoxNum1.Image = scImg[3];
                if (_score/10 == 4)
                    pictureBoxNum1.Image = scImg[4];
                if (_score/10 == 5)
                    pictureBoxNum1.Image = scImg[5];
                if (_score/10 == 6)
                    pictureBoxNum1.Image = scImg[6];
                if (_score/10 == 7)
                    pictureBoxNum1.Image = scImg[7];
                if (_score/10 == 8)
                    pictureBoxNum1.Image = scImg[8];
                if (_score/10 == 9)
                    pictureBoxNum1.Image = scImg[9];
            }

            //三位数
            if (_score >= 100 && _score < 1000)
            {
                this.Width = 75;
                if (_score % 10 == 0)
                    pictureBoxNum3.Image = scImg[0];
                if (_score % 10 == 1)
                    pictureBoxNum3.Image = scImg[1];
                if (_score % 10 == 2)
                    pictureBoxNum3.Image = scImg[2];
                if (_score % 10 == 3)
                    pictureBoxNum3.Image = scImg[3];
                if (_score % 10 == 4)
                    pictureBoxNum3.Image = scImg[4];
                if (_score % 10 == 5)
                    pictureBoxNum3.Image = scImg[5];
                if (_score % 10 == 6)
                    pictureBoxNum3.Image = scImg[6];
                if (_score % 10 == 7)
                    pictureBoxNum3.Image = scImg[7];
                if (_score % 10 == 8)
                    pictureBoxNum3.Image = scImg[8];
                if (_score % 10 == 9)
                    pictureBoxNum3.Image = scImg[9];

                if (_score / 10%10 == 0)
                    pictureBoxNum2.Image = scImg[0];
                if (_score / 10 % 10 == 1)
                    pictureBoxNum2.Image = scImg[1];
                if (_score / 10 % 10 == 2)
                    pictureBoxNum2.Image = scImg[2];
                if (_score / 10 % 10 == 3)
                    pictureBoxNum2.Image = scImg[3];
                if (_score / 10 % 10 == 4)
                    pictureBoxNum2.Image = scImg[4];
                if (_score / 10 % 10 == 5)
                    pictureBoxNum2.Image = scImg[5];
                if (_score / 10 % 10 == 6)
                    pictureBoxNum2.Image = scImg[6];
                if (_score / 10 % 10 == 7)
                    pictureBoxNum2.Image = scImg[7];
                if (_score / 10 % 10 == 8)
                    pictureBoxNum2.Image = scImg[8];
                if (_score / 10 % 10 == 9)
                    pictureBoxNum2.Image = scImg[9];

                if (_score / 100 == 0)
                    pictureBoxNum1.Image = scImg[0];
                if (_score / 100 == 1)
                    pictureBoxNum1.Image = scImg[1];
                if (_score / 100 == 2)
                    pictureBoxNum1.Image = scImg[2];
                if (_score / 100 == 3)
                    pictureBoxNum1.Image = scImg[3];
                if (_score / 100 == 4)
                    pictureBoxNum1.Image = scImg[4];
                if (_score / 100 == 5)
                    pictureBoxNum1.Image = scImg[5];
                if (_score / 100 == 6)
                    pictureBoxNum1.Image = scImg[6];
                if (_score / 100 == 7)
                    pictureBoxNum1.Image = scImg[7];
                if (_score / 100 == 8)
                    pictureBoxNum1.Image = scImg[8];
                if (_score / 100 == 9)
                    pictureBoxNum1.Image = scImg[9];
            }

        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            scoreNum(_score);
            //刷新界面
            Invalidate();
        }
    }
}
