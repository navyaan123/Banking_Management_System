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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* try
             {
                 String account_field = Account_field.Text.ToString();

                 int amount_field = Int32.Parse(Amount_field.Text);

                 //This is my connection string i have assigned the database file address path
                 string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=bankingdatabase";
                 //This is my insert query in which i am taking input from the user through windows forms
                 string Query = "insert into transaction(AccountNumber,Amount) " +
                  "values(' " + account_field + " ',' " + amount_field + " ');";
                 //This is  MySqlConnection here i have created the object and pass my connection string.
                 MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                 //This is command class which will handle the query and connection object.
                 MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                 MySqlDataReader MyReader2;
                 MyConn2.Open();
                 MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                 MessageBox.Show("Save Data");
                 while (MyReader2.Read())
                 {
                 }
                 MyConn2.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/

            try
                        {
                            String account_field = Account_field.Text.ToString();

                            int amount_field = Int32.Parse(Amount_field.Text);

                            //This is my connection string i have assigned the database file address path
                            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=bankingdatabase";
                            //This is my insert query in which i am taking input from the user through windows forms
                            string Query = "update information set Amount=Amount+' " + amount_field + " ' where AccountNumber = ' "   + account_field+  " ' ;";
                            //This is  MySqlConnection here i have created the object and pass my connection string.
                            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                            //This is command class which will handle the query and connection object.
                            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                            MySqlDataReader MyReader2;
                            MyConn2.Open();
                            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                            MessageBox.Show("Amount deposit Sucessfully");
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




        private void Deposit_Load(object sender, EventArgs e)
        {
            
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
    }



