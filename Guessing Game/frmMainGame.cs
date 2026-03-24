using System;
using System.Collections;
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
    public partial class frmGuessingGame : Form
    {
        int score = 0;
        int seconds = 60;
        
        public string SelectedDifficulty = "";
        public frmGuessingGame()
        {
            InitializeComponent();
        }

        private async void frmGuessingGame_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            lblCD.Visible = true;
            
            //countdown for timer using for-loop
            for (int a = 5; a>0; a--) 
            {
                lblCD.Text = "Game starts in..." + a.ToString();
                await Task.Delay(1000);
            }

            lblCD.Text = "GUESS THE WORD!";
            await Task.Delay(1000);

            lblCD.Visible = false;
            groupBox1.Visible = true;

            //Setting time for difficulties
            if (SelectedDifficulty == "EASY")            {
                seconds = 90;
            }
            else if (SelectedDifficulty == "HARD")            {
                seconds = 30;
            }
            else { 
                seconds = 60;
            }
            gameTimer.Start();
            userGuess.Focus();

            lblTimer.Text = "Time: " + seconds;
            lblTitle.Text = "Guess The Word - " + SelectedDifficulty;
            
            //Setting up words to guess using String Builder
            StringBuilder wordOne = new StringBuilder("1. C_ _P_T_R");
            word1.Text = wordOne.ToString();
            StringBuilder wordTwo = new StringBuilder("2. P_ _ _R  _UP_LY  U_I_");
            word2.Text = wordTwo.ToString();
            StringBuilder wordThree = new StringBuilder("3. G_A_ _ _ C  C_ R_");
            word3.Text = wordThree.ToString();
            StringBuilder wordFour = new StringBuilder("4. M_T_E_B_A_D");
            word4.Text = wordFour.ToString();
            StringBuilder wordFive = new StringBuilder("5. MO_ _T_R"); 
            word5.Text = wordFive.ToString();
            StringBuilder wordSix = new StringBuilder("6. R_ _");
            word6.Text = wordSix.ToString();
            StringBuilder wordSeven = new StringBuilder("7. _OO_I_G  _A_");
            word7.Text = wordSeven.ToString();
            StringBuilder wordEight = new StringBuilder("8. H_R_  _RI_ _");
            word8.Text = wordEight.ToString();
            StringBuilder wordNine = new StringBuilder("9. M_U_E");
            word9.Text = wordNine.ToString();
            StringBuilder wordTen = new StringBuilder("10. K_ _B_A_ D");
            word10.Text = wordTen.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Initializing words  using ArrayList
            ArrayList answers = new ArrayList();
            answers.Add("COMPUTER");
            answers.Add("POWER SUPPLY UNIT");
            answers.Add("GRAPHIC CARD");
            answers.Add("MOTHERBOARD");
            answers.Add("MONITOR");
            answers.Add("RAM");
            answers.Add("COOLING FAN");
            answers.Add("HARD DRIVE");
            answers.Add("MOUSE");
            answers.Add("KEYBOARD");

            string guess = userGuess.Text.ToUpper();

            //To check for guessed words to match AND if it contains the ciorrect words
            if (guess == "COMPUTER" && !word1.Text.Contains("COMPUTER"))
            {
                word1.Text = "1. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess.Equals("POWER SUPPLY UNIT") && !word1.Text.Contains("POWER SUPPLY UNIT"))
            {
                word2.Text = "2. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "GRAPHIC CARD" && !word1.Text.Contains("GRAPHIC CARD"))
            {
                word3.Text = "3. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "MOTHERBOARD" && !word1.Text.Contains("MOTHERBOARD"))
            {
                word4.Text = "4. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "MONITOR" && !word1.Text.Contains("MONITOR")) 
            {
                word5.Text = "5. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "RAM" && !word1.Text.Contains("RAM"))
            {
                word6.Text = "6. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "COOLING FAN" && !word1.Text.Contains("COOLING FAN"))
            {
                word7.Text = "7. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "HARD DRIVE" && !word1.Text.Contains("HARD DRIVE"))
            {
                word8.Text = "8. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "MOUSE" && !word1.Text.Contains("MOUSE"))
            {
                word9.Text = "9. " + guess;
                score++;
                userGuess.Text = "";
            }
            else if (guess == "KEYBOARD" && !word1.Text.Contains("KEYBOARD"))
            {
                word10.Text = "10. " + guess;
                score++;
                userGuess.Text = "";
            }

            //Set score/To check if all guessed words are correct
            if (score == 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Nice! You guessed all the words.\nFinal Score: " + score + "/10" + "\nTime Remaining: " + seconds + "seconds" + "\nReturning to Main Menu...");
                this.Close();
            }
            userGuess.Clear();
            userGuess.Focus();
        }

        //hide frmGameGUessing
        private void frmGuessingGame_FormClosing(object sender, FormClosingEventArgs e) {
            Form menu = Application.OpenForms["frmMainMenu"];
            if (menu != null) {
                menu.Show();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //display the time
            if (seconds > 0){
                seconds--;
                lblTimer.Text = "Time: " + seconds;
            }
            else{
                gameTimer.Stop();
                MessageBox.Show("Time's Up!\nFinal Score: " + score + "/10" + "\nTime Remaining: " + seconds + "seconds" + "\nReturning to Main Menu...");
                this.Close();
            }
            this.AcceptButton = btnEnter;
           
        }

        private void lblCD_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();

            //navigate back to frmMainMenu after user's play hte game
            Form menu = Application.OpenForms["frmMainMenu"];
            if (menu != null) 
            {
                menu.Show();
            }
            this.Close();
        }
    }
}
