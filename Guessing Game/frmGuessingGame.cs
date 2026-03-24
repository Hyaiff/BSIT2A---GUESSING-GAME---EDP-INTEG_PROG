using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class frmMainMenu : Form
    {
        string diffOption = "NORMAL" ;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        //Play/StartGame Button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmGuessingGame game = new frmGuessingGame();
            game.SelectedDifficulty = diffOption;
            game.Show();
            this.Hide();
        }

        //Selecting Difficulty Button
        private void btnSelectDifficulty_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Select Difficulty: \n\nYes = EASY\nNo = NORMAL\nCancel = HARD", "Difficulty Selection", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)            {
                diffOption = "EASY";
            }
            else if (result == DialogResult.No)           {
                diffOption = "NORMAL";
            }
            else if (result == DialogResult.Cancel)             {
                diffOption = "HARD";
            }
            btnSelectDifficulty.Text = "Difficulty: " + diffOption;
        }

        //Quit/Exit Buttion
        private void btnQuit_Click(object sender, EventArgs e)       {
            Application.Exit();
        }
        private void eASYToolStripMenuItem_Click(object sender, EventArgs e)       {
            diffOption = "EASY";
            btnSelectDifficulty.Text = "Difficulty: EASY";
        }
        private void nORMALToolStripMenuItem_Click(object sender, EventArgs e)        {
            diffOption = "NORMAL";
            btnSelectDifficulty.Text = "Difficulty: NORMAL";
        }
        private void hARDToolStripMenuItem_Click(object sender, EventArgs e)        {
            diffOption = "HARD";
            btnSelectDifficulty.Text = "Difficulty: HARD";
        }
    }
}
