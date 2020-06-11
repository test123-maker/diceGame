using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dadosGame
{
    class Players
    {
        private string name;
        private string nick;
        private string age;

        public string Name { get => name; set => name = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Age { get => age; set => age = value; }

        public void registerPlayer(int player)
        {
            Connectiontomysql mysql = new Connectiontomysql();
            RegisterForm rf = new RegisterForm();

            string command = "INSERT INTO players (name, nick, age) VALUES ('" + Name + "', '" + Nick + "', '" + Age + "')";
            mysql.commandMysql(command);

            if (player == 1)
            {
                MessageBox.Show("Player 1 registered successfully");
            }

            else if (player == 2)
            {
                MessageBox.Show("Player 2 registered successfully");
            }
        }


    }
}
