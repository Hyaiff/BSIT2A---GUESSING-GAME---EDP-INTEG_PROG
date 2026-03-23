namespace Guessing_Game
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectDifficulty = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eASYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nORMALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "GUESS THE WORD GAME";
            // 
            // btnSelectDifficulty
            // 
            this.btnSelectDifficulty.ContextMenuStrip = this.container;
            this.btnSelectDifficulty.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDifficulty.Location = new System.Drawing.Point(170, 195);
            this.btnSelectDifficulty.Name = "btnSelectDifficulty";
            this.btnSelectDifficulty.Size = new System.Drawing.Size(303, 40);
            this.btnSelectDifficulty.TabIndex = 3;
            this.btnSelectDifficulty.Text = "Select Difficulty";
            this.btnSelectDifficulty.UseVisualStyleBackColor = true;
            this.btnSelectDifficulty.Click += new System.EventHandler(this.btnSelectDifficulty_Click);
            // 
            // container
            // 
            this.container.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eASYToolStripMenuItem,
            this.nORMALToolStripMenuItem,
            this.hARDToolStripMenuItem});
            this.container.Name = "contextMenuStrip1";
            this.container.Size = new System.Drawing.Size(125, 70);
            // 
            // eASYToolStripMenuItem
            // 
            this.eASYToolStripMenuItem.Name = "eASYToolStripMenuItem";
            this.eASYToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.eASYToolStripMenuItem.Text = "EASY";
            this.eASYToolStripMenuItem.Click += new System.EventHandler(this.eASYToolStripMenuItem_Click);
            // 
            // nORMALToolStripMenuItem
            // 
            this.nORMALToolStripMenuItem.Name = "nORMALToolStripMenuItem";
            this.nORMALToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.nORMALToolStripMenuItem.Text = "NORMAL";
            this.nORMALToolStripMenuItem.Click += new System.EventHandler(this.nORMALToolStripMenuItem_Click);
            // 
            // hARDToolStripMenuItem
            // 
            this.hARDToolStripMenuItem.Name = "hARDToolStripMenuItem";
            this.hARDToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hARDToolStripMenuItem.Text = "HARD";
            this.hARDToolStripMenuItem.Click += new System.EventHandler(this.hARDToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(170, 149);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(303, 40);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Start Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(170, 241);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(303, 40);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 482);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSelectDifficulty);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectDifficulty;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ContextMenuStrip container;
        private System.Windows.Forms.ToolStripMenuItem eASYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nORMALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hARDToolStripMenuItem;
    }
}