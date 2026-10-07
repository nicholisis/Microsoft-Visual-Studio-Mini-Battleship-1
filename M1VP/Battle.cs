using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M1VP
{
    public partial class Battle : Form
    {
        private MainMenu formMenu;
        public Player enemyPlayer;
        public List<int> shipsP1 = new List<int>();
        public List<int> shipsP2 = new List<int>();
        private List<int> currentSelectedShips = new List<int>();
        private int hpP1 = 3;
        private int hpP2 = 3;
        public Player currentTurnPlayer;
        private Random random = new Random();

        private int setupTurn = 1;

        public Battle(MainMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.formMenu.Show();
            this.Close();
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            comboboxChoose.Items.Clear();

            foreach (Player p in this.formMenu.formLogin.data.ListPlayer)
            {
                if (p.username != this.formMenu.formLogin.data.CurrentPlayer.username)
                {
                    comboboxChoose.Items.Add(p.captainName);
                }
            }
        }


        // SETUP KAPAL HAYYUK (groupBox1)
        private void buttonSetup_Click(object sender, EventArgs e)
        {
            if (comboboxChoose.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih lawan terlebih dahulu!");
                return;
            }

            string chosenName = comboboxChoose.SelectedItem.ToString();
            foreach (Player p in this.formMenu.formLogin.data.ListPlayer)
            {
                if (p.captainName == chosenName)
                {
                    this.enemyPlayer = p;
                    break;
                }
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            setupTurn = 1;
            labelSelect.Text = "Captain " + this.formMenu.formLogin.data.CurrentPlayer.captainName + " - select your 3 ships";
            labelPosisi.Text = ": 0 / 3";
        }

        // PILIH POSISI KAPAL HAYYYOUK (groupBox2)
        private void PilihKapal(int posisi, Button btn)
        {
            if (currentSelectedShips.Contains(posisi))
            {
                currentSelectedShips.Remove(posisi);
                btn.BackColor = Color.FromArgb(35, 52, 68);
            }
            else
            {
                if (currentSelectedShips.Count < 3)
                {
                    currentSelectedShips.Add(posisi);
                    btn.BackColor = Color.FromArgb(66, 190, 125);
                }
                else
                {
                    MessageBox.Show("Hanya boleh memilih tepat 3 posisi!");
                }
            }

            labelPosisi.Text = ": " + currentSelectedShips.Count + " / 3";
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            PilihKapal(1, btn01);
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            PilihKapal(2, btn02);
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            PilihKapal(3, btn03);
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            PilihKapal(4, btn04);
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            PilihKapal(5, btn05);
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            PilihKapal(6, btn06);
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            PilihKapal(7, btn07);
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            PilihKapal(8, btn08);
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            PilihKapal(9, btn09);
        }

        // buat reset warna setelah confirm hayyuk
        private void ResetGrid()
        {
            currentSelectedShips.Clear();
            labelPosisi.Text = ": 0 / 3";

            Color defaultColor = Color.FromArgb(35, 52, 68);
            btn01.BackColor = defaultColor;
            btn02.BackColor = defaultColor;
            btn03.BackColor = defaultColor;
            btn04.BackColor = defaultColor;
            btn05.BackColor = defaultColor;
            btn06.BackColor = defaultColor;
            btn07.BackColor = defaultColor;
            btn08.BackColor = defaultColor;
            btn09.BackColor = defaultColor;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (currentSelectedShips.Count != 3)
            {
                MessageBox.Show("Pilih tepat 3 posisi kapal!");
                return;
            }

            if (setupTurn == 1)
            {
                foreach (int pos in currentSelectedShips)
                {
                    shipsP1.Add(pos);
                }

                ResetGrid();

                setupTurn = 2;
                labelSelect.Text = "Captain " + this.enemyPlayer.captainName + " - select your 3 ships";
            }

            else if (setupTurn == 2)
            {
                foreach (int pos in currentSelectedShips)
                {
                    shipsP2.Add(pos);
                }

                ResetGrid();

                groupBox2.Enabled = false;
                groupBox4.Enabled = true;

                MulaiPertarungan();
            }
        }

        // BATTLE STATUS (groupBox3)
        private void MulaiPertarungan()
        {
            hpP1 = 3;
            hpP2 = 3;

            comboboxTarget.Items.Clear();
            for (int i = 1; i <= 9; i++)
            {
                comboboxTarget.Items.Add(i.ToString());
            }

            radioNormalShot.Checked = true;

            int acak = random.Next(0, 2);
            if (acak == 0)
            {
                currentTurnPlayer = this.formMenu.formLogin.data.CurrentPlayer;
            }
            else
            {
                currentTurnPlayer = this.enemyPlayer;
            }

            UpdateBattleStatus();
        }

        public void UpdateBattleStatus()
        {
            Player p1 = this.formMenu.formLogin.data.CurrentPlayer;
            Player p2 = this.enemyPlayer;

            labelPlayer1.Text = p1.captainName;
            labelPlayer2.Text = p2.captainName;

            labelHPPlayer1.Text = "HP : " + hpP1 + " / 3";
            labelHPPlayer2.Text = "HP : " + hpP2 + " / 3";

            labelScorePlayer1.Text = "Score : " + p1.score;
            labelScorePlayer2.Text = "Score : " + p2.score;

            labelTurn.Text = "TURN : " + currentTurnPlayer.captainName;

            checkboxUseDouble.Checked = false;
            checkboxUseDouble.Text = "Use Double Score Token (" + currentTurnPlayer.doubleScore + ")";

            if (currentTurnPlayer.doubleScore > 0)
            {
                checkboxUseDouble.Enabled = true;
            }
            else
            {
                checkboxUseDouble.Enabled = false;
            }
        }

        // ATTACK COMMAND (groupBox4)
        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (comboboxTarget.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih posisi target terlebih dahulu!");
                return;
            }

            int targetPos = int.Parse(comboboxTarget.SelectedItem.ToString());
            Player targetPlayer;
            List<int> enemyShips;

            if (currentTurnPlayer == this.formMenu.formLogin.data.CurrentPlayer)
            {
                targetPlayer = this.enemyPlayer;
                enemyShips = shipsP2;
            }
            else
            {
                targetPlayer = this.formMenu.formLogin.data.CurrentPlayer;
                enemyShips = shipsP1;
            }

            bool isHit = false;
            if (enemyShips.Contains(targetPos))
            {
                isHit = true;
                enemyShips.Remove(targetPos);

                if (targetPlayer == this.enemyPlayer)
                {
                    hpP2--;
                }
                else
                {
                    hpP1--;
                }
            }

            int scoreChange = 0;
            if (radioNormalShot.Checked)
            {
                scoreChange = isHit ? 20 : 0;
            }
            else if (radioPowerShot.Checked)
            {
                scoreChange = isHit ? 40 : -10;
            }

            if (checkboxUseDouble.Checked && currentTurnPlayer.doubleScore > 0)
            {
                scoreChange *= 2;
                currentTurnPlayer.doubleScore--;
            }

            currentTurnPlayer.score += scoreChange;

            string posFormatted = targetPos < 10 ? "0" + targetPos : targetPos.ToString();

            if (isHit)
            {
                int sisaHpTarget = (targetPlayer == this.enemyPlayer) ? hpP2 : hpP1;
                string hitText = currentTurnPlayer.captainName + " menyerang posisi " + posFormatted + "\n\n" +
                                 "HIT!\n" +
                                 "Score " + (scoreChange >= 0 ? "+" : "") + scoreChange + "\n\n" +
                                 "HP " + targetPlayer.captainName + " : " + sisaHpTarget + " / 3";
                MessageBox.Show(hitText, "HIT!");
            }
            else
            {
                string missText = currentTurnPlayer.captainName + " menyerang posisi " + posFormatted + "\n\n" +
                                  "MISS!\n" +
                                  "Score " + (scoreChange >= 0 ? "+" : "") + scoreChange;
                MessageBox.Show(missText, "MISS!");
            }

            if (hpP1 <= 0 || hpP2 <= 0)
            {
                Player winner = (hpP2 <= 0) ? this.formMenu.formLogin.data.CurrentPlayer : this.enemyPlayer;
                Player loser = (hpP2 <= 0) ? this.enemyPlayer : this.formMenu.formLogin.data.CurrentPlayer;

                winner.score += 100;
                winner.win += 1;
                loser.lose += 1;

                UpdateBattleStatus();

                string finishMsg = winner.captainName + " memenangkan pertandingan!\n\n" +
                                   "Victory Bonus : +100 Score\n\n" +
                                   winner.captainName + "\n" +
                                   "Score : " + winner.score + "\n" +
                                   "Win : " + winner.win + "\n\n" +
                                   loser.captainName + "\n" +
                                   "Score : " + loser.score + "\n" +
                                   "Lose : " + loser.lose;

                MessageBox.Show(finishMsg, "BATTLE FINISHED");
                groupBox4.Enabled = false;
                return;
            }

            if (currentTurnPlayer == this.formMenu.formLogin.data.CurrentPlayer)
            {
                currentTurnPlayer = this.enemyPlayer;
            }
            else
            {
                currentTurnPlayer = this.formMenu.formLogin.data.CurrentPlayer;
            }

            comboboxTarget.SelectedIndex = -1;
            UpdateBattleStatus();
        }

    }
}
