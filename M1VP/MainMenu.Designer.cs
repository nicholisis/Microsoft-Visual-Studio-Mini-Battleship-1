namespace M1VP
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelCaptain = new Label();
            groupBox1 = new GroupBox();
            labelDouble = new Label();
            labelWin = new Label();
            labelLose = new Label();
            labelScore = new Label();
            buttonLogout = new Button();
            buttonStart = new Button();
            buttonLeaderboard = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(65, 196, 225);
            label1.Location = new Point(208, 49);
            label1.Name = "label1";
            label1.Size = new Size(317, 46);
            label1.TabIndex = 1;
            label1.Text = "BATTLESHIP MINI ";
            // 
            // labelCaptain
            // 
            labelCaptain.AutoSize = true;
            labelCaptain.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCaptain.ForeColor = Color.WhiteSmoke;
            labelCaptain.Location = new Point(66, 117);
            labelCaptain.Name = "labelCaptain";
            labelCaptain.Size = new Size(207, 31);
            labelCaptain.TabIndex = 2;
            labelCaptain.Text = "Welcome, Captain";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(25, 38, 52);
            groupBox1.Controls.Add(labelDouble);
            groupBox1.Controls.Add(labelWin);
            groupBox1.Controls.Add(labelLose);
            groupBox1.Controls.Add(labelScore);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(66, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 177);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "CAPTAIN STATUS";
            // 
            // labelDouble
            // 
            labelDouble.AutoSize = true;
            labelDouble.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDouble.ForeColor = Color.WhiteSmoke;
            labelDouble.Location = new Point(286, 111);
            labelDouble.Name = "labelDouble";
            labelDouble.Size = new Size(173, 28);
            labelDouble.TabIndex = 7;
            labelDouble.Text = "DOUBLE TOKEN: ";
            // 
            // labelWin
            // 
            labelWin.AutoSize = true;
            labelWin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWin.ForeColor = Color.WhiteSmoke;
            labelWin.Location = new Point(286, 47);
            labelWin.Name = "labelWin";
            labelWin.Size = new Size(59, 28);
            labelWin.TabIndex = 6;
            labelWin.Text = "WIN:";
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLose.ForeColor = Color.WhiteSmoke;
            labelLose.Location = new Point(43, 111);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(70, 28);
            labelLose.TabIndex = 5;
            labelLose.Text = "LOSE: ";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.ForeColor = Color.WhiteSmoke;
            labelScore.Location = new Point(43, 47);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(79, 28);
            labelScore.TabIndex = 4;
            labelScore.Text = "SCORE:";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(210, 75, 75);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ButtonHighlight;
            buttonLogout.Location = new Point(217, 447);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(285, 48);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(57, 174, 246);
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = SystemColors.ButtonHighlight;
            buttonStart.Location = new Point(66, 378);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(267, 48);
            buttonStart.TabIndex = 10;
            buttonStart.Text = "START BATTLE";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonLeaderboard
            // 
            buttonLeaderboard.BackColor = Color.FromArgb(35, 52, 68);
            buttonLeaderboard.FlatAppearance.BorderSize = 0;
            buttonLeaderboard.FlatStyle = FlatStyle.Flat;
            buttonLeaderboard.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLeaderboard.ForeColor = SystemColors.ButtonHighlight;
            buttonLeaderboard.Location = new Point(380, 378);
            buttonLeaderboard.Name = "buttonLeaderboard";
            buttonLeaderboard.Size = new Size(264, 48);
            buttonLeaderboard.TabIndex = 11;
            buttonLeaderboard.Text = "LEADERBOARD";
            buttonLeaderboard.UseVisualStyleBackColor = false;
            buttonLeaderboard.Click += buttonLeaderboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(120, 144, 157);
            label2.Location = new Point(241, 511);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 12;
            label2.Text = " Destroy all 5 enemy ships to win.";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 34);
            ClientSize = new Size(710, 564);
            Controls.Add(label2);
            Controls.Add(buttonLeaderboard);
            Controls.Add(buttonStart);
            Controls.Add(buttonLogout);
            Controls.Add(groupBox1);
            Controls.Add(labelCaptain);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "Battleship Mini - Main Menu";
            Load += MainMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCaptain;
        private GroupBox groupBox1;
        private Label labelLose;
        private Label labelScore;
        private Label labelDouble;
        private Label labelWin;
        private Button buttonLogout;
        private Button buttonStart;
        private Button buttonLeaderboard;
        private Label label2;
    }
}