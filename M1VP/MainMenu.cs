using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M1VP
{
    public partial class MainMenu : Form
    {
        public Login formLogin;
        public MainMenu(Login formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Player player = this.formLogin.data.CurrentPlayer;
            labelCaptain.Text = "Welcome, Captain " + player.captainName + "!";
            labelScore.Text = "SCORE: " + player.score;
            labelWin.Text = "WIN: " + player.win;
            labelLose.Text = "LOSE: " + player.lose;
            labelDouble.Text = "DOUBLE TOKEN: " + player.doubleScore;
        }

        public void RefreshStatus()
        {
            Player player = this.formLogin.data.CurrentPlayer;
            labelCaptain.Text = "Welcome, Captain " + player.captainName + "!";
            labelScore.Text = "SCORE: " + player.score;
            labelWin.Text = "WIN: " + player.win;
            labelLose.Text = "LOSE: " + player.lose;
            labelDouble.Text = "DOUBLE TOKEN: " + player.doubleScore;
        }

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && this.formLogin.data.CurrentPlayer != null)
            {
                RefreshStatus();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.formLogin.data.CurrentPlayer = null;

            this.formLogin.Show();
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (this.formLogin.data.ListPlayer.Count < 2)
            {
                MessageBox.Show("Minimal harus ada 2 player yang terdaftar untuk memulai battle!");
                return;
            }

            Battle battleForm = new Battle(this);
            battleForm.Show();
            this.Hide();

        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboardForm = new Leaderboard(this);
            leaderboardForm.Show();
            this.Hide();
        }
    }
}
