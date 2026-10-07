namespace M1VP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            buttonLogin = new Button();
            inputLoginPass = new TextBox();
            label5 = new Label();
            inputLoginUser = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(65, 196, 225);
            label1.Location = new Point(106, 53);
            label1.Name = "label1";
            label1.Size = new Size(317, 46);
            label1.TabIndex = 0;
            label1.Text = "BATTLESHIP MINI ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 38, 52);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(inputLoginPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(inputLoginUser);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(87, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 337);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 52, 68);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(172, 236);
            button2.Name = "button2";
            button2.Size = new Size(133, 48);
            button2.TabIndex = 9;
            button2.Text = "CREATE ACCOUNT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(48, 145, 205);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(40, 236);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(126, 48);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // inputLoginPass
            // 
            inputLoginPass.BackColor = Color.FromArgb(35, 52, 68);
            inputLoginPass.ForeColor = SystemColors.Window;
            inputLoginPass.Location = new Point(40, 187);
            inputLoginPass.Name = "inputLoginPass";
            inputLoginPass.Size = new Size(262, 27);
            inputLoginPass.TabIndex = 7;
            inputLoginPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(185, 201, 218);
            label5.Location = new Point(45, 164);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 6;
            label5.Text = "PASSWORD";
            // 
            // inputLoginUser
            // 
            inputLoginUser.BackColor = Color.FromArgb(35, 52, 68);
            inputLoginUser.ForeColor = SystemColors.Window;
            inputLoginUser.Location = new Point(40, 119);
            inputLoginUser.Name = "inputLoginUser";
            inputLoginUser.Size = new Size(262, 27);
            inputLoginUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(185, 201, 218);
            label4.Location = new Point(40, 96);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(25, 38, 52);
            label3.Location = new Point(45, 86);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(87, 33);
            label2.Name = "label2";
            label2.Size = new Size(185, 31);
            label2.TabIndex = 0;
            label2.Text = "CAPTAIN LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 34);
            ClientSize = new Size(532, 592);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Battleship Mini - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox inputLoginUser;
        private Button button2;
        private Button buttonLogin;
        private TextBox inputLoginPass;
    }
}
