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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();



        }

        private void LoadDataIntoDataGridView()
        {

            int user_account = Int32.Parse(Amount_field.Text);


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
            try
            {
                LoadDataIntoDataGridView();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();

        form.Show();
        this.Hide();
        }
    }
}
