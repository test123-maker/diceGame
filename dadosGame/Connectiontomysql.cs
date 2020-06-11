using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dadosGame
{
    class Connectiontomysql
    {
        string connetionString = "server=localhost;database=gamedados;uid=root;pwd=;";
        

        public MySqlConnection openConnection()
        {
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot open connection ! " + e);
            }

            return cnn;
        }

        public void commandMysql(string command)
        {
            MySqlConnection cnn = openConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(command, cnn);
                int value = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("MySQL command failed ! " + e);
            }
        }



    }
}
