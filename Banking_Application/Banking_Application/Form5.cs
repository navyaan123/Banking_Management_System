using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banking_Application
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=bankingdatabase; password=";
            MySqlConnection m = new MySqlConnection(mysqlCon);


            string user_email = email_field.Text.ToString();
            string user_password = password_field.Text.ToString();


            /*if (String.IsNullOrEmpty(user_account) || String.IsNullOrEmpty(user_password))
            {
                MessageBox.Show("No empty field allowed");

            }*/
            try
            {

                MySqlCommand command = new MySqlCommand("select * from admin", m);
                m.Open();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (user_email.Equals(reader.GetString("Email")) || (user_password.Equals(reader.GetString("Password"))))
                    {
                        MessageBox.Show("Login Successful");

                    }
                    else
                    {
                        MessageBox.Show("Unable to Login");

                    }


                                 }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    } }
