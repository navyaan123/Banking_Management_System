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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=bankingdatabase";
                //This is my insert query in which i am taking input from the user through windows forms
                string user_name = name_textfield.Text.ToString();
                string userf_name = father_textfield.Text.ToString();
                string user_date = date_textfield.Text.ToString();

                Random r = new Random();

                int user_account = r.Next();


                string user_email = email_textfield.Text.ToString();
                string user_password = password_textfield.Text.ToString();


                string Query = "insert into information(AccountNumber,Name,Father_Name,Date_of_Birth,Email,Password) " +
     "values(' " + user_account + "'  ,  ' " + user_name + "','" + userf_name + "','" + user_date + "','" + user_email + "', '" + user_password + " ');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Your account has been created and your account number is " + user_account);

                Form2 form = new Form2();
                form.Show();
                this.Hide();
            


                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_textfield.UseSystemPasswordChar = true;
            }
            else
            {
                password_textfield.UseSystemPasswordChar = false;
            }
        }
    }
}
