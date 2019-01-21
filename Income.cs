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

namespace WindowsFormsApplication1
{
    public partial class Income : Form
    {
        MySqlConnection conn = new MySqlConnection(@"datasource = 127.0.0.1;port=3306;username=root;password=''");

        public Income()
        {
            InitializeComponent();
        }

        private void garis3_Click(object sender, EventArgs e)
        {
            Garis3 garis3 = new Garis3();
            garis3.Show();
            this.Hide();
        }

        private void ic_Click(object sender, EventArgs e)
        {
          
            try
            {
                DataTable datatabel;
                MySqlCommand command = conn.CreateCommand();
                conn.Open();
                command.CommandText = "SELECT * FROM transaction WHERE type='Expenses'";
                datatabel = new DataTable();
                
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(datatabel);
                dataGridView1.DataSource = datatabel;

                DataView dv = new DataView(datatabel);
                dv.RowFilter = string.Format("date='" + dateTimePicker1.Text + "'"); dataGridView1.DataSource = dv;
                conn.Close();

            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("bacod" + kesalahan);
            }
        }

        private void ex_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }

        private void ic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
