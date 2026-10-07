namespace M1VP
{
    partial class Leaderboard
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
            listLeaderboard = new ListBox();
            buttonSort = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // listLeaderboard
            // 
            listLeaderboard.BackColor = Color.FromArgb(25, 38, 52);
            listLeaderboard.BorderStyle = BorderStyle.None;
            listLeaderboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listLeaderboard.ForeColor = SystemColors.HighlightText;
            listLeaderboard.FormattingEnabled = true;
            listLeaderboard.Location = new Point(43, 62);
            listLeaderboard.Name = "listLeaderboard";
            listLeaderboard.Size = new Size(445, 276);
            listLeaderboard.TabIndex = 0;
            listLeaderboard.SelectedIndexChanged += listLeaderboard_SelectedIndexChanged;
            // 
            // buttonSort
            // 
            buttonSort.BackColor = Color.FromArgb(48, 145, 205);
            buttonSort.FlatAppearance.BorderSize = 0;
            buttonSort.FlatStyle = FlatStyle.Flat;
            buttonSort.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSort.ForeColor = SystemColors.ButtonHighlight;
            buttonSort.Location = new Point(43, 379);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(210, 50);
            buttonSort.TabIndex = 19;
            buttonSort.Text = "SORT BY SCORE";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(35, 52, 68);
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(284, 379);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(204, 50);
            buttonBack.TabIndex = 20;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 34);
            ClientSize = new Size(537, 483);
            Controls.Add(buttonBack);
            Controls.Add(buttonSort);
            Controls.Add(listLeaderboard);
            Name = "Leaderboard";
            Text = "Battleship Mini - Leaderboard";
            Load += Leaderboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listLeaderboard;
        private Button buttonSort;
        private Button buttonBack;
    }
}