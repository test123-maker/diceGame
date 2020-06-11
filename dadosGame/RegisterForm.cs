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
    public partial class RegisterForm : Form
    {
        private bool player1;
        private bool player2;
        string nick1;
        string nick2;
        Thread jogo;

        public RegisterForm()
        {
            InitializeComponent();
            player1 = false;
            player2 = false;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Players p = new Players();
            p.Name = txtName.Text;
            p.Nick = txtNickname.Text;
            p.Age = txtAge.Text;
            int player = 0;

            if (rdbPlayer1.Checked)
            {
                nick1 = txtNickname.Text;
                player1 = true;
                player = 1;
            }

            else if (rdbPlayer2.Checked)
            {
                nick2 = txtNickname.Text;
                player2 = true;
                player = 2;
            }

            p.registerPlayer(player);
            iniciateGame();
        }

        private void runGameForm()
        {
            //Application.Run(new FormMain());
        }

        private void iniciateGame()
        {
            if (player1 == true && player2 == true)
            {
                btnStart.Enabled = true; 
            }
        }

        private void rdbPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtNickname.Text = "";
        }

        private void rdbPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtNickname.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
            jogo = new Thread(newGame);
            jogo.SetApartmentState(ApartmentState.STA);
            jogo.Start();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void newGame()
        {
            Application.Run(new FormMain(nick1, nick2));
        }

    }
}
