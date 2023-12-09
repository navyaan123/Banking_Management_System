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
    public partial class Form3 : Form
    {
        int b;

        public Form3()
        {
            InitializeComponent();
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ab(int user_account)
        {

            b = user_account;



            string mysqlCon = "server=127.0.0.1; user=root; database=bankingdatabase; password=";

            MySqlConnection connection = new MySqlConnection(mysqlCon);
            MySqlDataAdapter adapter;
            MySqlCommand command;
            DataTable table;


            string query = "select * from information where AccountNumber= ' " + user_account + " '  ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f  = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
