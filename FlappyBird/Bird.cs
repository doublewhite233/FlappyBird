using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;//(Point)
using System.Windows.Forms;//(Screen)

namespace FlappyBird
{
    //枚举类型：小鸟颜色
    public enum BirdColor
    {
        yellow, blue, red, black
    }
    //枚举类型：游戏状态
    public enum State
    {
        pause, move, end, formal
    }

    class Bird
    {
        //起始位置
        private Point _birdStartPosition = new Point(80,200);
        //小鸟位图数组
        private Bitmap[] _birdBmp = new Bitmap[10];
        //当前小鸟位图
        private Bitmap _nowBirdBmp = new Bitmap(48, 48);
        //点击后小鸟上升及下降速度，模拟重力效果，初始为0
        private int _speed = 0;
        //小鸟状态
        private State _nowState=State.formal;
        //小鸟位图是否初次显示
        private bool _firstFlag = true;

        public Point BirdStartPosition
        {
            get { return _birdStartPosition; }
            set { _birdStartPosition = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public State NowState
        {
            get { return _nowState; }
            set { _nowState = value; }
        }

        //
        public Bird(BirdColor bColor, State _state)
        {
            if (bColor == BirdColor.yellow)
            {
                //装载黄色小鸟位图
                _birdBmp[0] = new Bitmap("image/bird/yellow1.png");
                _birdBmp[1] = new Bitmap("image/bird/yellow2.png");
                _birdBmp[2] = new Bitmap("image/bird/yellow3.png");
                _birdBmp[3] = new Bitmap("image/bird/yellow4.png");
                _birdBmp[4] = new Bitmap("image/bird/yellow5.png");
                _birdBmp[5] = new Bitmap("image/bird/yellow6.png");
                _birdBmp[6] = new Bitmap("image/bird/yellow7.png");
                _birdBmp[7] = new Bitmap("image/bird/yellow8.png");
                _birdBmp[8] = new Bitmap("image/bird/yellow9.png");
                _birdBmp[9] = new Bitmap("image/bird/yellow10.png");
            }
            if (bColor == BirdColor.blue)
            {
                //装载蓝色小鸟位图
                _birdBmp[0] = new Bitmap("image/bird/blue1.png");
                _birdBmp[1] = new Bitmap("image/bird/blue2.png");
                _birdBmp[2] = new Bitmap("image/bird/blue3.png");
                _birdBmp[3] = new Bitmap("image/bird/blue4.png");
                _birdBmp[4] = new Bitmap("image/bird/blue5.png");
                _birdBmp[5] = new Bitmap("image/bird/blue6.png");
                _birdBmp[6] = new Bitmap("image/bird/blue7.png");
                _birdBmp[7] = new Bitmap("image/bird/blue8.png");
                _birdBmp[8] = new Bitmap("image/bird/blue9.png");
                _birdBmp[9] = new Bitmap("image/bird/blue10.png");
            }
            if (bColor == BirdColor.red)
            {
                //装载红色小鸟位图
                _birdBmp[0] = new Bitmap("image/bird/red1.png");
                _birdBmp[1] = new Bitmap("image/bird/red2.png");
                _birdBmp[2] = new Bitmap("image/bird/red3.png");
                _birdBmp[3] = new Bitmap("image/bird/red4.png");
                _birdBmp[4] = new Bitmap("image/bird/red5.png");
                _birdBmp[5] = new Bitmap("image/bird/red6.png");
                _birdBmp[6] = new Bitmap("image/bird/red7.png");
                _birdBmp[7] = new Bitmap("image/bird/red8.png");
                _birdBmp[8] = new Bitmap("image/bird/red9.png");
                _birdBmp[9] = new Bitmap("image/bird/red10.png");
            }
            if (bColor == BirdColor.black)
            {
                //装载黑色小鸟位图
                _birdBmp[0] = new Bitmap("image/bird/black1.png");
                _birdBmp[1] = new Bitmap("image/bird/black2.png");
                _birdBmp[2] = new Bitmap("image/bird/black3.png");
                _birdBmp[3] = new Bitmap("image/bird/black4.png");
                _birdBmp[4] = new Bitmap("image/bird/black5.png");
                _birdBmp[5] = new Bitmap("image/bird/black6.png");
                _birdBmp[6] = new Bitmap("image/bird/black7.png");
                _birdBmp[7] = new Bitmap("image/bird/black8.png");
                _birdBmp[8] = new Bitmap("image/bird/black9.png");
                _birdBmp[9] = new Bitmap("image/bird/black10.png");
            }
            //初始位图
            _nowBirdBmp = _birdBmp[1];
        }

        //小鸟移动
        public void BirdMove(State _state)
        {
            //每次处在速度交界点，准备换图片
            if (_speed == 0)
            {
                _nowBirdBmp = _birdBmp[0];
                //模拟上升或下降过程
                _birdStartPosition.Y = _birdStartPosition.Y + _speed;
                _speed = _speed + 2;
                _firstFlag = true;
            }
            //formal:未开始游戏,保持一定范围内水平飞行
            if (_state == State.formal)
            {
                if (_nowBirdBmp == _birdBmp[0])
                {
                    _nowBirdBmp = _birdBmp[1];
                }
                else if (_nowBirdBmp == _birdBmp[1])
                {
                    _nowBirdBmp = _birdBmp[2];
                }
                else
                {
                    _nowBirdBmp = _birdBmp[0];
                }
            }
            //move游戏开始,且处于上升状态
            if (_state == State.move && _speed < 0)
            {
                if (_firstFlag == true)
                {
                    _nowBirdBmp = _birdBmp[4];//设置初始图
                    _firstFlag = false;
                }

                if (_nowBirdBmp == _birdBmp[3])
                {
                    _nowBirdBmp = _birdBmp[4];
                }
                else if (_nowBirdBmp == _birdBmp[4])
                {
                    _nowBirdBmp = _birdBmp[5];
                }
                else
                {
                    _nowBirdBmp = _birdBmp[3];
                }

                //模拟上升或下降过程
                _birdStartPosition.Y = _birdStartPosition.Y + _speed;
                _speed = _speed + 2;
            }

            //move游戏开始,且处于下降状态
            if (_state == State.move && _speed > 0)
            {
                if (_firstFlag == true)
                {
                    _nowBirdBmp = _birdBmp[7];//设置初始图
                    _firstFlag = false;
                }

                if (_nowBirdBmp == _birdBmp[6])
                {
                    _nowBirdBmp = _birdBmp[7];
                }
                else if (_nowBirdBmp == _birdBmp[7])
                {
                    _nowBirdBmp = _birdBmp[8];
                }
                else
                {
                    _nowBirdBmp = _birdBmp[6];
                }

                //模拟上升或下降过程
                _birdStartPosition.Y = _birdStartPosition.Y + _speed;
                _speed = _speed + 2;
            }
            //end:撞到柱子，游戏结束
            if (_state == State.end)
            {
                _nowBirdBmp = _birdBmp[9];
                //小鸟掉落
                _birdStartPosition.Y = _birdStartPosition.Y + _speed;
                _speed = _speed + 2;
            }
            //pause:游戏暂停
            if (_state == State.pause)
            {

            }
        }

        //绘制小鸟
        public void DrawBird(Graphics g)
        {
            g.DrawImage(_nowBirdBmp, _birdStartPosition);
        }

        //碰撞检测 判断游戏是否结束
        public bool isGameOver(Point _birdPoint, Point _pipePoint, int _birdR)
        {
            if ((_birdPoint.X + _birdR > _pipePoint.X && _birdPoint.X < _pipePoint.X + 50) && ((_birdPoint.Y > _pipePoint.Y && _birdPoint.Y < _pipePoint.Y + 305) || (_birdPoint.Y > _pipePoint.Y + 455 - _birdR)) || (_birdPoint.Y >= 380))
                return true;
            else
                return false;
        }

    }
}
