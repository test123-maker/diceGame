using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace dadosGame
{
    public partial class FormMain : Form
    {
        int number1;
        int number2;
        int player1life = 10;
        int player2life = 10;
        Random ran = new Random();
        private Image[] imagensDado = new Image[8];
        Boolean roundBegin;

        public FormMain(string player1, string player2)
        {
            InitializeComponent();
            IniciateImagens();
            btnPlayer1.Text = player1;
            btnPlayer2.Text = player2;
        }

        public int generateRandomNumber()
        {
            int number = ran.Next(1, 7);
            return number;
        }

        private void IniciateImagens()
        {
            imagensDado[0] = Properties.Resources.dado0;
            imagensDado[1] = Properties.Resources.dado1;
            imagensDado[2] = Properties.Resources.dado2;
            imagensDado[3] = Properties.Resources.dado3;
            imagensDado[4] = Properties.Resources.dado4;
            imagensDado[5] = Properties.Resources.dado5;
            imagensDado[6] = Properties.Resources.dado6;

        }


        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            number1 = generateRandomNumber();
            ptbPlayer1.Image = imagensDado[number1];
            btnPlayer1.Enabled = false;
            btnPlayer2.Enabled = true;
            roundBegin = false;
            lbl_Vencedor.Text = "";
            round();
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            number2 = generateRandomNumber();
            ptbPlayer2.Image = imagensDado[number2];
            btnPlayer1.Enabled = true;
            btnPlayer2.Enabled = false;
            roundBegin = true;
            round();
        }

        private void round()
        {
            if (roundBegin == true) {
                if (number1 != 0 && number2 != 0)
                {
                    if (number1 > number2)
                    {
                        MessageBox.Show("Player 1 Won The Round");
                        lbl_Vencedor.Text = "Player 1 won the last round";
                        player2life -= 1;
                        lbl_2.Text = player2life.ToString();
                        restartCubes();
                    }

                    else if (number2 > number1)
                    {
                        MessageBox.Show("Player 2 Won The Round");
                        lbl_Vencedor.Text = "Player 2 won the last round";
                        player1life -= 1;
                        lbl_1.Text = player1life.ToString();
                        restartCubes();
                    }

                    else
                    {
                        MessageBox.Show("Nobody Won");
                        lbl_Vencedor.Text = "DRAW";
                    }
                }

                winner(player1life, player2life);
            }
        }


        public void winner(int player1life, int player2life)
        {
            if (player1life == 0)
            {
                lbl_Vencedor.Text = "Player 2 WON THE GAME";
                MessageBox.Show("Player 2 WON THE GAME");
                finishGame();
                
            }
            else if (player2life == 0)
            {
                lbl_Vencedor.Text = "Player 1 WON THE GAME";
                MessageBox.Show("Player 1 WON THE GAME");
                finishGame();

            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void btnRegiter_Click(object sender, EventArgs e)
        {
            Thread registerForm;
            registerForm = new Thread(runRegister);
            registerForm.SetApartmentState(ApartmentState.STA);
            registerForm.Start();
        }

        private void runRegister()
        {
            Application.Run(new RegisterForm());
        }

        public void finishGame()
        {
            restartCubes();
            btnPlayer1.Enabled = false;
            btnPlayer2.Enabled = false;
        }

        public void restartCubes()
        {
            ptbPlayer1.Image = imagensDado[0];
            ptbPlayer2.Image = imagensDado[0];
        }

        public void restartGame()
        {
            number1 = 0;
            number2 = 0;
            restartCubes();
            lbl_Vencedor.Text = "The Winner Is...";
            btnPlayer1.Enabled = true;
            btnPlayer2.Enabled = false;
            player1life = 10;
            player2life = 10;
            lbl_1.Text = "10";
            lbl_2.Text = "10";
        }
    }
}
