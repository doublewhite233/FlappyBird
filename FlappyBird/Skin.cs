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
    public partial class Skin : Form
    {
        //4种皮肤，生成四只小鸟
        private Bird[] _bird = new Bird[4];
        //当前选择颜色
        private BirdColor _nowBirdColor;
        //是否解锁标志
        private bool _unlocked = false;
        //最高分
        private int _firstsc;

        public int _Firstsc
        {
            get { return _firstsc; }
            set { _firstsc = value; }
        }

        public BirdColor NowBirdColor
        {
            get { return _nowBirdColor; }
            set { _nowBirdColor = value; }
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

        //选中时的选择框展示及效果
        public void showCheck(BirdColor color)
        {
            if (color == BirdColor.yellow)
            {
                pictureBoxBg1.Visible = true;
                pictureBoxBg2.Visible = false;
                pictureBoxBg3.Visible = false;
                pictureBoxBg4.Visible = false;
            }
            else if (color == BirdColor.blue)
            {
                pictureBoxBg2.Visible = true;
                pictureBoxBg1.Visible = false;
                pictureBoxBg3.Visible = false;
                pictureBoxBg4.Visible = false;
            }
            else if (color == BirdColor.red)
            {
                pictureBoxBg3.Visible = true;
                pictureBoxBg2.Visible = false;
                pictureBoxBg1.Visible = false;
                pictureBoxBg4.Visible = false;
            }
            else if (color == BirdColor.black)
            {
                pictureBoxBg4.Visible = true;
                pictureBoxBg2.Visible = false;
                pictureBoxBg3.Visible = false;
                pictureBoxBg1.Visible = false;
            }

            if (_firstsc < 10)
            {
                labelb3.Text = "SC>10";
                labelb3.ForeColor = System.Drawing.Color.Red;
            }
            if (_firstsc < 20)
            {
                labelb4.ForeColor = System.Drawing.Color.Red;
                labelb4.Text = "SC>20";
            }
        }

        public Skin()
        {
            InitializeComponent();
            //在初始化时加载
            SetWindowRegion();

            //初始化小鸟
            _bird[0] = new Bird(BirdColor.yellow, State.formal);
            _bird[0].BirdStartPosition = new Point(0, 0);
            _bird[1] = new Bird(BirdColor.blue, State.formal);
            _bird[1].BirdStartPosition = new Point(0, 0);
            _bird[2] = new Bird(BirdColor.red, State.formal);
            _bird[2].BirdStartPosition = new Point(0, 0);
            _bird[3] = new Bird(BirdColor.black, State.formal);
            _bird[3].BirdStartPosition = new Point(0, 0);

            //不显示选择框
            pictureBoxBg1.Visible = false;
            pictureBoxBg2.Visible = false;
            pictureBoxBg3.Visible = false;
            pictureBoxBg4.Visible = false;
        }

        //关闭窗体
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerBirdMove_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                _bird[i].BirdMove(State.formal);

            pictureBoxBird1.Refresh();
            pictureBoxBird2.Refresh();
            pictureBoxBird3.Refresh();
            pictureBoxBird4.Refresh();
            //选择框
            showCheck(_nowBirdColor);
        }

        private void pictureBoxBird1_Paint(object sender, PaintEventArgs e)
        {
            _bird[0].DrawBird(e.Graphics);
        }

        private void pictureBoxBird2_Paint(object sender, PaintEventArgs e)
        {
            _bird[1].DrawBird(e.Graphics);
        }

        private void pictureBoxBird3_Paint(object sender, PaintEventArgs e)
        {
            _bird[2].DrawBird(e.Graphics);
        }

        private void pictureBoxBird4_Paint(object sender, PaintEventArgs e)
        {
            _bird[3].DrawBird(e.Graphics);
        }

        private void pictureBoxBird1_Click(object sender, EventArgs e)
        {
            _nowBirdColor = BirdColor.yellow;
        }

        private void pictureBoxBird2_Click(object sender, EventArgs e)
        {
            _nowBirdColor = BirdColor.blue;
        }

        private void pictureBoxBird3_Click(object sender, EventArgs e)
        {
            if (_firstsc >= 10)
                _unlocked = true;
            else
                _unlocked = false;

            if (_unlocked == true)
                _nowBirdColor = BirdColor.red;
            else
                labelb3.Text = "SC>10";
        }

        private void pictureBoxBird4_Click(object sender, EventArgs e)
        {
            if (_firstsc >= 20)
                _unlocked = true;
            else
                _unlocked = false;

            if (_unlocked == true)
                _nowBirdColor = BirdColor.black;
            else
                labelb4.Text = "SC>20";
        }
    }
}
