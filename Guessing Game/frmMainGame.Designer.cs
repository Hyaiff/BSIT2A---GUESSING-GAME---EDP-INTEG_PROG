namespace Guessing_Game
{
    partial class frmGuessingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuessingGame));
            this.lblTitle = new System.Windows.Forms.Label();
            this.word1 = new System.Windows.Forms.Label();
            this.word2 = new System.Windows.Forms.Label();
            this.word3 = new System.Windows.Forms.Label();
            this.word4 = new System.Windows.Forms.Label();
            this.userGuess = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.word5 = new System.Windows.Forms.Label();
            this.word6 = new System.Windows.Forms.Label();
            this.word7 = new System.Windows.Forms.Label();
            this.word8 = new System.Windows.Forms.Label();
            this.word9 = new System.Windows.Forms.Label();
            this.word10 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblCD = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(6, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Guess The Word";
            // 
            // word1
            // 
            this.word1.AutoSize = true;
            this.word1.BackColor = System.Drawing.Color.Transparent;
            this.word1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word1.Location = new System.Drawing.Point(59, 105);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(78, 25);
            this.word1.TabIndex = 1;
            this.word1.Text = "WORD";
            // 
            // word2
            // 
            this.word2.AutoSize = true;
            this.word2.BackColor = System.Drawing.Color.Transparent;
            this.word2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2.Location = new System.Drawing.Point(59, 130);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(78, 25);
            this.word2.TabIndex = 2;
            this.word2.Text = "WORD";
            // 
            // word3
            // 
            this.word3.AutoSize = true;
            this.word3.BackColor = System.Drawing.Color.Transparent;
            this.word3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word3.Location = new System.Drawing.Point(59, 155);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(78, 25);
            this.word3.TabIndex = 3;
            this.word3.Text = "WORD";
            // 
            // word4
            // 
            this.word4.AutoSize = true;
            this.word4.BackColor = System.Drawing.Color.Transparent;
            this.word4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word4.Location = new System.Drawing.Point(59, 180);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(78, 25);
            this.word4.TabIndex = 4;
            this.word4.Text = "WORD";
            // 
            // userGuess
            // 
            this.userGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuess.Location = new System.Drawing.Point(98, 306);
            this.userGuess.Name = "userGuess";
            this.userGuess.Size = new System.Drawing.Size(422, 31);
            this.userGuess.TabIndex = 5;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(431, 343);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(89, 29);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // word5
            // 
            this.word5.AutoSize = true;
            this.word5.BackColor = System.Drawing.Color.Transparent;
            this.word5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word5.Location = new System.Drawing.Point(59, 205);
            this.word5.Name = "word5";
            this.word5.Size = new System.Drawing.Size(78, 25);
            this.word5.TabIndex = 8;
            this.word5.Text = "WORD";
            // 
            // word6
            // 
            this.word6.AutoSize = true;
            this.word6.BackColor = System.Drawing.Color.Transparent;
            this.word6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word6.Location = new System.Drawing.Point(384, 105);
            this.word6.Name = "word6";
            this.word6.Size = new System.Drawing.Size(78, 25);
            this.word6.TabIndex = 9;
            this.word6.Text = "WORD";
            // 
            // word7
            // 
            this.word7.AutoSize = true;
            this.word7.BackColor = System.Drawing.Color.Transparent;
            this.word7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word7.Location = new System.Drawing.Point(384, 130);
            this.word7.Name = "word7";
            this.word7.Size = new System.Drawing.Size(78, 25);
            this.word7.TabIndex = 10;
            this.word7.Text = "WORD";
            // 
            // word8
            // 
            this.word8.AutoSize = true;
            this.word8.BackColor = System.Drawing.Color.Transparent;
            this.word8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word8.Location = new System.Drawing.Point(384, 155);
            this.word8.Name = "word8";
            this.word8.Size = new System.Drawing.Size(78, 25);
            this.word8.TabIndex = 11;
            this.word8.Text = "WORD";
            // 
            // word9
            // 
            this.word9.AutoSize = true;
            this.word9.BackColor = System.Drawing.Color.Transparent;
            this.word9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word9.Location = new System.Drawing.Point(384, 180);
            this.word9.Name = "word9";
            this.word9.Size = new System.Drawing.Size(78, 25);
            this.word9.TabIndex = 12;
            this.word9.Text = "WORD";
            // 
            // word10
            // 
            this.word10.AutoSize = true;
            this.word10.BackColor = System.Drawing.Color.Transparent;
            this.word10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word10.Location = new System.Drawing.Point(384, 205);
            this.word10.Name = "word10";
            this.word10.Size = new System.Drawing.Size(78, 25);
            this.word10.TabIndex = 13;
            this.word10.Text = "WORD";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.word10);
            this.groupBox1.Controls.Add(this.userGuess);
            this.groupBox1.Controls.Add(this.word1);
            this.groupBox1.Controls.Add(this.word9);
            this.groupBox1.Controls.Add(this.word3);
            this.groupBox1.Controls.Add(this.word8);
            this.groupBox1.Controls.Add(this.word2);
            this.groupBox1.Controls.Add(this.word7);
            this.groupBox1.Controls.Add(this.word4);
            this.groupBox1.Controls.Add(this.word6);
            this.groupBox1.Controls.Add(this.word5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 458);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(6, 423);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 29);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<-- back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(551, 16);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(43, 13);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = "label2";
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCD.Location = new System.Drawing.Point(65, 170);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(391, 55);
            this.lblCD.TabIndex = 14;
            this.lblCD.Text = "Game starts in...";
            this.lblCD.Click += new System.EventHandler(this.lblCD_Click);
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGuessingGame_FormClosing);
            this.Load += new System.EventHandler(this.frmGuessingGame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label word1;
        private System.Windows.Forms.Label word2;
        private System.Windows.Forms.Label word3;
        private System.Windows.Forms.Label word4;
        private System.Windows.Forms.TextBox userGuess;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label word5;
        private System.Windows.Forms.Label word6;
        private System.Windows.Forms.Label word7;
        private System.Windows.Forms.Label word8;
        private System.Windows.Forms.Label word9;
        private System.Windows.Forms.Label word10;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnBack;
    }
}

