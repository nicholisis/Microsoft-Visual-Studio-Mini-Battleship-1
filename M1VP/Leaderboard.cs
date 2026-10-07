using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M1VP
{
    public partial class Leaderboard : Form
    {
        private MainMenu formMenu;
        private List<Player> displayList = new List<Player>();
        public Leaderboard(MainMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            MuatDataLeaderboard();
        }

        private void MuatDataLeaderboard()
        {
            displayList.Clear();
            listLeaderboard.Items.Clear();

            foreach (Player p in this.formMenu.formLogin.data.ListPlayer)
            {
                displayList.Add(p);
            }

            TampilkanKeListBox();
        }

        private void TampilkanKeListBox()
        {
            listLeaderboard.Items.Clear();
            foreach (Player p in displayList)
            {
                listLeaderboard.Items.Add(p.captainName + " - " + p.score);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < displayList.Count - 1; i++)
            {
                for (int j = 0; j < displayList.Count - 1 - i; j++)
                {
                    if (displayList[j].score < displayList[j + 1].score)
                    {
                        Player temp = displayList[j];
                        displayList[j] = displayList[j + 1];
                        displayList[j + 1] = temp;
                    }
                }
            }

            TampilkanKeListBox();
        }

        private void listLeaderboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLeaderboard.SelectedIndex == -1) return;

            Player selectedPlayer = displayList[listLeaderboard.SelectedIndex];

            string detailMsg = "CAPTAIN DETAIL\n\n" +
                               "Name : " + selectedPlayer.captainName + "\n" +
                               "Username : " + selectedPlayer.username + "\n" +
                               "Gender : " + selectedPlayer.gender + "\n\n" +
                               "Score : " + selectedPlayer.score + "\n" +
                               "Win : " + selectedPlayer.win + "\n" +
                               "Lose : " + selectedPlayer.lose + "\n" +
                               "Double Score Token : " + selectedPlayer.doubleScore;

            MessageBox.Show(detailMsg, "Captain Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listLeaderboard.SelectedIndex = -1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.formMenu.Show();
            this.Close();
        }
    }
}
