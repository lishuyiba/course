using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05猜拳游戏
{
    public partial class CaiQuan : Form
    {
        public CaiQuan()
        {
            InitializeComponent();
        }

        #region 代码未优化前
        //private void btnStone_Click(object sender, EventArgs e)
        //{
        //    string fist = "石头";
        //    Player player = new Player();
        //    int pfist= player.ShowFist(fist);

        //    Computer computer = new Computer();
        //    int cfist = computer.ShowFist();

        //    lblYou.Text = player.FistName;
        //    lblComputer.Text = computer.FistName;

        //    UserState state= CaiPan.IsPlayerWin(pfist,cfist);
        //    if (state==UserState.PlayerWin)
        //    {
        //        lblResult.Text = "You Win";
        //    }
        //    else if (state == UserState.ComputerWin)
        //    {
        //        lblResult.Text = "You Lose";
        //    }
        //    else
        //    {
        //        lblResult.Text = "平手";
        //    }

        //}

        //private void btnJianDao_Click(object sender, EventArgs e)
        //{
        //    string fist = "剪刀";
        //    Player player = new Player();
        //    int pfist = player.ShowFist(fist);

        //    Computer computer = new Computer();
        //    int cfist = computer.ShowFist();

        //    lblYou.Text = player.FistName;
        //    lblComputer.Text = computer.FistName;

        //    UserState state = CaiPan.IsPlayerWin(pfist, cfist);
        //    if (state == UserState.PlayerWin)
        //    {
        //        lblResult.Text = "You Win";
        //    }
        //    else if (state == UserState.ComputerWin)
        //    {
        //        lblResult.Text = "You Lose";
        //    }
        //    else
        //    {
        //        lblResult.Text = "平手";
        //    }
        //}

        //private void btnBu_Click(object sender, EventArgs e)
        //{
        //    string fist = "布";
        //    Player player = new Player();
        //    int pfist = player.ShowFist(fist);

        //    Computer computer = new Computer();
        //    int cfist = computer.ShowFist();

        //    lblYou.Text = player.FistName;
        //    lblComputer.Text = computer.FistName;

        //    UserState state = CaiPan.IsPlayerWin(pfist, cfist);
        //    if (state == UserState.PlayerWin)
        //    {
        //        lblResult.Text = "You Win";
        //    }
        //    else if (state == UserState.ComputerWin)
        //    {
        //        lblResult.Text = "You Lose";
        //    }
        //    else
        //    {
        //        lblResult.Text = "平手";
        //    }
        //}
        #endregion

        #region 代码优化方法一
        //private void btnStone_Click(object sender, EventArgs e)
        //{
        //    string fist = "石头";
        //    StartGam(fist);

        //}

        //private void btnJianDao_Click(object sender, EventArgs e)
        //{
        //    string fist = "剪刀";
        //    StartGam(fist);
        //}

        //private void btnBu_Click(object sender, EventArgs e)
        //{
        //    string fist = "布";
        //    StartGam(fist);
        //}
        #endregion

        #region 代码优化方法三
        private void btnStone_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            StartGam(btn.Text);

        }       
        #endregion

        #region 提取方法 -void StartGam(string fist)
        private void StartGam(string fist)
        {
            Player player = new Player();
            int pfist = player.ShowFist(fist);

            Computer computer = new Computer();
            int cfist = computer.ShowFist();

            lblYou.Text = player.FistName;
            lblComputer.Text = computer.FistName;

            UserState state = CaiPan.IsPlayerWin(pfist, cfist);
            if (state == UserState.PlayerWin)
            {
                lblResult.Text = "You Win";
            }
            else if (state == UserState.ComputerWin)
            {
                lblResult.Text = "You Lose";
            }
            else
            {
                lblResult.Text = "平手";
            }
        }
        #endregion
        
    }
}
