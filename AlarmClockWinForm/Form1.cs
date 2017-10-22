using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClockWinForm
{
    public partial class Form1 : Form
    {
        //当前时、分、秒
        private static int hour;
        private static int minute;
        private static int second;
        //用户设置的时、分
        private static int userSetHour;
        private static int userSetMinute;

        private System.Timers.Timer timer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();
            //禁止窗口最大化
            this.MaximizeBox = false;
            //获取当前时间
            getNowTime();
            //更新时间
            showSetTimeLabel.Text = hour + ":" + minute;
            setTimeMinute.Value = minute;
            setTimeHour.Value = hour;
            setTimeToForm();
            //设置timer可用
            timer.Enabled = true;
            //设置timer
            timer.Interval = 1000;
            //设置是否重复计时，如果该属性设为False,则只执行timer_Elapsed方法一次。
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            setTimeToForm();
        }

        private void setTimeToForm()
        {
            //秒钟跳到60则换为0；分钟、时钟同理
            if (++second >= 60)
            {
                minute++;
                second = 0;
            }
            if (minute >= 60)
            {
                hour++;
                minute = 0;
            }
            if (hour >= 24)
            {
                hour = 0;
            }

            string hourStr = hour.ToString(),
                minuteStr = minute.ToString(),
                secondStr = second.ToString();
            //为时分秒未满10的字符串前加0，例9改为09
            if (hour < 10) hourStr = "0" + hour.ToString();
            if (minute < 10) minuteStr = "0" + minute.ToString();
            if (second < 10) secondStr = "0" + second.ToString();
            //显示在控件中
            SetTB(hourStr + ":" + minuteStr + ":" + secondStr);
        }

        public void getNowTime()
        {
            //获取当前时分秒
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }

        private delegate void SetTBMethodInvok(string value);
        private void SetTB(string value)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new SetTBMethodInvok(SetTB), value);
                }
                catch (Exception ex)
                {
                    //补偿程序退出时的一个错误
                    Application.Exit();
                }
            }
            else
            {
                showNowTimeLabel.Text = value;
                //判断当前时、分等于用户设置的时、分，并且秒钟等于0
                if (hour == userSetHour && minute == userSetMinute && second == 0)
                {
                    //播放音乐
                    System.Media.SoundPlayer sp = new SoundPlayer();
                    sp.SoundLocation = @"../../Sounds/zouma.wav";
                    sp.PlayLooping();
                    if (MessageBox.Show("时间到了！", "", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        //用户点击确认后停止播放
                        sp.Stop();
                    }
                }

            }
        }

        private void setTimeMinute_ValueChanged(object sender, EventArgs e)
        {
            //设置秒钟的文本框输入值为60的时候自动跳为0，-1时跳为59，下面时钟同理。
            switch (setTimeMinute.Value.ToString())
            {
                case "-1":
                    setTimeMinute.Value = 59; break;
                case "60":
                    setTimeMinute.Value = 0; break;
            }
        }

        private void setTimeHour_ValueChanged(object sender, EventArgs e)
        {
            //原理同上
            switch (setTimeHour.Value.ToString())
            {
                case "-1":
                    setTimeHour.Value = 23; break;
                case "24":
                    setTimeHour.Value = 0; break;
            }
        }

        private void setClockButton_Click(object sender, EventArgs e)
        {
            //获取用户输入的分钟值和时钟值
            userSetHour = int.Parse(setTimeHour.Value.ToString());
            userSetMinute = int.Parse(setTimeMinute.Value.ToString());
            //转换为字符串
            string hourStr = userSetHour.ToString(),
               minuteStr = userSetMinute.ToString();
            //为时分秒未满10的字符串前加0，例9改为09。
            if (userSetHour < 10) hourStr = "0" + userSetHour.ToString();
            if (userSetMinute < 10) minuteStr = "0" + userSetMinute.ToString();
            //显示在控件上
            showSetTimeLabel.Text = hourStr + ":" + minuteStr;
        }
    }
}
