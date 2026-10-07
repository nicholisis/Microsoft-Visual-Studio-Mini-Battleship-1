using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M1VP
{
    public partial class Register : Form
    {
        private Login formLogin;
        private int doubleScore;
        private int score;

        public Register(Login formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.formLogin.Show();
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (inputName.Text == "" || inputPass.Text == "" || inputCapt.Text == "")
            {
                MessageBox.Show("Inputan harus valid. Jangan kosong!");
                return;
            }

            if (!radioMale.Checked && !radioFemale.Checked)
            {
                MessageBox.Show("Harap pilih salah satu gender!");
                return;
            }

            if (!checkboxScore.Checked && !checkboxDouble.Checked)
            {
                MessageBox.Show("Harap pilih salah satu bonus yang tersedia!");
                return;
            }

            foreach (Player p in this.formLogin.data.ListPlayer)
            {
                if (p.username == inputName.Text)
                {
                    MessageBox.Show("Username sudah digunakan!");
                    return;
                }
            }

            if (checkboxDouble.Checked)
            {
                doubleScore = 1;
                score = 0;
            }
            if (checkboxScore.Checked)
            {
                doubleScore = 0;
                score = 50;
            }

            string genderPilih = radioMale.Checked ? "Male" : "Female";
            this.formLogin.data.ListPlayer.Add(new Player(inputName.Text, inputPass.Text, inputCapt.Text, genderPilih, score, doubleScore));
            MessageBox.Show("Registrasi berhasil!");

            this.formLogin.Show();
            this.Close();
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            radioFemale.Checked = !radioMale.Checked;
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            radioMale.Checked = !radioFemale.Checked;
        }

        private void checkboxScore_CheckedChanged(object sender, EventArgs e)
        {
            checkboxDouble.Checked = !checkboxScore.Checked;
        }

        private void checkboxDouble_CheckedChanged(object sender, EventArgs e)
        {
            checkboxScore.Checked = !checkboxDouble.Checked;
        }
    }
}
