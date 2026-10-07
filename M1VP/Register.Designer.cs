namespace M1VP
{
    partial class Register
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
            label2 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            checkboxDouble = new CheckBox();
            checkboxScore = new CheckBox();
            groupBox1 = new GroupBox();
            radioFemale = new RadioButton();
            radioMale = new RadioButton();
            inputCapt = new TextBox();
            label6 = new Label();
            buttonBack = new Button();
            buttonCreate = new Button();
            inputPass = new TextBox();
            label5 = new Label();
            inputName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(65, 196, 225);
            label1.Location = new Point(100, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(65, 196, 225);
            label2.Location = new Point(71, 47);
            label2.Name = "label2";
            label2.Size = new Size(398, 46);
            label2.TabIndex = 2;
            label2.Text = "CREATE YOUR CAPTAIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 38, 52);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(inputCapt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(inputPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(inputName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(71, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 533);
            panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkboxDouble);
            groupBox2.Controls.Add(checkboxScore);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(29, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 86);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "STARTER BONUS - PICK ONE";
            // 
            // checkboxDouble
            // 
            checkboxDouble.AutoSize = true;
            checkboxDouble.Location = new Point(142, 37);
            checkboxDouble.Name = "checkboxDouble";
            checkboxDouble.Size = new Size(190, 24);
            checkboxDouble.TabIndex = 1;
            checkboxDouble.Text = "+ 1 Double Score Token";
            checkboxDouble.UseVisualStyleBackColor = true;
            checkboxDouble.CheckedChanged += checkboxDouble_CheckedChanged;
            // 
            // checkboxScore
            // 
            checkboxScore.AutoSize = true;
            checkboxScore.Location = new Point(22, 37);
            checkboxScore.Name = "checkboxScore";
            checkboxScore.Size = new Size(98, 24);
            checkboxScore.TabIndex = 0;
            checkboxScore.Text = "+50 Score";
            checkboxScore.UseVisualStyleBackColor = true;
            checkboxScore.CheckedChanged += checkboxScore_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioFemale);
            groupBox1.Controls.Add(radioMale);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(29, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 81);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "GENDER";
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(136, 35);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(78, 24);
            radioFemale.TabIndex = 1;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            radioFemale.CheckedChanged += radioFemale_CheckedChanged;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(22, 35);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(63, 24);
            radioMale.TabIndex = 0;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            radioMale.CheckedChanged += radioMale_CheckedChanged;
            // 
            // inputCapt
            // 
            inputCapt.BackColor = Color.FromArgb(35, 52, 68);
            inputCapt.ForeColor = SystemColors.Window;
            inputCapt.Location = new Point(29, 201);
            inputCapt.Name = "inputCapt";
            inputCapt.Size = new Size(338, 27);
            inputCapt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(185, 201, 218);
            label6.Location = new Point(29, 178);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 10;
            label6.Text = " CAPTAIN NAME";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(35, 52, 68);
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = SystemColors.ButtonHighlight;
            buttonBack.Location = new Point(207, 463);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(160, 48);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "BACK";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(66, 190, 125);
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreate.ForeColor = SystemColors.ButtonHighlight;
            buttonCreate.Location = new Point(29, 463);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(160, 48);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "CREATE ACCOUNT";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // inputPass
            // 
            inputPass.BackColor = Color.FromArgb(35, 52, 68);
            inputPass.ForeColor = SystemColors.Window;
            inputPass.Location = new Point(29, 132);
            inputPass.Name = "inputPass";
            inputPass.Size = new Size(338, 27);
            inputPass.TabIndex = 7;
            inputPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(185, 201, 218);
            label5.Location = new Point(29, 109);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 6;
            label5.Text = "PASSWORD";
            // 
            // inputName
            // 
            inputName.BackColor = Color.FromArgb(35, 52, 68);
            inputName.ForeColor = SystemColors.Window;
            inputName.Location = new Point(29, 64);
            inputName.Name = "inputName";
            inputName.Size = new Size(338, 27);
            inputName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(185, 201, 218);
            label4.Location = new Point(29, 41);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(25, 38, 52);
            label3.Location = new Point(34, 31);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "USERNAME";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 34);
            ClientSize = new Size(528, 704);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = " Battleship Mini - Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox inputCapt;
        private Label label6;
        private Button buttonBack;
        private Button buttonCreate;
        private TextBox inputPass;
        private Label label5;
        private TextBox inputName;
        private Label label4;
        private Label label3;
        private RadioButton radioButton1;
        private CheckBox checkboxDouble;
        private CheckBox checkboxScore;
        private RadioButton radioFemale;
        private RadioButton radioMale;
    }
}