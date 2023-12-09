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
    public partial class Form2 : Form
    {
        int user_account;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=bankingdatabase; password=";
            MySqlConnection m = new MySqlConnection(mysqlCon);

             user_account = Int32.Parse(account_field.Text);
             

            string user_password = password_field.Text.ToString();
            /*if (String.IsNullOrEmpty(user_account) || String.IsNullOrEmpty(user_password))
            {
                MessageBox.Show("No empty field allowed");

            }*/
            try
            {
            
                MySqlCommand command = new MySqlCommand("select * from information", m);
                m.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (user_account.Equals(reader.GetInt32("AccountNumber"))||(user_password.Equals(reader.GetString("Password"))))
                    {
                        MessageBox.Show("Login Successful");



                        Form3 f = new Form3();
                        f.ab(user_account);

                        f.Show();
                        break;

                       

                    }
                   
                    else
                    {
                        MessageBox.Show("Unable to Login");
                        
                    }
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        

            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
             password_field.UseSystemPasswordChar = true;
            }
            else
            {
                password_field.UseSystemPasswordChar = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void account_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


/*            Users u = new Users();
            u.Show();
            this.Hide();*/

        }

    




