using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Timers;//Timer

namespace FlappyBird
{
    class Pipe
    {
        //管子位置
        private Point _pipePosition = new Point(250, -100);
        //管子位图数组
        private Bitmap[] _pipeBmp = new Bitmap[2];
        //障碍物
        private Bitmap _block = new Bitmap("image/pipe/block.png");
        //障碍物位置
        private Point _blockPosition = new Point(250, -200);
        //System.Timers.timer
        private Timer timerPipeMove;
        //水平移动速度，模拟加速效果
        private int _speedX = 0;
        //width=52;height=320
        //困难模式
        private bool _hardMove =false;
        //困难上下方向
        private bool _hardUp = false;
        //困难开启标志
        private bool _hardFlag = false;
        public bool _canScore = true;

        public bool _HardFlag
        {
            get { return _hardFlag; }
            set { _hardFlag = value; }
        }

        public bool _HardMove
        {
            get { return _hardMove; }
            set { _hardMove = value; }
        }

        public Timer TimerPipeMove
        {
            get { return timerPipeMove; }
            set { timerPipeMove = value; }
        }
        
        public Point PipePosition
        {
            get { return _pipePosition; }
            set { _pipePosition = value; }
        }

        public int _SpeedX
        {
            get { return _speedX; }
            set { _speedX = value; }
        }

        public Pipe()
        {
            //装载柱子位图
            _pipeBmp[0] = new Bitmap("image/pipe/pipeup.png");
            _pipeBmp[1] = new Bitmap("image/pipe/pipedown.png");
        }

        //随机生成管子位置和障碍位置
        public void RandomLocation()
        {
            //初始化障碍图片
            _block = new Bitmap("image/pipe/block.png");
            Random rand = new Random();
            int r=rand.Next(-260, -49);//生成-260到-50的随机数
            _pipePosition.Y = r;

            int r2 = rand.Next(0, 10);
            if (r2 > 5)
                _blockPosition=new Point(_pipePosition.X,_pipePosition.Y+340);
            else
                _blockPosition = new Point(_pipePosition.X, _pipePosition.Y-50);
        }

        //管子绘制,障碍绘制
        public void DrawPipe(Graphics g)
        {
            g.DrawImage(_pipeBmp[0],_pipePosition);
            g.DrawImage(_pipeBmp[1], new Point(_pipePosition.X,_pipePosition.Y+450));

            g.DrawImage(_block, _blockPosition);
        }

        //管子开始横向运动
        public void Start()
        {
            //设置timer间隔
            timerPipeMove = new Timer(50);
            //timer事件
            timerPipeMove.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //开始计时
            timerPipeMove.Enabled = true;
        }

        //Timer定时更新的事件
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //横向位置移动
            if (_speedX > 0)
            {
                _pipePosition.X = _pipePosition.X - 5 - _speedX;
                _blockPosition.X = _blockPosition.X - 5 - _speedX;
                _speedX=_speedX-3;
            }
            else
            {
                _pipePosition.X = _pipePosition.X - 5;
                _blockPosition.X = _blockPosition.X - 5;
            }

            //如果管子从屏幕左侧消失，则从右侧重新开始并生成随机位置
            if (_pipePosition.X < -160)
            {
                _pipePosition.X = 450;
                RandomLocation();
                _canScore = true;
                if (_hardFlag == true)
                {
                    hardMove();
                }
            }

            if (_hardMove == true&&_hardUp==false)
            {
                _pipePosition.Y = _pipePosition.Y + 1;
                _blockPosition.Y = _blockPosition.Y + 1;
            }
            if (_hardMove == true && _hardUp ==true)
            {
                _pipePosition.Y = _pipePosition.Y - 1;
                _blockPosition.Y = _blockPosition.Y - 1;
            }
        }

        //判断是否成功冲过障碍
        public bool isBlock(Point _pipePos,Point _birdPos)
        {
            if (_blockPosition.Y > _pipePos.Y &&_birdPos.X+35>=_pipePos.X&&_birdPos.X<=_pipePos.X+40)
            {
                if (_speedX <= 0)
                    return false;
                else
                {
                    _block = new Bitmap("image/pipe/block2.png");
                    return true;
                }
            }
            return true;
        }

        //Hard：管子水平运动
        public void hardMove()
        {
            Random rand = new Random();
            int r = rand.Next(0, 10);
            if (r > 3)
            {
                _hardMove = true;
                if (_hardMove == true && _pipePosition.Y > -150)
                    _hardUp = true;
                else if (_hardMove == true && _pipePosition.Y <= -150)
                    _hardUp = false;
            }
            else _hardMove = false;
        }

    }
}
