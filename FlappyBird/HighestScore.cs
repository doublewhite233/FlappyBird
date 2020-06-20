using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FlappyBird
{
    public partial class HighestScore : Form
    {
        //图片数组
        Image[] scImg = new Image[10];
        //最高分
        private int _first = 0;

        public int _First
        {
            get { return _first; }
            set { _first = value; }
        }
        private int _second = 0;

        public int _Second
        {
            get { return _second; }
            set { _second = value; }
        }
        private int _third = 0;

        public int _Third
        {
            get { return _third; }
            set { _third = value; }
        }

        public void SetWindowRegion()
        {
            //创建特定形状的窗体.GraphicsPath:一系列相互连接的直线和曲线
            GraphicsPath FormPath = new GraphicsPath();
            //创建窗口大小的矩形
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 40);
            //由矩形和由路径构成的图形形状的内部
            this.Region = new Region(FormPath);
        }

        //圆角边框
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int r)
        {
            int diameter = r;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            //path中添加曲线，（矩形大小，起始角度，跨越角度）
            //起始角度从圆心中点x轴为0，向下跨越
            // 左上角
            path.AddArc(arcRect, 180, 90);
            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            //闭合曲线
            path.CloseFigure();
            return path;
        }

        private void scoreNum(int _score, PictureBox p1, PictureBox p2, PictureBox p3)
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
                p1.Visible = false;
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

        public HighestScore()
        {
            InitializeComponent();

            SetWindowRegion();

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

            timer1.Enabled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scoreNum(_first, pictureBoxNum1, pictureBoxNum2, pictureBoxNum3);
            scoreNum(_second, pictureBox3, pictureBox2, pictureBox1);
            scoreNum(_third, pictureBox6, pictureBox5, pictureBox4);
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();
            pictureBox5.Refresh();
            pictureBox6.Refresh();
            pictureBoxNum1.Refresh();
            pictureBoxNum2.Refresh();
            pictureBoxNum3.Refresh();
        }
    }
}
