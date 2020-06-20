using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace FlappyBird
{
    public partial class FormMain : Form
    {
        //获取当前时间（小时）
        private int nowHour=Convert.ToInt32(DateTime.Now.Hour.ToString());
        //屏幕长宽
        private int _width = Screen.PrimaryScreen.Bounds.Width;
        private int _height = Screen.PrimaryScreen.Bounds.Height;
        //计分器生成
        private Score score = new Score();
        //当前分数
        private int _nowSc = 0;
        //暂停/进行中状态
        private bool _pauseFlag = false;
        //小鸟颜色
        private static BirdColor _nowColor = BirdColor.yellow;

        //生成
        private Bird _bird = new Bird(_nowColor, State.formal);
        //屏幕中一共会显示三根管子，创建管子数组
        private Pipe[] _pipe = new Pipe[3];
        //前三最高分
        private int _first = 0;
        private int _second = 0;
        private int _third = 0;

        //=====================================================================
        //声明API函数
        //声明INI文件的写操作函数 WritePrivateProfileString()
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        //声明INI文件的读操作函数 WritePrivateProfileString()
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        
        //创建ini文件方法
        private void iniWirte()
        {
            string s = System.Windows.Forms.Application.ExecutablePath;
            //取得config.ini路径
            string path = s.ToLower().Replace("flappybird.exe", "config.ini");
            //MessageBox.Show(path);

            WritePrivateProfileString("bird", "birdColor",  _nowColor.ToString(), path);
            WritePrivateProfileString("score", "first", _first.ToString(), path);
            WritePrivateProfileString("score", "second", _second.ToString(), path);
            WritePrivateProfileString("score", "third", _third.ToString(), path);
        }

        //读取ini方法
        private void iniRead()
        {
            string s = System.Windows.Forms.Application.ExecutablePath;
            //取得config.ini路径
            string path = s.ToLower().Replace("flappybird.exe", "config.ini");
            if (System.IO.File.Exists(path))//判断是否存在
            {
                //读取.ini文件：DWORD GetPrivateProfileString(LPCTSTR lpAppName,LPCTSTR lpKeyName,LPCTSTR lpDefaut,LPSTR lpReturnedString,DWORD nSize,LPCTSTR lpFileName);
                //其中个参数的意思：
                //LPCTSTR lpAppName ------- INI文件中的一个字段名//
                //LPCTSTR lpKeyName -------- lpAppName 下的一个键名，也就是里面具体的变量名
                //LPCTSTR lpString ---------是键值，也就是变量的值， 必须为LPCTSTR或CString类型
                //LPCTSTR lpFileName --------完整的INI文件路径名
                //LPCTSTR lpDefaut ----------如果没有其前两个参数值，则将此值赋给变量
                //LPSTR lpReturnedString --------接收INI文件中的值的CString对象，即接收缓冲区
                //DWORD nSize ------接收缓冲区的大小

                StringBuilder str = new StringBuilder(255);
                GetPrivateProfileString("bird", "birdcolor", "", str, 255, path);
                //string->enum强制转换
                _nowColor =(BirdColor)Enum.Parse(typeof(BirdColor),str.ToString());

                StringBuilder str2 = new StringBuilder(255);
                GetPrivateProfileString("score", "first", "", str2, 255, path);
                _first = Convert.ToInt32(str2.ToString());
                StringBuilder str3 = new StringBuilder(255);
                GetPrivateProfileString("score", "second", "", str3, 255, path);
                _second = Convert.ToInt32(str3.ToString());
                StringBuilder str4 = new StringBuilder(255);
                GetPrivateProfileString("score", "third", "", str4, 255, path);
                _third = Convert.ToInt32(str4.ToString());
            }
        }

        //自定义类方法：播放声音文件
        public void PlaySound(String wavFile)
        {
            //装载声音文件（System.Media）
            SoundPlayer soundPlay = new SoundPlayer(wavFile);
            //使用新线程播放声音
            soundPlay.Play();
        }

        public void BackgroungMusic()
        {
            string path = System.Windows.Forms.Application.ExecutablePath;
            string soundpath = path.Replace("FlappyBird.EXE", "sound/bgm.mp3");
            soundpath = soundpath.Replace("/", @"\");
            axWindowsMediaPlayer1.URL = soundpath;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            //循环播放
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        public FormMain()
        {
            InitializeComponent();

            //读取ini
            iniRead();
            
            //设置游戏区和引导不可见
            pictureBoxGame.Visible = false;
            pictureBoxGuide.Visible = false;
            //启动道路移动效果
            timerRoadMove.Enabled = true;
            //暂停按钮不可见
            buttonPauseStart.Visible = false;
            buttonPauseStart.Enabled = false;

            //如果当前时间在6到19点之间，用白天背景，反之是夜晚
            if (nowHour > 6 && nowHour < 19)
                this.BackgroundImage = (Properties.Resources.day);
            else
                this.BackgroundImage = (Properties.Resources.night);

            //播放背景音乐
            BackgroungMusic();
        }

        //开始按钮
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //播放声音文件
            PlaySound("sound/flappy2.wav");
            //生成
            _bird = new Bird(_nowColor, State.formal);
            //首页按钮失效
            buttonStart.Enabled = false;
            buttonScore.Enabled = false;
            buttonSkin.Enabled = false;
            buttonExit.Enabled = false;

            //显示游戏区和引导
            pictureBoxGame.Visible = true;
            pictureBoxGame.Enabled = true;
            pictureBoxGuide.Visible = true;

            //暂停按钮可见
            buttonPauseStart.Visible = true;
            buttonPauseStart.Enabled = false;

            //小鸟移动效果开启
            timerBirdmove.Enabled = true;
            //暂停/进行中状态
            _pauseFlag = false;
            
            //准备好初始管子
            for (int i=0;i<3;i++)
                _pipe[i]=new Pipe();
            _pipe[1].PipePosition = new Point(450, -200);
            _pipe[2].PipePosition = new Point(650, -130);

            //起始位置            
            score.Location = new Point(this.Location.X + 170, this.Location.Y + 45);
            score.Show();
        }

        //道路移动动画Timer
        private void timerRoadMove_Tick(object sender, EventArgs e)
        {
            //移动坐标造成道路前进效果
            if (pictureBoxRoad.Location == new Point(0, 448))
            {
                pictureBoxRoad.Location = new Point(-20, 448);
                pictureBoxTitle.Location = new Point(82, 115);
            }
            else
            {
                pictureBoxRoad.Location = new Point(0, 448);
                pictureBoxTitle.Location = new Point(82, 125);
            }
        }

        //游戏区绘制
        private void pictureBoxGame_Paint(object sender, PaintEventArgs e)
        {
            //绘制小鸟
            _bird.DrawBird(e.Graphics);
            //分别绘制管子
            for (int i = 0; i < 3;i++ )
                _pipe[i].DrawPipe(e.Graphics);
            
        }

        //小鸟移动动画Timer
        private void timerBirdmove_Tick(object sender, EventArgs e)
        {
            //判断是否结束
            if (_bird.isGameOver(_bird.BirdStartPosition, _pipe[0].PipePosition, 45) || _bird.isGameOver(_bird.BirdStartPosition, _pipe[1].PipePosition, 45) || _bird.isGameOver(_bird.BirdStartPosition, _pipe[2].PipePosition, 45)
                || _pipe[0].isBlock(_pipe[0].PipePosition, _bird.BirdStartPosition) == false || _pipe[1].isBlock(_pipe[1].PipePosition, _bird.BirdStartPosition) == false || _pipe[2].isBlock(_pipe[2].PipePosition, _bird.BirdStartPosition) == false)
            {
                //播放声音文件
                PlaySound("sound/crash.wav");

                //停止计时器
                timerRoadMove.Stop();
                _pipe[0].TimerPipeMove.Stop();
                _pipe[1].TimerPipeMove.Stop();
                _pipe[2].TimerPipeMove.Stop();
                //停止计分
                score.timerRefresh.Enabled = false;

                //改变小鸟当前状态
                _bird.NowState = State.end;
                //使鼠标点击事件失效
                pictureBoxGame.Enabled = false;
                //禁用暂停按钮
                buttonPauseStart.Enabled = false;

                //小鸟掉落动画
                _bird.BirdMove(_bird.NowState);
                pictureBoxGame.Refresh();//刷新游戏区

                if (_bird.BirdStartPosition.Y > 405)
                {
                    timerBirdmove.Stop();

                    //与最高分比较,写入成绩
                    if (_nowSc > _first)
                    {
                        _third = _second;
                        _second = _first;
                        _first = _nowSc;
                    }
                    else if (_nowSc > _second && _nowSc < _first)
                    {
                        _third = _second;
                        _second = _nowSc;
                    }
                    else if (_nowSc > _third && _nowSc < _second)
                        _third = _nowSc;

                    //写入ini
                    iniWirte();

                    //打开最终计分板
                    ScoreBoard scboard = new ScoreBoard();
                    scboard._BestSc = _first;
                    scboard._Score = _nowSc;
                    scboard.ShowDialog();
                    if (scboard.OpenFlag == false)
                    {
                        //重新初始化游戏内容
                        timerRoadMove.Enabled = true;
                        pictureBoxGame.Visible = false;
                        buttonStart.Enabled = true;
                        buttonScore.Enabled = true;
                        buttonSkin.Enabled = true;
                        buttonExit.Enabled = true;
                        buttonPauseStart.Visible = false;
                        _bird.BirdStartPosition = new Point(80, 200);
                        _bird.NowState = State.formal;
                        _bird.Speed = 0;
                        score.Visible = false;
                        score._Score = 0;
                        _nowSc = 0;
                        score.scoreNum(0);
                    }
                }
            }
            else
            {
                //计算分数
                for (int i = 0; i < 3; i++)
                {
                    if (_pipe[i]._canScore == true && _bird.BirdStartPosition.X > _pipe[i].PipePosition.X)
                    {
                        _pipe[i]._canScore=false;
                        _nowSc++;
                        PlaySound("sound/score.wav");
                    }

                }
                //改变计分器数字
                score._Score = _nowSc;

                _bird.BirdMove(_bird.NowState);
                pictureBoxGame.Refresh();//刷新游戏区

                //如果大于7分，管子开始移动，进入困难模式
                if (_nowSc > 5)
                {
                    for (int i = 0; i < 3; i++)
                        _pipe[i]._HardFlag = true;
                }
            }
        }

        //游戏区内点击事件
        private void pictureBoxGame_Click(object sender, EventArgs e)
        {
            //强制转换
            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            if (Mouse_e.Button == MouseButtons.Left)
            {
                //第一次点击后，管子开始运动
                if (pictureBoxGuide.Visible == true)
                {
                    for (int i = 0; i < 3; i++)
                        _pipe[i].Start();

                    //启动计分器timer
                    score.timerRefresh.Enabled = true;
                    //暂停按钮可用
                    buttonPauseStart.Enabled = true;

                    //引导不可见
                    pictureBoxGuide.Visible = false;
                    _bird.NowState = State.move;//改变模式
                }

                //每次点击，小鸟上升，重力速度重新开始
                _bird.Speed = -16;
            }
            else if (Mouse_e.Button == MouseButtons.Right)
            {
                //设置管子横向速度
                _pipe[0]._SpeedX = 20;
                _pipe[1]._SpeedX = 20;
                _pipe[2]._SpeedX = 20;
            }
        }

        //皮肤功能按钮
        private void buttonSkin_Click(object sender, EventArgs e)
        {
            //播放声音文件
            PlaySound("sound/flappy2.wav");
            //新建皮肤选择对话框
            Skin skin = new Skin();
            skin.NowBirdColor = _nowColor;
            skin._Firstsc = _first;
            if (skin.ShowDialog(this) == DialogResult.OK)
            {
                _nowColor = skin.NowBirdColor;
            }

            //写入ini
            iniWirte();
        }

        //暂停/开始按钮
        private void buttonPauseStart_Click(object sender, EventArgs e)
        {
            if (_pauseFlag==false)
            {
                _bird.NowState = State.pause;

                //停止计时器
                timerRoadMove.Stop();
                _pipe[0].TimerPipeMove.Stop();
                _pipe[1].TimerPipeMove.Stop();
                _pipe[2].TimerPipeMove.Stop();
                //停止计分
                score.timerRefresh.Enabled = false;
                //禁用游戏区
                pictureBoxGame.Enabled = false;
                _pauseFlag = true;
                buttonPauseStart.BackgroundImage = Properties.Resources.restart;
            }

            else if (_pauseFlag == true)
            {
                _bird.NowState = State.move;

                //启动计时器
                timerRoadMove.Start();
                _pipe[0].TimerPipeMove.Start();
                _pipe[1].TimerPipeMove.Start();
                _pipe[2].TimerPipeMove.Start();
                //继续计分
                score.timerRefresh.Enabled = true;
                //启用游戏区
                pictureBoxGame.Enabled = true;

                _pauseFlag = false;
                buttonPauseStart.BackgroundImage = Properties.Resources.pause;  
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            //空格等同于暂停(在不死亡时)
            if (e.KeyCode == Keys.Space&&_bird.NowState!=State.end)
            {
                //设置KeyPreview=true，触发formMain的keyDown事件
                buttonPauseStart_Click(sender, e);
            }
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            //新建最高分对话框
            //播放声音文件
            PlaySound("sound/flappy2.wav");
            HighestScore _highestSc = new HighestScore();
            _highestSc._First = _first;
            _highestSc._Second = _second;
            _highestSc._Third = _third;

            _highestSc.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Move(object sender, EventArgs e)
        {
            //实现子窗体score随父窗体移动而移动的效果
            score.Location = new Point(this.Location.X+170, this.Location.Y + 45);
        }

    }
}
